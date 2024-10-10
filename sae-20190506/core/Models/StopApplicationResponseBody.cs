// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class StopApplicationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, this parameter is not returned.****</description></item>
        /// <item><description>This parameter is returned only if the request failed.**** For more information, see <b>Error codes</b> in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StopApplicationResponseBodyData Data { get; set; }
        public class StopApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The HTTP status code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>2xx</b>: indicates that the request was successful.</description></item>
            /// <item><description><b>3xx</b>: indicates that the request was redirected.</description></item>
            /// <item><description><b>4xx</b>: indicates that the request was invalid.</description></item>
            /// <item><description><b>5xx</b>: indicates that a server error occurred.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4a815998-b468-4bea-b7d8-59f52a44****</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the specified application is stopped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the trace. It can be used to query the details of a request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
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

        /// <summary>
        /// <para>The ID of the change order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc3b6e215637275918588187d****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
