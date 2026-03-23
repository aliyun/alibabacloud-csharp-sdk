// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateGADInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CentralDBInstanceId")]
        [Validation(Required=false)]
        public string CentralDBInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CentralRdsDtsAdminAccount")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminAccount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CentralRdsDtsAdminPassword")]
        [Validation(Required=false)]
        public string CentralRdsDtsAdminPassword { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CentralRegionId")]
        [Validation(Required=false)]
        public string CentralRegionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBList")]
        [Validation(Required=false)]
        public string DBList { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateGADInstanceRequestTag> Tag { get; set; }
        public class CreateGADInstanceRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
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

            [NameInMap("DBInstanceStorageType")]
            [Validation(Required=false)]
            public string DBInstanceStorageType { get; set; }

            [NameInMap("DbInstanceClass")]
            [Validation(Required=false)]
            public string DbInstanceClass { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DtsConflict")]
            [Validation(Required=false)]
            public string DtsConflict { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
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
