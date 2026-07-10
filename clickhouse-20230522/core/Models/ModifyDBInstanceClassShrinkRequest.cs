// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyDBInstanceClassShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The autoscaling configuration for the compute group.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AutoScaleConfig")]
        [Validation(Required=false)]
        public string AutoScaleConfigShrink { get; set; }

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
