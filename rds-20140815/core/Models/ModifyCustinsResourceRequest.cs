// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyCustinsResourceRequest : TeaModel {
        /// <summary>
        /// <para>The adjustment time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-31 23:59:06</para>
        /// </summary>
        [NameInMap("AdjustDeadline")]
        [Validation(Required=false)]
        public string AdjustDeadline { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/610396.html">DescribeDBInstances</a> to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-j5ekvfeengm******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The increase ratio. Unit: %.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IncreaseRatio")]
        [Validation(Required=false)]
        public string IncreaseRatio { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Memory</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The original value. This parameter is required when <b>ResourceType</b> is set to <b>instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("RestoreOriginalSpecification")]
        [Validation(Required=false)]
        public string RestoreOriginalSpecification { get; set; }

        /// <summary>
        /// <para>The target value. This parameter is applicable to target tracking rules and predictive rules. The value of TargetValue can contain up to three decimal places and must be greater than 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("TargetValue")]
        [Validation(Required=false)]
        public int? TargetValue { get; set; }

    }

}
