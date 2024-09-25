// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeIPv6TranslatorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of IPv6 Translation Service instances.</para>
        /// </summary>
        [NameInMap("Ipv6Translators")]
        [Validation(Required=false)]
        public DescribeIPv6TranslatorsResponseBodyIpv6Translators Ipv6Translators { get; set; }
        public class DescribeIPv6TranslatorsResponseBodyIpv6Translators : TeaModel {
            [NameInMap("Ipv6Translator")]
            [Validation(Required=false)]
            public List<DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator> Ipv6Translator { get; set; }
            public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6Translator : TeaModel {
                /// <summary>
                /// <para>The IPv4 address allocated to the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>47.99.XX.XX</para>
                /// </summary>
                [NameInMap("AllocateIpv4Addr")]
                [Validation(Required=false)]
                public string AllocateIpv4Addr { get; set; }

                /// <summary>
                /// <para>The IPv6 address allocated to the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2400:3200:1600::XXXX</para>
                /// </summary>
                [NameInMap("AllocateIpv6Addr")]
                [Validation(Required=false)]
                public string AllocateIpv6Addr { get; set; }

                /// <summary>
                /// <para>The bandwidth of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AvailableBandwidth")]
                [Validation(Required=false)]
                public string AvailableBandwidth { get; set; }

                /// <summary>
                /// <para>The bandwidth of the IPv6 Translation Service instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public int? Bandwidth { get; set; }

                /// <summary>
                /// <para>The business status of the IPv6 Translation Service instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b></description></item>
                /// <item><description><b>FinancialLocked</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("BusinessStatus")]
                [Validation(Required=false)]
                public string BusinessStatus { get; set; }

                /// <summary>
                /// <para>The timestamp when the IPv6 Translation Service instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1537151540000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>descriptionforinstance</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The timestamp when IPv6 Translation Service instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1539792000000</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The IDs of IPv6 mapping entries of the IPv6 Translation Service instance.</para>
                /// </summary>
                [NameInMap("Ipv6TranslatorEntryIds")]
                [Validation(Required=false)]
                public DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds Ipv6TranslatorEntryIds { get; set; }
                public class DescribeIPv6TranslatorsResponseBodyIpv6TranslatorsIpv6TranslatorIpv6TranslatorEntryIds : TeaModel {
                    [NameInMap("Ipv6TranslatorEntryId")]
                    [Validation(Required=false)]
                    public List<string> Ipv6TranslatorEntryId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ipv6trans-bp1858ys*****</para>
                /// </summary>
                [NameInMap("Ipv6TranslatorId")]
                [Validation(Required=false)]
                public string Ipv6TranslatorId { get; set; }

                /// <summary>
                /// <para>The name of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The billing method of the IPv6 Translation Service instance.</para>
                /// <list type="bullet">
                /// <item><description><b>Prepay</b>: subscription</description></item>
                /// <item><description><b>Postpay</b>: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prepay</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The region of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The specification of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>small</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The status of the IPv6 Translation Service instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
