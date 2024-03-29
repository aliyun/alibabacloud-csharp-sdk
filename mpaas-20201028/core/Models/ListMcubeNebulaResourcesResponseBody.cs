// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMcubeNebulaResourcesResponseBody : TeaModel {
        [NameInMap("ListMcubeNebulaResourceResult")]
        [Validation(Required=false)]
        public ListMcubeNebulaResourcesResponseBodyListMcubeNebulaResourceResult ListMcubeNebulaResourceResult { get; set; }
        public class ListMcubeNebulaResourcesResponseBodyListMcubeNebulaResourceResult : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("NebulaResourceInfo")]
            [Validation(Required=false)]
            public List<ListMcubeNebulaResourcesResponseBodyListMcubeNebulaResourceResultNebulaResourceInfo> NebulaResourceInfo { get; set; }
            public class ListMcubeNebulaResourcesResponseBodyListMcubeNebulaResourceResultNebulaResourceInfo : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("AutoInstall")]
                [Validation(Required=false)]
                public int? AutoInstall { get; set; }

                [NameInMap("ClientVersionMax")]
                [Validation(Required=false)]
                public string ClientVersionMax { get; set; }

                [NameInMap("ClientVersionMin")]
                [Validation(Required=false)]
                public string ClientVersionMin { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("DebugUrl")]
                [Validation(Required=false)]
                public string DebugUrl { get; set; }

                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                [NameInMap("ExtendInfo")]
                [Validation(Required=false)]
                public string ExtendInfo { get; set; }

                [NameInMap("ExtraData")]
                [Validation(Required=false)]
                public string ExtraData { get; set; }

                [NameInMap("FallbackBaseUrl")]
                [Validation(Required=false)]
                public string FallbackBaseUrl { get; set; }

                [NameInMap("FileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("H5Id")]
                [Validation(Required=false)]
                public string H5Id { get; set; }

                [NameInMap("H5Name")]
                [Validation(Required=false)]
                public string H5Name { get; set; }

                [NameInMap("H5Version")]
                [Validation(Required=false)]
                public string H5Version { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("InstallType")]
                [Validation(Required=false)]
                public int? InstallType { get; set; }

                [NameInMap("LazyLoad")]
                [Validation(Required=false)]
                public int? LazyLoad { get; set; }

                [NameInMap("MainUrl")]
                [Validation(Required=false)]
                public string MainUrl { get; set; }

                [NameInMap("Md5")]
                [Validation(Required=false)]
                public string Md5 { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("MetaId")]
                [Validation(Required=false)]
                public long? MetaId { get; set; }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public int? PackageType { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("PublishPeriod")]
                [Validation(Required=false)]
                public int? PublishPeriod { get; set; }

                [NameInMap("ReleaseVersion")]
                [Validation(Required=false)]
                public string ReleaseVersion { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("Vhost")]
                [Validation(Required=false)]
                public string Vhost { get; set; }

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
