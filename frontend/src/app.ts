async function fetchCattle() {
  const appDiv = document.getElementById('app');
  if (!appDiv) return;

  try {
    const res = await fetch('/api/cattle');
    const data = await res.json();

    if (Array.isArray(data) && data.length > 0) {
      // Display as Bootstrap table
      let html = '<table class="table table-striped table-hover"><thead><tr>';
      html += '<th>ID</th><th>Name</th><th>Breed</th><th>Status</th></tr></thead><tbody>';
      
      data.forEach((cow: any) => {
        html += `<tr>
          <td>${cow.id || 'N/A'}</td>
          <td>${cow.name || 'N/A'}</td>
          <td>${cow.breed || 'N/A'}</td>
          <td><span class="badge bg-success">Active</span></td>
        </tr>`;
      });
      
      html += '</tbody></table>';
      appDiv.innerHTML = html;
      appDiv.className = 'alert alert-success';
    } else {
      appDiv.className = 'alert alert-warning';
      appDiv.innerHTML = '<strong>No cattle data found</strong>';
    }
  } catch (err) {
    appDiv.className = 'alert alert-danger';
    appDiv.innerHTML = `<strong>Error:</strong> ${err}`;
  }
}

fetchCattle();
