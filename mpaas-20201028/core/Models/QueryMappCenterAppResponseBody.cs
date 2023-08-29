// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryMappCenterAppResponseBody : TeaModel {
        [NameInMap("QueryMappCenterAppResult")]
        [Validation(Required=false)]
        public QueryMappCenterAppResponseBodyQueryMappCenterAppResult QueryMappCenterAppResult { get; set; }
        public class QueryMappCenterAppResponseBodyQueryMappCenterAppResult : TeaModel {
            [NameInMap("MappCenterApp")]
            [Validation(Required=false)]
            public QueryMappCenterAppResponseBodyQueryMappCenterAppResultMappCenterApp MappCenterApp { get; set; }
            public class QueryMappCenterAppResponseBodyQueryMappCenterAppResultMappCenterApp : TeaModel {
                [NameInMap("AndroidConfig")]
                [Validation(Required=false)]
                public QueryMappCenterAppResponseBodyQueryMappCenterAppResultMappCenterAppAndroidConfig AndroidConfig { get; set; }
                public class QueryMappCenterAppResponseBodyQueryMappCenterAppResultMappCenterAppAndroidConfig : TeaModel {
                    [NameInMap("CertRSA")]
                    [Validation(Required=false)]
                    public string CertRSA { get; set; }

                    [NameInMap("PackageName")]
                    [Validation(Required=false)]
                    public string PackageName { get; set; }

                }

                [NameInMap("AppDesc")]
                [Validation(Required=false)]
                public string AppDesc { get; set; }

                [NameInMap("AppIcon")]
                [Validation(Required=false)]
                public string AppIcon { get; set; }

                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppSecret")]
                [Validation(Required=false)]
                public string AppSecret { get; set; }

                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IosConfig")]
                [Validation(Required=false)]
                public QueryMappCenterAppResponseBodyQueryMappCenterAppResultMappCenterAppIosConfig IosConfig { get; set; }
                public class QueryMappCenterAppResponseBodyQueryMappCenterAppResultMappCenterAppIosConfig : TeaModel {
                    [NameInMap("BundleId")]
                    [Validation(Required=false)]
                    public string BundleId { get; set; }

                }

                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                [NameInMap("MonitorJson")]
                [Validation(Required=false)]
                public string MonitorJson { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

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
