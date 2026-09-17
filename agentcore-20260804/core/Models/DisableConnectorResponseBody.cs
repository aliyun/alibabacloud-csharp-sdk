// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DisableConnectorResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The Connector details.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public DisableConnectorResponseBodyData Data { get; set; }
        public class DisableConnectorResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of Agents bound to the Connector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("boundAgentCount")]
            [Validation(Required=false)]
            public long? BoundAgentCount { get; set; }

            /// <summary>
            /// <para>The time when the Connector was enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-01T08:00:00Z</para>
            /// </summary>
            [NameInMap("enabledAt")]
            [Validation(Required=false)]
            public string EnabledAt { get; set; }

            /// <summary>
            /// <para>The Connector configuration JSON string before the Connector was disabled. This is sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;site&quot;:&quot;global&quot;,&quot;organizationId&quot;:&quot;org-xxxx&quot;}</para>
            /// </summary>
            [NameInMap("metadata")]
            [Validation(Required=false)]
            public string Metadata { get; set; }

            /// <summary>
            /// <para>The Connector name. Currently, the value is qodercli.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qodercli</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Connector status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-123456</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
