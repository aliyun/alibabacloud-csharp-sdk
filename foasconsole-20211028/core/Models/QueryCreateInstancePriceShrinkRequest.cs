// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class QueryCreateInstancePriceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The processor architecture.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X86</para>
        /// </summary>
        [NameInMap("ArchitectureType")]
        [Validation(Required=false)]
        public string ArchitectureType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: does not enable auto-renewal. (Default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is invalid for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The billing type. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRE</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The number of billing cycles.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The extended reserved field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>“”</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <para>Specifies whether to select zone-disaster recovery resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ha")]
        [Validation(Required=false)]
        public bool? Ha { get; set; }

        /// <summary>
        /// <para>The zone-disaster recovery resource specifications.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("HaResourceSpec")]
        [Validation(Required=false)]
        public string HaResourceSpecShrink { get; set; }

        /// <summary>
        /// <para>The workspace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtc-e2e-test-post</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The billing cycle. Subscription instances support only Year and Month. Pay-as-you-go instances support Hour.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500041860100636</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource specifications.</para>
        /// </summary>
        [NameInMap("ResourceSpec")]
        [Validation(Required=false)]
        public string ResourceSpecShrink { get; set; }

        /// <summary>
        /// <para>The storage information.</para>
        /// </summary>
        [NameInMap("Storage")]
        [Validation(Required=false)]
        public string StorageShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UsePromotionCode")]
        [Validation(Required=false)]
        public bool? UsePromotionCode { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs.</para>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIdsShrink { get; set; }

        /// <summary>
        /// <para>The VPC ID of the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze9xoh8qyt1rnxfmfcdi</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
