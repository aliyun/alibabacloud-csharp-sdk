// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceClassRequest : TeaModel {
        /// <summary>
        /// <para>The autoscaling configuration for the compute group.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AutoScaleConfig")]
        [Validation(Required=false)]
        public ModifyDBInstanceClassRequestAutoScaleConfig AutoScaleConfig { get; set; }
        public class ModifyDBInstanceClassRequestAutoScaleConfig : TeaModel {
            /// <summary>
            /// <para>The number of burstable nodes for autoscaling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("BurstNum")]
            [Validation(Required=false)]
            public int? BurstNum { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable or disable autoscaling. Valid values: <c>enable</c> and <c>disable</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Information about the VSwitches.</para>
            /// </summary>
            [NameInMap("VSwitchInfos")]
            [Validation(Required=false)]
            public List<ModifyDBInstanceClassRequestAutoScaleConfigVSwitchInfos> VSwitchInfos { get; set; }
            public class ModifyDBInstanceClassRequestAutoScaleConfigVSwitchInfos : TeaModel {
                /// <summary>
                /// <para>The VSwitch IDs.</para>
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public List<string> VSwitchIds { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-XXX</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The compute group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-gs5j3sua77*******-clickhouse</para>
        /// </summary>
        [NameInMap("ComputingGroupId")]
        [Validation(Required=false)]
        public string ComputingGroupId { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc-gs5j3sua77*******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The number of nodes. Valid values: 2 to 16.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// <para>The maximum capacity per node for serverless autoscaling. Valid values: 4 to 32. This value must be greater than the minimum value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("NodeScaleMax")]
        [Validation(Required=false)]
        public int? NodeScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum capacity per node for serverless autoscaling. Valid values: 4 to 32.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("NodeScaleMin")]
        [Validation(Required=false)]
        public int? NodeScaleMin { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The maximum capacity for serverless autoscaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public long? ScaleMax { get; set; }

        /// <summary>
        /// <para>The minimum capacity for serverless autoscaling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public long? ScaleMin { get; set; }

        /// <summary>
        /// <para>The pre-purchased storage capacity in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("StorageQuota")]
        [Validation(Required=false)]
        public long? StorageQuota { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

    }

}
