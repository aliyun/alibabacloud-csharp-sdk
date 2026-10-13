// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetMetaProfilingResultDbOverviewRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return only summary data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isSummary")]
        [Validation(Required=false)]
        public string IsSummary { get; set; }

        /// <summary>
        /// <para>The ID of the metadata profiling task. It is used to locate the profiling task for which you want to query the overview.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
