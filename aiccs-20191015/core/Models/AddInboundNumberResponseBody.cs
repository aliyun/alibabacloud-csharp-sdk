// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class AddInboundNumberResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about why access was denied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
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
        public List<AddInboundNumberResponseBodyData> Data { get; set; }
        public class AddInboundNumberResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The inbound number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234234238**33</para>
            /// </summary>
            [NameInMap("InboundNumber")]
            [Validation(Required=false)]
            public string InboundNumber { get; set; }

            /// <summary>
            /// <para>The error description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>号码不合法</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the number was added successfully. <c>true</c> indicates success, and <c>false</c> indicates failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }

        }

        /// <summary>
        /// <para>The status code description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D6A51251-F7C4-596A-9F45-3C3219A5450D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
