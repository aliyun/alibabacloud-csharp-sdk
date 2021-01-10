// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasLoadbalanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasLoadbalanceResponseBodyData> Data { get; set; }
        public class QueryCasLoadbalanceResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AutoRenew")]
            [Validation(Required=false)]
            public bool? AutoRenew { get; set; }

            [NameInMap("AutoRenewPeriod")]
            [Validation(Required=false)]
            public long? AutoRenewPeriod { get; set; }

            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public long? Bandwidth { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("ClusterMode")]
            [Validation(Required=false)]
            public bool? ClusterMode { get; set; }

            [NameInMap("IaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InternetChargeType")]
            [Validation(Required=false)]
            public string InternetChargeType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            [NameInMap("ShareMode")]
            [Validation(Required=false)]
            public bool? ShareMode { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("VipAddressType")]
            [Validation(Required=false)]
            public string VipAddressType { get; set; }

            [NameInMap("VipType")]
            [Validation(Required=false)]
            public string VipType { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VswitchIaasId")]
            [Validation(Required=false)]
            public string VswitchIaasId { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("AppServiceIds")]
            [Validation(Required=false)]
            public List<string> AppServiceIds { get; set; }

            [NameInMap("AssignedAppIds")]
            [Validation(Required=false)]
            public List<string> AssignedAppIds { get; set; }

            [NameInMap("AssignedAppServiceIds")]
            [Validation(Required=false)]
            public List<string> AssignedAppServiceIds { get; set; }

            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            [NameInMap("VipAddresses")]
            [Validation(Required=false)]
            public List<string> VipAddresses { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public QueryCasLoadbalanceResponseBodyDataScope Scope { get; set; }
            public class QueryCasLoadbalanceResponseBodyDataScope : TeaModel {
                [NameInMap("Cell")]
                [Validation(Required=false)]
                public string Cell { get; set; }
                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }
                [NameInMap("Tenant")]
                [Validation(Required=false)]
                public string Tenant { get; set; }
                [NameInMap("Workspace")]
                [Validation(Required=false)]
                public string Workspace { get; set; }
                [NameInMap("WorkspaceGroup")]
                [Validation(Required=false)]
                public string WorkspaceGroup { get; set; }
                [NameInMap("Zone")]
                [Validation(Required=false)]
                public string Zone { get; set; }
            };

        }

    }

}
