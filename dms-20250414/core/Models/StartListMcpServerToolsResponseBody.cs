// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class StartListMcpServerToolsResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the asynchronous detection startup. Only StartTimestamp may be returned if the resources are still being provisioned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public StartListMcpServerToolsResponseBodyData Data { get; set; }
        public class StartListMcpServerToolsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The temporary session ID for this detection. After the startup succeeds, use this value to call GetListMcpServerToolsResult to poll for the result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1vw***6wr</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp at which the server started the detection, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785819600000</para>
            /// </summary>
            [NameInMap("StartTimestamp")]
            [Validation(Required=false)]
            public string StartTimestamp { get; set; }

        }

        /// <summary>
        /// <para>The return code. The value success is returned if the request was successful. An error code is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if a system-level request failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent status=wait_resource_running</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
