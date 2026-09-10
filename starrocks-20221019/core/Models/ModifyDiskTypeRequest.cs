// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyDiskTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically purchase (pay for) all products specified in the Products parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatic payment is enabled.</description></item>
        /// <item><description>false: Automatic payment is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The compute group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-3d5ce6454354****</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>The coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>youhuiquan_promotion_option_id_for_blank</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The target disk type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>essd</para>
        /// </summary>
        [NameInMap("TargetDiskType")]
        [Validation(Required=false)]
        public string TargetDiskType { get; set; }

        /// <summary>
        /// <para>The target disk performance level.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pl2</para>
        /// </summary>
        [NameInMap("TargetPerformanceLevel")]
        [Validation(Required=false)]
        public string TargetPerformanceLevel { get; set; }

    }

}
