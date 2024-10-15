// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallInPoolTransferConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryCallInPoolTransferConfigResponseBodyData Data { get; set; }
        public class QueryCallInPoolTransferConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The call mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>roundRobin</b></description></item>
            /// <item><description><b>random</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>random</para>
            /// </summary>
            [NameInMap("CalledRouteMode")]
            [Validation(Required=false)]
            public string CalledRouteMode { get; set; }

            /// <summary>
            /// <para>The details of the response parameters.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<QueryCallInPoolTransferConfigResponseBodyDataDetails> Details { get; set; }
            public class QueryCallInPoolTransferConfigResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <para>The number used to transfer the call.</para>
                /// 
                /// <b>Example:</b>
                /// <para>400****</para>
                /// </summary>
                [NameInMap("Called")]
                [Validation(Required=false)]
                public string Called { get; set; }

            }

            /// <summary>
            /// <para>The time when the call transfer task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623137002000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The timeout period for transferring the call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TransferTimeout")]
            [Validation(Required=false)]
            public string TransferTimeout { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
