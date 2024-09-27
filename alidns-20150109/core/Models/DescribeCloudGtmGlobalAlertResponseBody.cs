// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmGlobalAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public DescribeCloudGtmGlobalAlertResponseBodyAlertConfig AlertConfig { get; set; }
        public class DescribeCloudGtmGlobalAlertResponseBodyAlertConfig : TeaModel {
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmGlobalAlertResponseBodyAlertConfigAlertConfig> AlertConfig { get; set; }
            public class DescribeCloudGtmGlobalAlertResponseBodyAlertConfigAlertConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether DingTalk notifications are configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: DingTalk notifications are configured. DingTalk notifications are sent when alerts are triggered.</description></item>
                /// <item><description>false: DingTalk notifications are not configured.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DingtalkNotice")]
                [Validation(Required=false)]
                public bool? DingtalkNotice { get; set; }

                /// <summary>
                /// <para>Indicates whether email notifications are configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Email notifications are configured. Emails are sent when alerts are triggered.</description></item>
                /// <item><description>false: Email notifications are not configured.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EmailNotice")]
                [Validation(Required=false)]
                public bool? EmailNotice { get; set; }

                /// <summary>
                /// <para>The type of the alert event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>addr_alert: The address is unavailable.</description></item>
                /// <item><description>addr_resume: The address becomes available.</description></item>
                /// <item><description>addr_pool_unavailable: The address pool is unavailable.</description></item>
                /// <item><description>addr_pool_available: The address pool becomes available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>addr_alert</para>
                /// </summary>
                [NameInMap("NoticeType")]
                [Validation(Required=false)]
                public string NoticeType { get; set; }

                /// <summary>
                /// <para>Indicates whether text message notifications are configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Text message notifications are configured. Text messages are sent when alerts are triggered.</description></item>
                /// <item><description>false: Text message notifications are not configured.</description></item>
                /// </list>
                /// <para>Only the China site (aliyun.com) supports text message notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SmsNotice")]
                [Validation(Required=false)]
                public bool? SmsNotice { get; set; }

            }

        }

        /// <summary>
        /// <para>The alert contact groups.</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public DescribeCloudGtmGlobalAlertResponseBodyAlertGroup AlertGroup { get; set; }
        public class DescribeCloudGtmGlobalAlertResponseBodyAlertGroup : TeaModel {
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public List<string> AlertGroup { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B57C121B-A45F-44D8-A9B2-13E5A5044195</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
