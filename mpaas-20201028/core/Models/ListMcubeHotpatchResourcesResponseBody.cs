// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMcubeHotpatchResourcesResponseBody : TeaModel {
        [NameInMap("ListHotpatchResourceResult")]
        [Validation(Required=false)]
        public ListMcubeHotpatchResourcesResponseBodyListHotpatchResourceResult ListHotpatchResourceResult { get; set; }
        public class ListMcubeHotpatchResourcesResponseBodyListHotpatchResourceResult : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("HotpatchResourceInfo")]
            [Validation(Required=false)]
            public List<ListMcubeHotpatchResourcesResponseBodyListHotpatchResourceResultHotpatchResourceInfo> HotpatchResourceInfo { get; set; }
            public class ListMcubeHotpatchResourcesResponseBodyListHotpatchResourceResultHotpatchResourceInfo : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("HotpatchVersion")]
                [Validation(Required=false)]
                public string HotpatchVersion { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("PackageId")]
                [Validation(Required=false)]
                public long? PackageId { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("ProductId")]
                [Validation(Required=false)]
                public string ProductId { get; set; }

                [NameInMap("ProductVersion")]
                [Validation(Required=false)]
                public string ProductVersion { get; set; }

                [NameInMap("PublishPeriod")]
                [Validation(Required=false)]
                public long? PublishPeriod { get; set; }

                [NameInMap("ReleaseVersion")]
                [Validation(Required=false)]
                public string ReleaseVersion { get; set; }

                [NameInMap("SourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
