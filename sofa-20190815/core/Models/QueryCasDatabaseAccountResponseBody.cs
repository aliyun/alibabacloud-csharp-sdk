// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryCasDatabaseAccountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCasDatabaseAccountResponseBodyData> Data { get; set; }
        public class QueryCasDatabaseAccountResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            [NameInMap("Privilege")]
            [Validation(Required=false)]
            public string Privilege { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("Database")]
            [Validation(Required=false)]
            public QueryCasDatabaseAccountResponseBodyDataDatabase Database { get; set; }
            public class QueryCasDatabaseAccountResponseBodyDataDatabase : TeaModel {
                [NameInMap("AutoRenew")]
                [Validation(Required=false)]
                public bool? AutoRenew { get; set; }
                [NameInMap("AutoRenewPeriod")]
                [Validation(Required=false)]
                public long? AutoRenewPeriod { get; set; }
                [NameInMap("ConnectionAddress")]
                [Validation(Required=false)]
                public string ConnectionAddress { get; set; }
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }
                [NameInMap("IaasId")]
                [Validation(Required=false)]
                public string IaasId { get; set; }
                [NameInMap("IaasType")]
                [Validation(Required=false)]
                public string IaasType { get; set; }
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }
                [NameInMap("MasterZoneId")]
                [Validation(Required=false)]
                public string MasterZoneId { get; set; }
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public long? MaxConnections { get; set; }
                [NameInMap("MaxIops")]
                [Validation(Required=false)]
                public long? MaxIops { get; set; }
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public long? Memory { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }
                [NameInMap("NetType")]
                [Validation(Required=false)]
                public string NetType { get; set; }
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }
                [NameInMap("SpecIaasId")]
                [Validation(Required=false)]
                public string SpecIaasId { get; set; }
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }
                [NameInMap("Storage")]
                [Validation(Required=false)]
                public long? Storage { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }
                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }
                [NameInMap("VSwitchIaasId")]
                [Validation(Required=false)]
                public string VSwitchIaasId { get; set; }
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }
                [NameInMap("AppIds")]
                [Validation(Required=false)]
                public List<string> AppIds { get; set; }
                [NameInMap("AppServiceIds")]
                [Validation(Required=false)]
                public List<string> AppServiceIds { get; set; }
                [NameInMap("AssignedAppServiceIds")]
                [Validation(Required=false)]
                public List<string> AssignedAppServiceIds { get; set; }
                [NameInMap("SharedWorkspaceIds")]
                [Validation(Required=false)]
                public List<string> SharedWorkspaceIds { get; set; }
                [NameInMap("AssignedApps")]
                [Validation(Required=false)]
                public List<QueryCasDatabaseAccountResponseBodyDataDatabaseAssignedApps> AssignedApps { get; set; }
                public class QueryCasDatabaseAccountResponseBodyDataDatabaseAssignedApps : TeaModel {
                    public string AppId { get; set; }
                    public string WorkspaceId { get; set; }
                }
            };

        }

    }

}
