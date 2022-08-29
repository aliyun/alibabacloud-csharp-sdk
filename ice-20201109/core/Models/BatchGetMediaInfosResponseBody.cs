// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetMediaInfosResponseBody : TeaModel {
        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<BatchGetMediaInfosResponseBodyMediaInfos> MediaInfos { get; set; }
        public class BatchGetMediaInfosResponseBodyMediaInfos : TeaModel {
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<BatchGetMediaInfosResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosFileInfoList : TeaModel {
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public BatchGetMediaInfosResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class BatchGetMediaInfosResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
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

            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public BatchGetMediaInfosResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosMediaBasicInfo : TeaModel {
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

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
