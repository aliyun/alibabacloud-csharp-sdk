// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLLogContextResponseBody : TeaModel {
        /// <summary>
        /// <para>The index of the anchor line in Lines. This value is empty if the fallback path does not match the anchor. In this case, Lines contains all lines in the window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AnchorIndex")]
        [Validation(Required=false)]
        public int? AnchorIndex { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-xxxxxxxx</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The context log lines in ascending order of time.</para>
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public List<RLLogContextLine> Lines { get; set; }

        /// <summary>
        /// <para>The log locating mode. Valid values: agent_collect_time for the exact path, and raw_time_cluster for the fallback path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_collect_time</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the number of raw lines in the fallback path reaches the upper limit of 5,000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Truncated")]
        [Validation(Required=false)]
        public bool? Truncated { get; set; }

    }

}
