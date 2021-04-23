# CSharpPlayground


## Deployment
Before deployment remember to login to with the Heroku CLI (containers)
`heroku container:login`

### Containerizing the Docker Image and pushing it to Heroku
`docker build -t dotnetcore-testapp C:\Users\benja\Desktop\CSharp\CSharpPlayground\CSharpPlayground\CSharpPlayground\bin\Release\netcoreapp3.1\publish`
`docker tag dotnetcore-testapp registry.heroku.com/dotnetcore-testapp`
`docker push registry.heroku.com/dotnetcore-testapp/web`

And finally release the new build
`heroku container:release web -a dotnetcore-testapp`