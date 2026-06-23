// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipAddressProResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Elastic IP Address (EIP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip-25877c70gddh****</para>
        /// </summary>
        [NameInMap("AllocationId")]
        [Validation(Required=false)]
        public string AllocationId { get; set; }

        /// <summary>
        /// <para>The IP address of the EIP. This parameter is returned only when <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("EipAddress")]
        [Validation(Required=false)]
        public string EipAddress { get; set; }

        /// <summary>
        /// <para>The order ID.
        /// &lt;props=&quot;china&quot;&gt;This parameter is returned when <c>InstanceChargeType</c> is set to <c>PrePaid</c> (subscription). If <c>AutoPay</c> is set to <c>false</c>, go to the <a href="https://usercenter2.aliyun.com/order/list">Order Center</a> to complete the payment.
        /// &lt;props=&quot;intl&quot;&gt;This parameter is returned when <c>InstanceChargeType</c> is set to <c>PrePaid</c> (subscription). If <c>AutoPay</c> is set to <c>false</c>, go to the <a href="https://usercenter2-intl.aliyun.com/order/list">Order Center</a> to complete the payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20190000</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. This parameter is returned only when <b>InstanceChargeType</b> is set to <b>PostPaid</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-resourcegroup****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
