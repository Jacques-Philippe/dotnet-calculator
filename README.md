[![Build Status](https://dev.azure.com/jacquespamiot/calculator/_apis/build/status/Jacques-Philippe.dotnet-calculator?branchName=master)](https://dev.azure.com/jacquespamiot/calculator/_build/latest?definitionId=1&branchName=master)

# What I'm hoping to achieve with this repo
A dotnet application hooked up to a full CICD pipeline.

## The dotnet application
I'll make a simple calculator class library which will be consumed by a console application which gathers and manages user input. Project structure:
-- calculator app soln
    |
    |--- class library
    |--- unit testing class library
    |--- console application (consumes class library)
    
What's different about this project is that it's public. The advantage to making projects public like this is that if you use resources which promote open-source software, i.e. GitHub, Azure DevOps, then you can do some pretty nifty things without spending anything. It just needs to be publicly available. To that end, in order to use Azure DevOps pipelines for free, we need to make a parallelism request [make your request here](https://aka.ms/azpipelines-parallelism-request).

# Issues I had along the way
## Authenticating with Github
It took me like two hours to push this repo onto Github just because of authentication woes. It was necessary for me to do two of the following:	
1. I had to create a Personal Access Token on GitHub, which you can do in Settings > Developer Settings > Personal Access Tokens.
1. I also had to have generated an ssh key via `ssh-keygen`
1. For whatever reason, it was necessary for me to add a config file to my ~/.ssh directory, with the following
```
Host github.com
User git
Port 22
Hostname github.com
IdentityFile ~/.ssh/id_rsa       
TCPKeepAlive yes
IdentitiesOnly yes
```

This was a really awful thing to be stuck on for this long, jeez.

By the way, even after being able to push, git was asking me for my username and password each time, which is far from ideal. To stop this happening, we can update the remote url to have the following pattern.

```
git remote set-url origin git@github.com:username/repo.git
```
