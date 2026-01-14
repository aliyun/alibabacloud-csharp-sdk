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
        /// <item><description><b>false</b>: disables automatic payment. This is the default value. After an order is generated, you must go to the <a href="https://usercenter2-intl.aliyun.com/order/list">Order Center</a> to complete the payment.</description></item>
        /// <item><description><b>true</b>: enables automatic payment. Payments are automatically completed.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if you call the operation to upgrade a GA instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically pay bills by using coupons. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: automatically pays bills by using coupons.</description></item>
        /// <item><description><b>false</b>: does not automatically pay bills by using coupons.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if the <b>AutoPay</b> parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <para>The name must be 1 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
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
        /// <para>The region where the GA instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
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
        /// <item><description><b>1</b>: Small Ⅰ</description></item>
        /// <item><description><b>2</b>: Small Ⅱ</description></item>
        /// <item><description><b>3</b>: Small Ⅲ</description></item>
        /// <item><description><b>5</b>: Medium Ⅰ</description></item>
        /// <item><description><b>8</b>: Medium Ⅱ</description></item>
        /// <item><description><b>10</b>: Medium Ⅲ</description></item>
        /// <item><description><b>20</b>: Large Ⅰ</description></item>
        /// <item><description><b>30</b>: Large Ⅱ</description></item>
        /// <item><description><b>40</b>: Large Ⅲ</description></item>
        /// <item><description><b>50</b>: Large Ⅳ</description></item>
        /// <item><description><b>60</b>: Large Ⅴ</description></item>
        /// <item><description><b>70</b>: Large Ⅵ</description></item>
        /// <item><description><b>80</b>: Large VⅡ</description></item>
        /// <item><description><b>90</b>: Large VⅢ</description></item>
        /// <item><description><b>100</b>: Super Large Ⅰ</description></item>
        /// <item><description><b>200</b>: Super Large Ⅱ</description></item>
        /// </list>
        /// <remarks>
        /// <para> The Large Ⅲ specification and higher specifications are available only for accounts that are added to the whitelist. To use these specifications, contact your Alibaba Cloud account manager.</para>
        /// </remarks>
        /// <para>Different specifications provide different capabilities. For more information, see <a href="https://help.aliyun.com/document_detail/153127.html">Instance specifications</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
