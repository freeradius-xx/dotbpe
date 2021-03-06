set -ex

cd $(dirname $0)/../../src/

artifactsFolder="../artifacts"

if [ -d $artifactsFolder ]; then
  rm -R $artifactsFolder
fi

mkdir -p $artifactsFolder


versionNumber="1.2.1"

dotnet pack ./core/DotBPE.Utils/DotBPE.Utils.csproj -c Release -o ../../$artifactsFolder --version-suffix=$versionNumber



