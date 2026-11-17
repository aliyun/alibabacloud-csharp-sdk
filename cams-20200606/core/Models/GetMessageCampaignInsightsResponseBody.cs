// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetMessageCampaignInsightsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request is successful.</para>
        /// </description></item>
        /// <item><description><para>For other error codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMessageCampaignInsightsResponseBodyData> Data { get; set; }
        public class GetMessageCampaignInsightsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The start date in YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-01</para>
            /// </summary>
            [NameInMap("DateStart")]
            [Validation(Required=false)]
            public string DateStart { get; set; }

            /// <summary>
            /// <para>The end date in YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-29</para>
            /// </summary>
            [NameInMap("DateStop")]
            [Validation(Required=false)]
            public string DateStop { get; set; }

            /// <summary>
            /// <para>The average cost per delivered message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2755</para>
            /// </summary>
            [NameInMap("MarketingMessagesCostPerDelivered")]
            [Validation(Required=false)]
            public string MarketingMessagesCostPerDelivered { get; set; }

            /// <summary>
            /// <para>The average cost per message link click. This metric excludes messages sent to Europe, Argentina, Türkiye, South Korea, and Japan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>268</para>
            /// </summary>
            [NameInMap("MarketingMessagesCostPerLinkBtnClick")]
            [Validation(Required=false)]
            public string MarketingMessagesCostPerLinkBtnClick { get; set; }

            /// <summary>
            /// <para>The number of messages that businesses send to users and that are successfully delivered. Some messages may not be delivered, such as when the user\&quot;s device is unavailable. This metric excludes messages delivered to Europe and Japan. In some cases, this metric may be an estimate, and there may be data inconsistency between its value and the data displayed on your bill due to minor differences in the data processing procedure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2755</para>
            /// </summary>
            [NameInMap("MarketingMessagesDelivered")]
            [Validation(Required=false)]
            public string MarketingMessagesDelivered { get; set; }

            /// <summary>
            /// <para>The message delivery rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesDeliveryRate")]
            [Validation(Required=false)]
            public string MarketingMessagesDeliveryRate { get; set; }

            /// <summary>
            /// <para>The number of times users clicked or tapped links in marketing messages that directed them to on-platform or off-platform destinations specified by the advertiser. This metric excludes messages sent to Europe, Argentina, Türkiye, South Korea, and Japan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>268</para>
            /// </summary>
            [NameInMap("MarketingMessagesLinkBtnClick")]
            [Validation(Required=false)]
            public string MarketingMessagesLinkBtnClick { get; set; }

            /// <summary>
            /// <para>The percentage of delivered messages that received link clicks out of the total number of delivered messages. This metric excludes messages sent to Europe, Argentina, Türkiye, South Korea, and Japan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesLinkBtnClickRate")]
            [Validation(Required=false)]
            public string MarketingMessagesLinkBtnClickRate { get; set; }

            /// <summary>
            /// <para>The number of read messages divided by the number of delivered messages. The system may not capture the read status of some messages, such as when customers turn off read receipts. This metric excludes messages sent to Europe and Japan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesReadRate")]
            [Validation(Required=false)]
            public string MarketingMessagesReadRate { get; set; }

            /// <summary>
            /// <para>The total amount spent on message campaigns, message sets, or messages over the entire delivery period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38.87</para>
            /// </summary>
            [NameInMap("MarketingMessagesSpend")]
            [Validation(Required=false)]
            public string MarketingMessagesSpend { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s39**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
