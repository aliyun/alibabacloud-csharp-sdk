// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryChatappBindWabaResponseBody : TeaModel {
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
        /// <para>The HTTP status code returned.</para>
        /// <list type="bullet">
        /// <item><description>A value of OK indicates that the call is successful.</description></item>
        /// <item><description>Other values indicate that the call fails. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
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
        public QueryChatappBindWabaResponseBodyData Data { get; set; }
        public class QueryChatappBindWabaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The review state of the WhatsApp Business account (WABA).</para>
            /// <remarks>
            /// <para> Valid values:</para>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>PENDING: The WABA is to be reviewed.</para>
            /// </description></item>
            /// <item><description><para>APPROVED: The WABA was approved.</para>
            /// </description></item>
            /// <item><description><para>REJECTED: The WABA was rejected.</para>
            /// </description></item>
            /// <item><description><para>DISABLED: The WABA was forbidden.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("AccountReviewStatus")]
            [Validation(Required=false)]
            public string AccountReviewStatus { get; set; }

            /// <summary>
            /// <para>WABA related information.</para>
            /// </summary>
            [NameInMap("AuthInternationalRateEligibility")]
            [Validation(Required=false)]
            public Dictionary<string, object> AuthInternationalRateEligibility { get; set; }

            /// <summary>
            /// <para>The business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19293988***</para>
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// <para>The business name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("BusinessName")]
            [Validation(Required=false)]
            public string BusinessName { get; set; }

            /// <summary>
            /// <para>The currency.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USD</para>
            /// </summary>
            [NameInMap("Currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The ID of the WhatsApp Business account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20393988393993***</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The Marketing Messaging Lite status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("MarketingMessageLiteStatus")]
            [Validation(Required=false)]
            public string MarketingMessageLiteStatus { get; set; }

            /// <summary>
            /// <para>The namespace of the message template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
            /// </summary>
            [NameInMap("MessageTemplateNamespace")]
            [Validation(Required=false)]
            public string MessageTemplateNamespace { get; set; }

            /// <summary>
            /// <para>The name of the WhatsApp Business account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The start time when the authentication-international rate applies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;start_time&quot;:1721952000</para>
            /// </summary>
            [NameInMap("PrimaryBusinessLocation")]
            [Validation(Required=false)]
            public string PrimaryBusinessLocation { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
