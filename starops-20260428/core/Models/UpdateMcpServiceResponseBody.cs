// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class UpdateMcpServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>log-query</para>
        /// </summary>
        [NameInMap("mcpServiceName")]
        [Validation(Required=false)]
        public string McpServiceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-************</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
