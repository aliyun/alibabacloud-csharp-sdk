// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CommonResult : TeaModel {
        /// <summary>
        /// <para>Indicates the request status. A value of <c>SUCCESS</c> indicates success. On failure, an error code is returned, such as <c>ERR_BAD_REQUEST</c>, <c>ERR_VALIDATION_FAILED</c>, or <c>ERR_INTERNAL_SERVER_ERROR</c>.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned business data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public object Data { get; set; }

        /// <summary>
        /// <para>A unique request identifier for issue tracking.</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
