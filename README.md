# burogusaito
markdown blogsite

<br>

> requirements: linux (debian/ubuntu and alpine tested) on x86_64

## Install JUST-JS

```bash
# download and run the build script
sh -c "$(curl -sSL https://raw.githubusercontent.com/just-js/just/current/install.sh)"
# install just binary to /usr/local/bin
make -C just install
# export the just home directory
export JUST_HOME=$(pwd)/just
export JUST_TARGET=$JUST_HOME
# if you don't want to install, add JUST_HOME to SPATH
export PATH=$PATH:$JUST_HOME
# run a shell
just
```

## Build and run

```bash
# initialise a new application in the hello directory
cd burogusaito
# build hello app
just build ./src/app.js --clean --static
./app
```