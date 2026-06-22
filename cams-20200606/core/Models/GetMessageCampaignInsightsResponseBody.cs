// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetMessageCampaignInsightsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
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
        /// <item><description><para>OK: The request was successful.</para>
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMessageCampaignInsightsResponseBodyData> Data { get; set; }
        public class GetMessageCampaignInsightsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-01</para>
            /// </summary>
            [NameInMap("DateStart")]
            [Validation(Required=false)]
            public string DateStart { get; set; }

            /// <summary>
            /// <para>The end time.</para>
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
            /// <para>The number of messages that are sent by the business and successfully delivered to users. Some messages may fail to deliver if a user\&quot;s device is unavailable. This metric excludes messages delivered to Europe and Japan. In some cases, this metric is an estimate. The value may differ from the data on your bill due to minor discrepancies during data processing.</para>
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
            /// <para>The number of times users click or tap a marketing message that take users to an on-Meta or off-Meta destination, as specified by the advertiser. This metric excludes messages sent to Europe, Argentina, Türkiye, South Korea, and Japan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>268</para>
            /// </summary>
            [NameInMap("MarketingMessagesLinkBtnClick")]
            [Validation(Required=false)]
            public string MarketingMessagesLinkBtnClick { get; set; }

            /// <summary>
            /// <para>The percentage of delivered messages that received a link click. This metric excludes messages sent to Europe, Argentina, Türkiye, South Korea, and Japan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesLinkBtnClickRate")]
            [Validation(Required=false)]
            public string MarketingMessagesLinkBtnClickRate { get; set; }

            /// <summary>
            /// <para>The number of read messages divided by the number of delivered messages. The read status of some messages may not be captured if a customer disables read receipts. This metric excludes messages sent to Europe and Japan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesReadRate")]
            [Validation(Required=false)]
            public string MarketingMessagesReadRate { get; set; }

            /// <summary>
            /// <para>The total amount spent on a campaign, message group, or message during over its lifetime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38.87</para>
            /// </summary>
            [NameInMap("MarketingMessagesSpend")]
            [Validation(Required=false)]
            public string MarketingMessagesSpend { get; set; }

        }

        /// <summary>
        /// <para>The error description.</para>
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
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: successful.</para>
        /// </description></item>
        /// <item><description><para>false: failed.</para>
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
