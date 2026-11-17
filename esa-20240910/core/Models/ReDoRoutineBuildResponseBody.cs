// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ReDoRoutineBuildResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Yunxiao build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("PipeLineRunId")]
        [Validation(Required=false)]
        public long? PipeLineRunId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F8AA0364-0FDB-4AD5-AC74-D69FAB8924ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the ER build task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156773519472872</para>
        /// </summary>
        [NameInMap("RoutineBuildId")]
        [Validation(Required=false)]
        public long? RoutineBuildId { get; set; }

        /// <summary>
        /// <para>The status of the build task. Valid values: building: The build is in progress. pending: The build is queued. A successful submission does not indicate that the pipeline has been created. The run ID is 0 when the task is queued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
