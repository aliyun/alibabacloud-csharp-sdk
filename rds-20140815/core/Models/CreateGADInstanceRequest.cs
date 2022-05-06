// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceRequest : TeaModel {
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        [NameInMap("CentralRdsDtsAdminAccount")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminAccount { get; set; }

        [NameInMap("CentralRdsDtsAdminPassword")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminPassword { get; set; }

        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("UnitNode")]
        [Validation(Required=false)]
        public List<CreateGADInstanceRequestUnitNode> UnitNode { get; set; }
        public class CreateGADInstanceRequestUnitNode : TeaModel {
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public long? DBInstanceStorage { get; set; }

            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            [NameInMap("DtsConflict")]
            [Validation(Required=false)]
            public string DtsConflict { get; set; }

            [NameInMap("DtsInstanceClass")]
            [Validation(Required=false)]
            public string DtsInstanceClass { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

            [NameInMap("VSwitchID")]
            [Validation(Required=false)]
            public string VSwitchID { get; set; }

            [NameInMap("VpcID")]
            [Validation(Required=false)]
            public string VpcID { get; set; }

            [NameInMap("ZoneID")]
            [Validation(Required=false)]
            public string ZoneID { get; set; }

            [NameInMap("ZoneIDSlave1")]
            [Validation(Required=false)]
            public string ZoneIDSlave1 { get; set; }

            [NameInMap("ZoneIDSlave2")]
            [Validation(Required=false)]
            public string ZoneIDSlave2 { get; set; }

        }

    }

}
