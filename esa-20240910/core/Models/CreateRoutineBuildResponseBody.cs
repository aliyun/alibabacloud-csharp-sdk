// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineBuildResponseBody : TeaModel {
        /// <summary>
        /// <para>The build ID in Yunxiao.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PipeLineRunId")]
        [Validation(Required=false)]
        public long? PipeLineRunId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the ER build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>159782040838348</para>
        /// </summary>
        [NameInMap("RoutineBuildId")]
        [Validation(Required=false)]
        public long? RoutineBuildId { get; set; }

        /// <summary>
        /// <para>The status of the build task. A value of building indicates that the task is being built. A value of pending indicates that the task is queued. When the task is queued, the run ID is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
