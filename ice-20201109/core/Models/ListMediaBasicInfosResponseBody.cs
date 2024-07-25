// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaBasicInfosResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<ListMediaBasicInfosResponseBodyMediaInfos> MediaInfos { get; set; }
        public class ListMediaBasicInfosResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// FileInfos
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<ListMediaBasicInfosResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class ListMediaBasicInfosResponseBodyMediaInfosFileInfoList : TeaModel {
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public ListMediaBasicInfosResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class ListMediaBasicInfosResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

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

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// BasicInfo
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public ListMediaBasicInfosResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class ListMediaBasicInfosResponseBodyMediaInfosMediaBasicInfo : TeaModel {
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

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

                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

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

                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
