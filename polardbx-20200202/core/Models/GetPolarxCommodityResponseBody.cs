// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class GetPolarxCommodityResponseBody : TeaModel {
        [NameInMap("ComponentList")]
        [Validation(Required=false)]
        public List<GetPolarxCommodityResponseBodyComponentList> ComponentList { get; set; }
        public class GetPolarxCommodityResponseBodyComponentList : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("DBInstance")]
        [Validation(Required=false)]
        public GetPolarxCommodityResponseBodyDBInstance DBInstance { get; set; }
        public class GetPolarxCommodityResponseBodyDBInstance : TeaModel {
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }
            [NameInMap("ConnAddrs")]
            [Validation(Required=false)]
            public List<GetPolarxCommodityResponseBodyDBInstanceConnAddrs> ConnAddrs { get; set; }
            public class GetPolarxCommodityResponseBodyDBInstanceConnAddrs : TeaModel {
                public string ConnectionString { get; set; }
                public string Port { get; set; }
                public string Type { get; set; }
                public string VPCId { get; set; }
                public string VSwitchId { get; set; }
            }
            [NameInMap("ConnectionString")]
            [Validation(Required=false)]
            public string ConnectionString { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("DBInstanceType")]
            [Validation(Required=false)]
            public string DBInstanceType { get; set; }
            [NameInMap("DBNodeClass")]
            [Validation(Required=false)]
            public string DBNodeClass { get; set; }
            [NameInMap("DBNodeCount")]
            [Validation(Required=false)]
            public int? DBNodeCount { get; set; }
            [NameInMap("DBNodes")]
            [Validation(Required=false)]
            public List<GetPolarxCommodityResponseBodyDBInstanceDBNodes> DBNodes { get; set; }
            public class GetPolarxCommodityResponseBodyDBInstanceDBNodes : TeaModel {
                public string Id { get; set; }
                public string NodeClass { get; set; }
                public string RegionId { get; set; }
                public string ZoneId { get; set; }
            }
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }
            [NameInMap("ExpireDate")]
            [Validation(Required=false)]
            public string ExpireDate { get; set; }
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("LatestMinorVersion")]
            [Validation(Required=false)]
            public string LatestMinorVersion { get; set; }
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }
            [NameInMap("MaintainEndTime")]
            [Validation(Required=false)]
            public string MaintainEndTime { get; set; }
            [NameInMap("MaintainStartTime")]
            [Validation(Required=false)]
            public string MaintainStartTime { get; set; }
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("ReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ReadDBInstances { get; set; }
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
