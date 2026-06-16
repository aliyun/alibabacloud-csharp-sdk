// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ListAgentRuntimeEndpointsResult : TeaModel {
        /// <summary>
        /// <para>The status code of the response. <c>SUCCESS</c> indicates that the operation succeeded. If the operation fails, an error code is returned, such as <c>ERR_BAD_REQUEST</c>, <c>ERR_VALIDATION_FAILED</c>, or <c>ERR_INTERNAL_SERVER_ERROR</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Detailed information about the agent runtime endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListAgentRuntimeEndpointsOutput Data { get; set; }

        /// <summary>
        /// <para>A unique request identifier for troubleshooting purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8A0F5F3-0C3E-4C82-9D4F-5E4B6A7C8D9E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
