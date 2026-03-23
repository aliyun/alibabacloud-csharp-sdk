// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDBProxyInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBProxyInstanceNum")]
        [Validation(Required=false)]
        public string DBProxyInstanceNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DBProxyInstanceType")]
        [Validation(Required=false)]
        public string DBProxyInstanceType { get; set; }

        [NameInMap("DBProxyNodes")]
        [Validation(Required=false)]
        public List<ModifyDBProxyInstanceRequestDBProxyNodes> DBProxyNodes { get; set; }
        public class ModifyDBProxyInstanceRequestDBProxyNodes : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("cpuCores")]
            [Validation(Required=false)]
            public string CpuCores { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("nodeCounts")]
            [Validation(Required=false)]
            public string NodeCounts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hagnzhou-c</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("EffectiveSpecificTime")]
        [Validation(Required=false)]
        public string EffectiveSpecificTime { get; set; }

        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        [NameInMap("MigrateAZ")]
        [Validation(Required=false)]
        public List<ModifyDBProxyInstanceRequestMigrateAZ> MigrateAZ { get; set; }
        public class ModifyDBProxyInstanceRequestMigrateAZ : TeaModel {
            [NameInMap("dbProxyEndpointId")]
            [Validation(Required=false)]
            public string DbProxyEndpointId { get; set; }

            [NameInMap("destVSwitchId")]
            [Validation(Required=false)]
            public string DestVSwitchId { get; set; }

            [NameInMap("destVpcId")]
            [Validation(Required=false)]
            public string DestVpcId { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

    }

}
