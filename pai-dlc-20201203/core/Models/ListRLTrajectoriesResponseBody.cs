// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListRLTrajectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc********</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The effective page number. If pagination parameters are not provided, the default value 1 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The effective number of entries per page. If pagination parameters are not provided, the default value 10 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sample UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3afcfbdf-3956-4ab2-b9cb-f9c204b8fc9c</para>
        /// </summary>
        [NameInMap("PromptUid")]
        [Validation(Required=false)]
        public string PromptUid { get; set; }

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
        /// <para>The total number of trajectories under this UID before pagination. This is an exact value, and represents a lower bound only when Truncated is true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of trajectories on the current page, sorted in ascending order by SampleIndex.</para>
        /// </summary>
        [NameInMap("Trajectories")]
        [Validation(Required=false)]
        public List<RLTrajectory> Trajectories { get; set; }

    }

}
