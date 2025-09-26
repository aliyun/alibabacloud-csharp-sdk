// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class StartCodeInterpreterSessionResult : TeaModel {
        /// <summary>
        /// <para>SUCCESS 为成功，失败情况返回对应错误类型，比如 ERR_BAD_REQUEST ERR_VALIDATION_FAILED ERR_INTERNAL_SERVER_ERROR</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CodeInterpreterSessionOut Data { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
