// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyLoadBalancerPayTypeRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid only when the <c>PayType</c> parameter is set to <b>PrePay</b>. This parameter is valid only for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <list type="bullet">
        /// <item><description>If <b>PricingCycle</b> is set to <b>month</b>, the valid values are <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If <b>PricingCycle</b> is set to <b>year</b>, the valid values are <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is valid only when the <b>PayType</b> parameter is set to <b>PrePay</b>. This parameter is valid only for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719dfa08ex*****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayOnDemand</b> (default): pay-as-you-go</description></item>
        /// </list>
        /// <para>To change the billing method of a pay-as-you-go CLB instance to subscription, you must set the parameter to <b>PrePay</b>. In addition, the previous billing method of the CLB instance must be <b>PayOnDemand</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle.</para>
        /// <para>Valid values: <b>year</b> and <b>month</b>.</para>
        /// <remarks>
        /// <para> This parameter is valid only when the <b>PayType</b> parameter is set to <b>PrePay</b>. This parameter is valid only for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the region where the CLB instance is deployed.</para>
        /// <para>You can query the region ID from the <a href="https://help.aliyun.com/document_detail/40654.html">Regions and zones</a> list or by calling the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
