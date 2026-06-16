// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class AgentRuntimeVersionResult : TeaModel {
        /// <summary>
        /// <para>SUCCESS indicates success. In case of failure, the corresponding error type is returned, such as ERR_BAD_REQUEST, ERR_VALIDATION_FAILED, or ERR_INTERNAL_SERVER_ERROR.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Detailed information about the agent runtime version</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AgentRuntimeVersion Data { get; set; }

        /// <summary>
        /// <para>A unique request identifier used for troubleshooting</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
