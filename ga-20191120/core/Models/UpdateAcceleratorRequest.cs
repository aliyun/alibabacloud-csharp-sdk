// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1odcab8tmno0hdq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Disables automatic payment. After an order is generated, you must go to the <a href="https://usercenter2-intl.aliyun.com/order/list">Order Hub</a> to complete the payment.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Enables automatic payment. The system automatically pays the bill.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only for upgrade orders.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use a coupon to pay for the bill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Use a coupon.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Do not use a coupon.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only if <b>AutoPay</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The bandwidth of the standard GA instance. Unit: <b>Mbps</b>.</para>
        /// <para>Valid values: 200 to 5000.</para>
        /// <remarks>
        /// <para>This parameter is valid only when the access mode of the acceleration area is Anycast.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the GA instance. The description can be up to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Accelerator</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the GA instance.</para>
        /// <para>The name must be 1 to 128 characters in length, start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Accelerator</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The specification of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Small I</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Small II</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Small III</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: Medium I</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: Medium II</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: Medium III</para>
        /// </description></item>
        /// <item><description><para><b>20</b>: Large I</para>
        /// </description></item>
        /// <item><description><para><b>30</b>: Large II</para>
        /// </description></item>
        /// <item><description><para><b>40</b>: Large III</para>
        /// </description></item>
        /// <item><description><para><b>50</b>: Large IV</para>
        /// </description></item>
        /// <item><description><para><b>60</b>: Large V</para>
        /// </description></item>
        /// <item><description><para><b>70</b>: Large VI</para>
        /// </description></item>
        /// <item><description><para><b>80</b>: Large VII</para>
        /// </description></item>
        /// <item><description><para><b>90</b>: Large VIII</para>
        /// </description></item>
        /// <item><description><para><b>100</b>: Ultra-large I</para>
        /// </description></item>
        /// <item><description><para><b>200</b>: Ultra-large II</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Large III and higher specifications are available only to whitelisted users. To use these specifications, contact your account manager.</para>
        /// </remarks>
        /// <para>The definitions of instance types vary. For more information, see <a href="https://help.aliyun.com/document_detail/153127.html">Instance types</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
