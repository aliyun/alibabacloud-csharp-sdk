// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeZonesRequest : TeaModel {
        /// <summary>
        /// <para>The natural language that is used to filter responses. For more information, see <a href="https://tools.ietf.org/html/rfc7231">RFC 7231</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh-CN: Simplified Chinese</description></item>
        /// <item><description>zh_TW: Traditional Chinese</description></item>
        /// <item><description>en-US: English</description></item>
        /// <item><description>ja: Japanese</description></item>
        /// <item><description>fr: French</description></item>
        /// <item><description>de: German</description></item>
        /// <item><description>ko: Korean</description></item>
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
        /// <para>The billing method of resources. For more information, see <a href="https://help.aliyun.com/document_detail/25398.html">Billing overview</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Prepaid: subscription</description></item>
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// </list>
        /// <para>Default value: PostPaid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
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

        /// <summary>
        /// <para>The ID of the region. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

        /// <summary>
        /// <para>The bidding policy for the pay-as-you-go instance. You can specify this parameter when you set <c>InstanceChargeType</c> to PostPaid. For more information, see <a href="https://help.aliyun.com/document_detail/52088.html">Preemptible instances</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instances are regular pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is a preemptible instance that has a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is a preemptible instance for which the market price is automatically used as the bid price. The market price can be up to the pay-as-you-go price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>Specifies whether to display detailed information.</para>
        /// <list type="bullet">
        /// <item><description>true: displays detailed information.</description></item>
        /// <item><description>false: does not display detailed information.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
