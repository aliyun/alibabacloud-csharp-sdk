// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateCloudGtmGlobalAlertRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>zh-CN</c>: Chinese</para>
        /// </description></item>
        /// <item><description><para><c>en-US</c>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>A list of alert configurations.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<UpdateCloudGtmGlobalAlertRequestAlertConfig> AlertConfig { get; set; }
        public class UpdateCloudGtmGlobalAlertRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>Whether to send a DingTalk notification when an alert is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: A DingTalk notification is sent.</para>
            /// </description></item>
            /// <item><description><para><c>false</c>: Do not send a DingTalk notification.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DingtalkNotice")]
            [Validation(Required=false)]
            public bool? DingtalkNotice { get; set; }

            /// <summary>
            /// <para>Whether to send an email notification when an alert is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: An email notification is sent.</para>
            /// </description></item>
            /// <item><description><para><c>false</c> or <c>null</c>: Do not send an email notification.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EmailNotice")]
            [Validation(Required=false)]
            public bool? EmailNotice { get; set; }

            /// <summary>
            /// <para>The alert event type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>addr_alert</c>: An address becomes unavailable.</para>
            /// </description></item>
            /// <item><description><para><c>addr_resume</c>: An address becomes available.</para>
            /// </description></item>
            /// <item><description><para><c>addr_pool_unavailable</c>: An address pool becomes unavailable.</para>
            /// </description></item>
            /// <item><description><para><c>addr_pool_available</c>: An address pool becomes available.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>addr_alert</para>
            /// </summary>
            [NameInMap("NoticeType")]
            [Validation(Required=false)]
            public string NoticeType { get; set; }

            /// <summary>
            /// <para>The alert threshold for queries per second (QPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QpsThreshold")]
            [Validation(Required=false)]
            public long? QpsThreshold { get; set; }

            /// <summary>
            /// <para>Whether to send a text message notification when an alert is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>true</c>: A text message notification is sent.</para>
            /// </description></item>
            /// <item><description><para><c>false</c> or <c>null</c>: Do not send a text message notification.</para>
            /// </description></item>
            /// </list>
            /// <para>Text message notifications are available only on the China site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SmsNotice")]
            [Validation(Required=false)]
            public bool? SmsNotice { get; set; }

            /// <summary>
            /// <para>The alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

        /// <summary>
        /// <para>A list of alert notification groups.</para>
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public List<string> AlertGroup { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure request idempotence. This token must be unique for each request, contain only ASCII characters, and be no more than 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24**22</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
