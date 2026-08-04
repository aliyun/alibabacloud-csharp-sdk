// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class InitWorkspaceSystemMcpServerResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether all system MCP services are initialized successfully. Returns true even when no system MCP services are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>The return code. The value success is returned for successful requests. An error code is returned for failed requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when a system-level request failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to initialize workspace system MCP servers</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550***544</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Succeeded.</description></item>
        /// <item><description>false: Failed.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
