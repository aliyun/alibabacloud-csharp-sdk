// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeCloudGtmInstanceConfigAlertResponseBody : TeaModel {
        /// <summary>
        /// <para>The alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfig AlertConfig { get; set; }
        public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfig : TeaModel {
            [NameInMap("AlertConfig")]
            [Validation(Required=false)]
            public List<DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfigAlertConfig> AlertConfig { get; set; }
            public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertConfigAlertConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether DingTalk notifications are configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: DingTalk notifications are configured. DingTalk notifications are sent after alerts are triggered.</description></item>
                /// <item><description>false: DingTalk notifications are not configured.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DingtalkNotice")]
                [Validation(Required=false)]
                public bool? DingtalkNotice { get; set; }

                /// <summary>
                /// <para>Indicates whether email notifications are configured. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Email notifications are configured. Emails are sent after alerts are triggered.</description></item>
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
                /// <item><description>true: Text message notifications are configured. Text messages are sent after alerts are triggered.</description></item>
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
        public DescribeCloudGtmInstanceConfigAlertResponseBodyAlertGroup AlertGroup { get; set; }
        public class DescribeCloudGtmInstanceConfigAlertResponseBodyAlertGroup : TeaModel {
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public List<string> AlertGroup { get; set; }

        }

        /// <summary>
        /// <para>The alert configuration mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>global: global alert configuration</description></item>
        /// <item><description>instance_config: custom alert configuration</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("AlertMode")]
        [Validation(Required=false)]
        public string AlertMode { get; set; }

        /// <summary>
        /// <para>The configuration ID of the access domain name. Two configuration IDs exist when the access domain name is bound to the same GTM instance but an A record and an AAAA record are configured for the access domain name. The configuration ID uniquely identifies a configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Config-000**11</para>
        /// </summary>
        [NameInMap("ConfigId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// <para>The ID of the GTM 3.0 instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gtm-cn-wwo3a3hbz**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0F32959D-417B-4D66-8463-68606605E3E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
