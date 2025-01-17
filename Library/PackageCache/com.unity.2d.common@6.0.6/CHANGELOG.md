# Changelog

## [6.0.6] - 2022-10-25
### Changed
- Refactored the internal triangulation and tessellation APIs.

## [6.0.5] - 2022-09-07
### Changed
- Added support for different sized texture inputs in ImagePacker. 

## [6.0.4] - 2022-06-28
### Changed
- Refactored internal triangulation and tessellation APIs.

## [6.0.3] - 2022-02-07
### Fixed
- Collinear vertices can be now safely deleted from the sprite mesh in Skinning Editor. (case 1383248)
- Optimized texture space needed for rect packing

## [6.0.2] - 2021-11-24
### Added
- Added internal method to get build target's group name.
- Added access to the internal helper method IsUsingDeformableBuffer.

## [6.0.1] - 2021-11-05
### Fixed
- Fixed issues in tesselation library.

## [6.0.0] - 2021-08-10
### Changed
- Update to release version

## [6.0.0-pre.4] - 2021-07-05
### Added
- Internal API for applying Sprite Editor Window changes

## [6.0.0-pre.3] - 2021-05-19
### Fixed
- Fixed issues in tesselation library.

## [6.0.0-pre.2] - 2021-05-14
### Fixed
- Fixed metafiles conflicts

## [6.0.0-pre.1] - 2021-05-05
### Changed
- Version bump for Unity 2021.2

## [5.0.0] - 2021-03-17
### Changed
- Update version for release

## [5.0.0-pre.2] - 2021-01-16
### Changed
- Update license file

## [5.0.0-pre.1] - 2020-10-30
### Changed
- Version bump for Unity 2021.1

## [4.0.3] - 2020-10-15
### Fixed
- Allow 2D Packages to access internal constant value for asset creation instance id

## [4.0.2] - 2020-08-31
### Fixed
- Allow launching Sprite Editor Window to target a specific asset

## [4.0.1] - 2020-07-07
### Fixed
- Updated to use non-experimental AssetImporter namespace (case 1254381)

## [4.0.0] - 2020-05-11
### Changed
- Version bump for Unity 2020.2

## [3.0.0] - 2019-11-06
### Changed
- Update version number for Unity 2020.1

## [2.0.2] - 2019-08-09
### Added
- Add Seconday Texture settings into TextureSettings for TextureGenerator
- Add related test packages

## [2.0.1] - 2019-07-13
### Changed
- Mark package to support Unity 2019.3.0a10 onwards.

## [2.0.0] - 2019-06-17
### Added
- Drop preview tag.
- Remove experimental namespace

## [1.2.0-preview.2] - 2019-06-04
### Added
- Remove Image Packer Debug Window
- Move tests out of package

## [1.2.0-preview.1] - 2019-02-20
### Added
- Update for Unity 2019.2 support.

## [1.1.0-preview.2] - 2019-03-18
### Added
- Remove deprecated call to Unity internal API

## [1.1.0-preview.1] - 2019-01-25
### Added
- Added versioning for CI.