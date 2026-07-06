async function fetchDresses() 
{
  try 
  {
    const res = await fetch('/api/cattle');
    const data = await res.json();
    document.getElementById('app').innerText = JSON.stringify(data, null, 2);
  } 
  catch (err) 
  {
    document.getElementById('app').innerText = 'Contact your favorite grandkids, error: ' + err;
  }
}

fetchDresses();
