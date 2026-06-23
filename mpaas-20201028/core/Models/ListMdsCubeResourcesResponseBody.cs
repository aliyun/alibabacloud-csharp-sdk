// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMdsCubeResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListMdsCubeResourcesResponseBodyResultContent ResultContent { get; set; }
        public class ListMdsCubeResourcesResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListMdsCubeResourcesResponseBodyResultContentData Data { get; set; }
            public class ListMdsCubeResourcesResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public ListMdsCubeResourcesResponseBodyResultContentDataContent Content { get; set; }
                public class ListMdsCubeResourcesResponseBodyResultContentDataContent : TeaModel {
                    [NameInMap("CurrentMaxAndroidVersion")]
                    [Validation(Required=false)]
                    public string CurrentMaxAndroidVersion { get; set; }

                    [NameInMap("CurrentMaxIosVersion")]
                    [Validation(Required=false)]
                    public string CurrentMaxIosVersion { get; set; }

                    [NameInMap("FirstPage")]
                    [Validation(Required=false)]
                    public bool? FirstPage { get; set; }

                    [NameInMap("FirstResult")]
                    [Validation(Required=false)]
                    public long? FirstResult { get; set; }

                    [NameInMap("LastPage")]
                    [Validation(Required=false)]
                    public bool? LastPage { get; set; }

                    [NameInMap("List")]
                    [Validation(Required=false)]
                    public List<ListMdsCubeResourcesResponseBodyResultContentDataContentList> List { get; set; }
                    public class ListMdsCubeResourcesResponseBodyResultContentDataContentList : TeaModel {
                        [NameInMap("AndroidMaxVersion")]
                        [Validation(Required=false)]
                        public string AndroidMaxVersion { get; set; }

                        [NameInMap("AndroidMinVersion")]
                        [Validation(Required=false)]
                        public string AndroidMinVersion { get; set; }

                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        [NameInMap("BinFileMd5")]
                        [Validation(Required=false)]
                        public string BinFileMd5 { get; set; }

                        [NameInMap("BinPrivateFileUrl")]
                        [Validation(Required=false)]
                        public string BinPrivateFileUrl { get; set; }

                        [NameInMap("BinPublicFileUrl")]
                        [Validation(Required=false)]
                        public string BinPublicFileUrl { get; set; }

                        [NameInMap("ExtendInfo")]
                        [Validation(Required=false)]
                        public string ExtendInfo { get; set; }

                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("IosMaxVersion")]
                        [Validation(Required=false)]
                        public string IosMaxVersion { get; set; }

                        [NameInMap("IosMinVersion")]
                        [Validation(Required=false)]
                        public string IosMinVersion { get; set; }

                        [NameInMap("JsonPrivateFileUrl")]
                        [Validation(Required=false)]
                        public string JsonPrivateFileUrl { get; set; }

                        [NameInMap("JsonPublicFileUrl")]
                        [Validation(Required=false)]
                        public string JsonPublicFileUrl { get; set; }

                        [NameInMap("MinCubeSdkVersion")]
                        [Validation(Required=false)]
                        public string MinCubeSdkVersion { get; set; }

                        [NameInMap("MockDataDownloadUrl")]
                        [Validation(Required=false)]
                        public string MockDataDownloadUrl { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("Platform")]
                        [Validation(Required=false)]
                        public string Platform { get; set; }

                        [NameInMap("PreviewPictureUrl")]
                        [Validation(Required=false)]
                        public string PreviewPictureUrl { get; set; }

                        [NameInMap("ResourceStatus")]
                        [Validation(Required=false)]
                        public long? ResourceStatus { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        [NameInMap("TemplateResourceDesc")]
                        [Validation(Required=false)]
                        public string TemplateResourceDesc { get; set; }

                        [NameInMap("TemplateResourceVersion")]
                        [Validation(Required=false)]
                        public string TemplateResourceVersion { get; set; }

                    }

                    [NameInMap("NextPage")]
                    [Validation(Required=false)]
                    public long? NextPage { get; set; }

                    [NameInMap("PageNo")]
                    [Validation(Required=false)]
                    public int? PageNo { get; set; }

                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    [NameInMap("PrePage")]
                    [Validation(Required=false)]
                    public long? PrePage { get; set; }

                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
