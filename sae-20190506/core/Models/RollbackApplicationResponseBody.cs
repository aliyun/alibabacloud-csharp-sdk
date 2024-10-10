// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RollbackApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RollbackApplicationResponseBodyData Data { get; set; }
        public class RollbackApplicationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>01db03d3-3ee9-48b3-b3d0-dfce2d88****</para>
            /// </summary>
            [NameInMap("ChangeOrderId")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>Specifies whether approval is required when a RAM user performs release. Take note of the following rules:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsNeedApproval")]
            [Validation(Required=false)]
            public bool? IsNeedApproval { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>The <b>ErrorCode</b> parameter is not returned if the request succeeds.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section of this topic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Null</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The message returned for the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91F93257-7A4A-4BD3-9A7E-2F6EAE6D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the application is successfully rolled back. Take note of the following rules:</para>
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

        /// <summary>
        /// <para>The trace ID that is used to query the details of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0a98a02315955564772843261e****</para>
        /// </summary>
        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
