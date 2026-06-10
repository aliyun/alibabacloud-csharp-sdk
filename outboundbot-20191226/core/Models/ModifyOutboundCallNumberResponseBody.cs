// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ModifyOutboundCallNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>API status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Number information</para>
        /// </summary>
        [NameInMap("OutboundCallNumber")]
        [Validation(Required=false)]
        public ModifyOutboundCallNumberResponseBodyOutboundCallNumber OutboundCallNumber { get; set; }
        public class ModifyOutboundCallNumberResponseBodyOutboundCallNumber : TeaModel {
            /// <summary>
            /// <para>Outbound call number</para>
            /// 
            /// <b>Example:</b>
            /// <para>10088xxxx</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public string Number { get; set; }

            /// <summary>
            /// <para>Number ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>fa0e21e9-caab-4629-9121-1e341243d599</para>
            /// </summary>
            [NameInMap("OutboundCallNumberId")]
            [Validation(Required=false)]
            public string OutboundCallNumberId { get; set; }

            /// <summary>
            /// <para>Rate limiting period</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RateLimitCount")]
            [Validation(Required=false)]
            public string RateLimitCount { get; set; }

            /// <summary>
            /// <para>Rate limiting count</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RateLimitPeriod")]
            [Validation(Required=false)]
            public string RateLimitPeriod { get; set; }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
