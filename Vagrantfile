
Vagrant.configure("2") do |config|
  config.vm.box = "hashicorp/bionic64"
  config.vm.network "forwarded_port", guest: 8000, host: 8000

  config.vm.provision "file", source: "restApi", destination: "restApi"
  config.vm.provision "file", source: "restApi/restApi/restApi/.env", destination: "restApi/restApi/restApi/.env"
  config.vm.provision "file", source: "restApi/restApi/docker-compose.yml", destination: "restApi/restApi/docker-compose.yml"
  config.vm.provision :shell, path: "script.sh"
end
