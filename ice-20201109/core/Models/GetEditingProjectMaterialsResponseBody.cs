// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEditingProjectMaterialsResponseBody : TeaModel {
        [NameInMap("LiveMaterials")]
        [Validation(Required=false)]
        public List<GetEditingProjectMaterialsResponseBodyLiveMaterials> LiveMaterials { get; set; }
        public class GetEditingProjectMaterialsResponseBodyLiveMaterials : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        /// <summary>
        /// 符合要求的媒资集合
        /// </summary>
        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<GetEditingProjectMaterialsResponseBodyMediaInfos> MediaInfos { get; set; }
        public class GetEditingProjectMaterialsResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// FileInfos
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoList : TeaModel {
                /// <summary>
                /// 文件基础信息，包含时长，大小等
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }
                };

            }

            /// <summary>
            /// BasicInfo
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetEditingProjectMaterialsResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMediaInfosMediaBasicInfo : TeaModel {
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }
                [NameInMap("TranscodeStatus")]
                [Validation(Required=false)]
                public string TranscodeStatus { get; set; }
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }
            };

            /// <summary>
            /// 媒资ID
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ProjectMaterials")]
        [Validation(Required=false)]
        public string ProjectMaterials { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
