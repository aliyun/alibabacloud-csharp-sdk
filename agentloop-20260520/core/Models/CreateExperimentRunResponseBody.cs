// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateExperimentRunResponseBody : TeaModel {
        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Experiment created, execution started.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The experiment record ID. For online experiments, the format is typically exp-run-{uuid32}. For offline experiments, the format may also be a standard UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-run-f6d419b0ed3d43a7b585948a55efc07b</para>
        /// </summary>
        [NameInMap("recordId")]
        [Validation(Required=false)]
        public string RecordId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019F89B5-1B07-3BB3-A32E-F5B007029E9C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The experiment record status. After creation, the status is typically pending.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
