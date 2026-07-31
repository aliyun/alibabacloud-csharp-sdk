// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeRegionsRequest : TeaModel {
        /// <summary>
        /// <para>The natural language that is used to filter responses. For more information, see <a href="https://tools.ietf.org/html/rfc7231">RFC 7231</a>. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>zh-CN: simplified Chinese.</description></item>
        /// <item><description>zh-TW: traditional Chinese.</description></item>
        /// <item><description>en-US: English.</description></item>
        /// <item><description>ja: Japanese.</description></item>
        /// <item><description>fr: French.</description></item>
        /// <item><description>de: German.</description></item>
        /// <item><description>ko: Korean.</description></item>
        /// </list>
        /// <para>Default value: zh-CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/25398.html">Billing overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription. If you set this parameter to PrePaid, confirm that your account supports balance payment or credit payment. Otherwise, the InvalidPayMethod error is returned.</description></item>
        /// <item><description>PostPaid: pay-as-you-go.</description></item>
        /// <item><description>SpotWithPriceLimit: spot instance with a maximum price limit.</description></item>
        /// <item><description>SpotAsPriceGo: spot instance priced at the market price with the pay-as-you-go price as the upper limit.</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instance: ECS instance.</description></item>
        /// <item><description>disk: cloud disk.</description></item>
        /// <item><description>reservedinstance: reserved instance.</description></item>
        /// <item><description>scu: storage capacity unit (SCU).</description></item>
        /// </list>
        /// <para>Default value: instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
