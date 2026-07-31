// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class OpenStructMvRecommendTaskModel : TeaModel {
        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-12 23:59</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>Description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task desc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Last execution time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-13 00:10</para>
        /// </summary>
        [NameInMap("LastRunAt")]
        [Validation(Required=false)]
        public string LastRunAt { get; set; }

        /// <summary>
        /// <para>The minimum number of slow queries that match the pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinRewriteQueryCount")]
        [Validation(Required=false)]
        public int? MinRewriteQueryCount { get; set; }

        /// <summary>
        /// <para>The number of minimum acceleration patterns.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MinRewriteQueryPattern")]
        [Validation(Required=false)]
        public int? MinRewriteQueryPattern { get; set; }

        /// <summary>
        /// <para>The time range for scanning data. Unit: days. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ScanQueriesRange")]
        [Validation(Required=false)]
        public int? ScanQueriesRange { get; set; }

        /// <summary>
        /// <para>The execution schedule of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The 12:30 every day</para>
        /// </summary>
        [NameInMap("SchedulingSettings")]
        [Validation(Required=false)]
        public string SchedulingSettings { get; set; }

        /// <summary>
        /// <para>The wait threshold for slow queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SlowQueryThreshold")]
        [Validation(Required=false)]
        public int? SlowQueryThreshold { get; set; }

        /// <summary>
        /// <para>The name of the recommendation task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mv_task1</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
