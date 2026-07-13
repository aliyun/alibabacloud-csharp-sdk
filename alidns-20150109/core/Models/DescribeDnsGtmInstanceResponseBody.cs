// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance configuration.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyConfig Config { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyConfig : TeaModel {
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public DescribeDnsGtmInstanceResponseBodyConfigAlertConfig AlertConfig { get; set; }
            public class DescribeDnsGtmInstanceResponseBodyConfigAlertConfig : TeaModel {
                [NameInMap("AlertConfig")]
                [Validation(Required=false)]
                public List<DescribeDnsGtmInstanceResponseBodyConfigAlertConfigAlertConfig> AlertConfig { get; set; }
                public class DescribeDnsGtmInstanceResponseBodyConfigAlertConfigAlertConfig : TeaModel {
                    [NameInMap("DingtalkNotice")]
                    [Validation(Required=false)]
                    public bool? DingtalkNotice { get; set; }

                    [NameInMap("EmailNotice")]
                    [Validation(Required=false)]
                    public bool? EmailNotice { get; set; }

                    [NameInMap("NoticeType")]
                    [Validation(Required=false)]
                    public string NoticeType { get; set; }

                    [NameInMap("SmsNotice")]
                    [Validation(Required=false)]
                    public bool? SmsNotice { get; set; }

                }

            }

            /// <summary>
            /// <para>The alert contact group. The value is a \<c>List\\&lt;string&gt;\\</c> in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;test1&quot;,&quot;test2&quot;]</para>
            /// </summary>
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public string AlertGroup { get; set; }

            /// <summary>
            /// <para>The type of the CNAME domain name used for access.</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: Internet-facing</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("CnameType")]
            [Validation(Required=false)]
            public string CnameType { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public access domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gtm-cn-wwo3a3hbz**.example.com</para>
            /// </summary>
            [NameInMap("PubicZoneName")]
            [Validation(Required=false)]
            public string PubicZoneName { get; set; }

            /// <summary>
            /// <para>The access method for the public CNAME.</para>
            /// <list type="bullet">
            /// <item><description><para>CUSTOM: custom</para>
            /// </description></item>
            /// <item><description><para>SYSTEM_ASSIGN: system-assigned. This feature is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("PublicCnameMode")]
            [Validation(Required=false)]
            public string PublicCnameMode { get; set; }

            /// <summary>
            /// <para>The hostname for public access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.rr</para>
            /// </summary>
            [NameInMap("PublicRr")]
            [Validation(Required=false)]
            public string PublicRr { get; set; }

            /// <summary>
            /// <para>The user\&quot;s public service domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("PublicUserDomainName")]
            [Validation(Required=false)]
            public string PublicUserDomainName { get; set; }

            /// <summary>
            /// <para>The access policy mode.</para>
            /// <list type="bullet">
            /// <item><description><para>LATENCY: latency-based</para>
            /// </description></item>
            /// <item><description><para>GEO: geography-based</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GEO</para>
            /// </summary>
            [NameInMap("StrategyMode")]
            [Validation(Required=false)]
            public string StrategyMode { get; set; }

            /// <summary>
            /// <para>The global TTL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public int? Ttl { get; set; }

        }

        /// <summary>
        /// <para>The time when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-14T06:58Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1602656937000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The expiration date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-14T06:58Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp when the instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1602656937000</para>
        /// </summary>
        [NameInMap("ExpireTimestamp")]
        [Validation(Required=false)]
        public long? ExpireTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>84314904-D047-4176-A0EC-256D7F68C7F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>resourc*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The quota on the number of text message notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SmsQuota")]
        [Validation(Required=false)]
        public int? SmsQuota { get; set; }

        /// <summary>
        /// <para>The quota on the number of health check tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TaskQuota")]
        [Validation(Required=false)]
        public int? TaskQuota { get; set; }

        /// <summary>
        /// <para>The used quota.</para>
        /// </summary>
        [NameInMap("UsedQuota")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceResponseBodyUsedQuota UsedQuota { get; set; }
        public class DescribeDnsGtmInstanceResponseBodyUsedQuota : TeaModel {
            /// <summary>
            /// <para>The number of DingTalk notifications that were sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("DingtalkUsedCount")]
            [Validation(Required=false)]
            public int? DingtalkUsedCount { get; set; }

            /// <summary>
            /// <para>The number of email notifications that were sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("EmailUsedCount")]
            [Validation(Required=false)]
            public int? EmailUsedCount { get; set; }

            /// <summary>
            /// <para>The number of text messages that were sent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("SmsUsedCount")]
            [Validation(Required=false)]
            public int? SmsUsedCount { get; set; }

            /// <summary>
            /// <para>The number of health check tasks that were created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TaskUsedCount")]
            [Validation(Required=false)]
            public int? TaskUsedCount { get; set; }

        }

        /// <summary>
        /// <para>The version of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

    }

}
