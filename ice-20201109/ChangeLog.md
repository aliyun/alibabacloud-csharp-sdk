2022-08-29 Version: 1.3.1
- Change RegisterMediaInfo.

2022-07-20 Version: 1.3.0
- Ass new api called SubmitMediaInfoJob, which submit mediaInfo job.
- Ass new api called SubmitMediaCensorJob, which submit mediaCensor job.
- Ass new api called SubmitIProductionJob, which submit iProduction job.
- Ass new api called SubmitTranscodeJob, which submit transcode job.
- Ass new api called SubmitDynamicImageJob, which submit dynamicImage job.
- Ass new api called SubmitSnapshotJob, which submit snapshot job.

2022-06-08 Version: 1.2.0
- Add page params in ListTemplates API.

2021-12-23 Version: 1.1.6
- Add a new API called SubmitDynamicChartJob, which produce chart video throuth xlsx file.

2021-11-26 Version: 1.1.5
- Add a new API called GetPublicMediaInfo, which gets information of copyrighted public media.
- Add a new API called DescribeMaterialPackageInfo, which describes the available material packages.
- Add a new API called AddFavoritePublicMedia, which adds public media to favorite for the user.
- Add a new API called CancelFavoritePublicMedia, which removes public media from user favorite.
- Add a new API called SearchPublicMediaInfo, which searches copyrighted public media.
- Update the return value of an existed API called ListAllPublicMediaTags, adding field Options.
- Update the return value of an existed API called GetMediaInfo, adding field DynamicMetaData.
- Modify the data type of the return value of an existed API called GetEditingProjectMaterials, where ProjectMaterials should be a list instead of a string.
- Modify the data type of the return value of an existed API called AddEditingProjectMaterials, where ProjectMaterials should be a list instead of a string.
- Update the input params of an existing API called SubmitMediaProducingJob, adding field EditingProduceConfig.

2021-11-16 Version: 1.1.4
- Add a new API called BatchGetMediaInfos, which get multi media infos through mediaids.
- Add a new API called GetTemplateMaterials, which get material urls of VeTemplates.

2021-11-04 Version: 1.1.3
- Add relatedMediaIds param in GetTemplate API.

2021-09-10 Version: 1.1.2
- Add post method to Template API.

2021-08-12 Version: 1.1.1
- Fix GetSmartHandleJob type conversion error.

2021-08-10 Version: 1.1.0
- Add template clipsParam param.

