// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetMessageCampaignInsightsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetMessageCampaignInsightsResponseBodyData> Data { get; set; }
        public class GetMessageCampaignInsightsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-01</para>
            /// </summary>
            [NameInMap("DateStart")]
            [Validation(Required=false)]
            public string DateStart { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-29</para>
            /// </summary>
            [NameInMap("DateStop")]
            [Validation(Required=false)]
            public string DateStop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2755</para>
            /// </summary>
            [NameInMap("MarketingMessagesCostPerDelivered")]
            [Validation(Required=false)]
            public string MarketingMessagesCostPerDelivered { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>268</para>
            /// </summary>
            [NameInMap("MarketingMessagesCostPerLinkBtnClick")]
            [Validation(Required=false)]
            public string MarketingMessagesCostPerLinkBtnClick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2755</para>
            /// </summary>
            [NameInMap("MarketingMessagesDelivered")]
            [Validation(Required=false)]
            public string MarketingMessagesDelivered { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesDeliveryRate")]
            [Validation(Required=false)]
            public string MarketingMessagesDeliveryRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>268</para>
            /// </summary>
            [NameInMap("MarketingMessagesLinkBtnClick")]
            [Validation(Required=false)]
            public string MarketingMessagesLinkBtnClick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesLinkBtnClickRate")]
            [Validation(Required=false)]
            public string MarketingMessagesLinkBtnClickRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>79.419238</para>
            /// </summary>
            [NameInMap("MarketingMessagesReadRate")]
            [Validation(Required=false)]
            public string MarketingMessagesReadRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>38.87</para>
            /// </summary>
            [NameInMap("MarketingMessagesSpend")]
            [Validation(Required=false)]
            public string MarketingMessagesSpend { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s39**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
