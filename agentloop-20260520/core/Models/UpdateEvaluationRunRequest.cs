// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateEvaluationRunRequest : TeaModel {
        /// <summary>
        /// <para>The target status. Currently, only stop-related statuses are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Terminated</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
