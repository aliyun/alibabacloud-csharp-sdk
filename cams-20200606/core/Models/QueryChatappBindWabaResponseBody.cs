// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryChatappBindWabaResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description><para>A value of <c>OK</c> indicates the request was successful.</para>
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
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryChatappBindWabaResponseBodyData Data { get; set; }
        public class QueryChatappBindWabaResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The account review status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>PENDING</c>: The account is under review.</para>
            /// </description></item>
            /// <item><description><para><c>APPROVED</c>: The account is approved.</para>
            /// </description></item>
            /// <item><description><para><c>REJECTED</c>: The account is rejected.</para>
            /// </description></item>
            /// <item><description><para><c>DISABLED</c>: The account is disabled.</para>
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
            /// <para>Details about the WABA account.</para>
            /// </summary>
            [NameInMap("AuthInternationalRateEligibility")]
            [Validation(Required=false)]
            public Dictionary<string, object> AuthInternationalRateEligibility { get; set; }

            /// <summary>
            /// <para>The Business platform ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19293988***</para>
            /// </summary>
            [NameInMap("BusinessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// <para>The Business platform name.</para>
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
            /// <para>The WABA account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20393988393993***</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>N</para>
            /// </summary>
            [NameInMap("IsOnBizApp")]
            [Validation(Required=false)]
            public string IsOnBizApp { get; set; }

            /// <summary>
            /// <para>The MML status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("MarketingMessageLiteStatus")]
            [Validation(Required=false)]
            public string MarketingMessageLiteStatus { get; set; }

            /// <summary>
            /// <para>The template namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93e6b26e_8a67_4163_a093_ebfe645a66b0</para>
            /// </summary>
            [NameInMap("MessageTemplateNamespace")]
            [Validation(Required=false)]
            public string MessageTemplateNamespace { get; set; }

            /// <summary>
            /// <para>The WABA account name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The international rate capability qualification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;start_time&quot;:1721952000</para>
            /// </summary>
            [NameInMap("PrimaryBusinessLocation")]
            [Validation(Required=false)]
            public string PrimaryBusinessLocation { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
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
