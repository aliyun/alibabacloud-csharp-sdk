// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduInterpreting20240828.Models
{
    public class SubmitEvaluationTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BA3BB7D0-E098-5F0C-AF25-0BEFAEE7D1F0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8fb75c55-98b5-4b82-ae67-5dbb9a0646cc</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
