// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class CreateAgentResourceRequest : TeaModel {
        /// <summary>
        /// <para>Enable auto-renewal. This parameter is valid only when payType is set to PrePaid. Auto-renewal is disabled by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>Number of CUs. A CU (Compute Unit) is the basic unit of service measurement. 1 CU = 1 CPU core + 4 GiB memory. For memory-enhanced instance family, 1 CU = 1 CPU core + 8 GiB memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>Duration. This parameter is valid only when payType is set to PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Payment type:</para>
        /// <ol>
        /// <item><description><para>Subscription (prePaid).</para>
        /// </description></item>
        /// <item><description><para>Pay-as-you-go (postPaid).</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prePay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Unit of subscription duration:</para>
        /// <list type="bullet">
        /// <item><description><para>Month</para>
        /// </description></item>
        /// <item><description><para>Year</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is valid only when payType is set to PrePaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>Coupon ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2345</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>Compute group specification type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

    }

}
