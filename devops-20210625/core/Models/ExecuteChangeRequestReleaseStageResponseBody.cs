// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ExecuteChangeRequestReleaseStageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("object")]
        [Validation(Required=false)]
        public long? Object { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3259***</para>
        /// </summary>
        [NameInMap("pipelineId")]
        [Validation(Required=false)]
        public long? PipelineId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pipelineRunId")]
        [Validation(Required=false)]
        public long? PipelineRunId { get; set; }

    }

}
