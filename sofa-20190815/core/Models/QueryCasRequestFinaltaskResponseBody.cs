// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasRequestFinaltaskResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasRequestFinaltaskResponseBodyData> Data { get; set; }
        public class QueryCasRequestFinaltaskResponseBodyData : TeaModel {
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            [NameInMap("ExecutionTimes")]
            [Validation(Required=false)]
            public long? ExecutionTimes { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("Request")]
            [Validation(Required=false)]
            public QueryCasRequestFinaltaskResponseBodyDataRequest Request { get; set; }
            public class QueryCasRequestFinaltaskResponseBodyDataRequest : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Token")]
                [Validation(Required=false)]
                public string Token { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

            [NameInMap("Resource")]
            [Validation(Required=false)]
            public QueryCasRequestFinaltaskResponseBodyDataResource Resource { get; set; }
            public class QueryCasRequestFinaltaskResponseBodyDataResource : TeaModel {
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }
                [NameInMap("AutoRenewPeriod")]
                [Validation(Required=false)]
                public long? AutoRenewPeriod { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }
                [NameInMap("IaasId")]
                [Validation(Required=false)]
                public string IaasId { get; set; }
                [NameInMap("IaasType")]
                [Validation(Required=false)]
                public string IaasType { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }
                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }
            };

        }

    }

}
