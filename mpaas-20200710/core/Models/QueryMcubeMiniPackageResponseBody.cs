// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class QueryMcubeMiniPackageResponseBody : TeaModel {
        [NameInMap("QueryMiniPackageResult")]
        [Validation(Required=false)]
        public QueryMcubeMiniPackageResponseBodyQueryMiniPackageResult QueryMiniPackageResult { get; set; }
        public class QueryMcubeMiniPackageResponseBodyQueryMiniPackageResult : TeaModel {
            [NameInMap("MiniPackageInfo")]
            [Validation(Required=false)]
            public QueryMcubeMiniPackageResponseBodyQueryMiniPackageResultMiniPackageInfo MiniPackageInfo { get; set; }
            public class QueryMcubeMiniPackageResponseBodyQueryMiniPackageResultMiniPackageInfo : TeaModel {
                [NameInMap("AppCode")]
                [Validation(Required=false)]
                public string AppCode { get; set; }

                [NameInMap("AutoInstall")]
                [Validation(Required=false)]
                public long? AutoInstall { get; set; }

                [NameInMap("ClientVersionMax")]
                [Validation(Required=false)]
                public string ClientVersionMax { get; set; }

                [NameInMap("ClientVersionMin")]
                [Validation(Required=false)]
                public string ClientVersionMin { get; set; }

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
                public long? InstallType { get; set; }

                [NameInMap("MainUrl")]
                [Validation(Required=false)]
                public string MainUrl { get; set; }

                [NameInMap("Memo")]
                [Validation(Required=false)]
                public string Memo { get; set; }

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public long? PackageType { get; set; }

                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                [NameInMap("PublishPeriod")]
                [Validation(Required=false)]
                public long? PublishPeriod { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public long? ResourceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

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

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
