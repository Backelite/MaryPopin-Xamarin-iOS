COMMON_PARAMS=-project MaryPopin.xcodeproj -scheme MaryPopin -configuration Release -derivedDataPath ./build
X86_LIB=build/Build/Products/Release-iphonesimulator/libMaryPopin.a
ARM_LIB=build/Build/Products/Release-iphoneos/libMaryPopin.a

x86:
	xcodebuild $(COMMON_PARAMS) ONLY_ACTIVE_ARCH=NO -sdk iphonesimulator clean build

arm:
	xcodebuild $(COMMON_PARAMS) ONLY_ACTIVE_ARCH=NO -sdk iphoneos clean build
	
all: x86 arm
	libtool -static $(X86_LIB) $(ARM_LIB) -o ./build/libMaryPopin.a

clean:
	rm -rf build
	