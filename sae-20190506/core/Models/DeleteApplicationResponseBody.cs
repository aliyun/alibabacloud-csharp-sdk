// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DeleteApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the application is deleted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the change order that is used to query the task execution status.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteApplicationResponseBodyData Data { get; set; }
        public class DeleteApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The error code that is returned if the request fails.</para>
            /// <list type="bullet">
            /// <item><description>If the request is successful, this parameter is not returned.****</description></item>
            /// <item><description>This parameter is returned only if the request failed.**** For more information about the values of this parameter, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>01db03d3-3ee9-48b3-b3d0-dfce2d88****</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The request is successful.</description></item>
        /// <item><description><b>3xx</b>: A redirection message is returned.</description></item>
        /// <item><description><b>4xx</b>: The request is invalid.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The trace ID that is used to query details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request is successful, <b>success</b> is returned.</description></item>
        /// <item><description>If an error occurred, the error code is returned.</description></item>
        /// </list>
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
        /// <para>The returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
