// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSupabaseBackupJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup tasks.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListSupabaseBackupJobsResponseBodyItems> Items { get; set; }
        public class ListSupabaseBackupJobsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The ID of the backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("BackupJobId")]
            [Validation(Required=false)]
            public string BackupJobId { get; set; }

            /// <summary>
            /// <para>The backup mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Automated</b>: automatic backup</description></item>
            /// <item><description><b>Manual</b>: manual backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Automated</para>
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// <para>The status of the backup task. Valid statuses include: schedule (waiting to be scheduled) and backup (in progress).</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup</para>
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// <para>The progress percentage of the backup task, such as 0%. This value may be an empty string when the task is in the schedule (waiting to be scheduled) state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0%</para>
            /// </summary>
            [NameInMap("Process")]
            [Validation(Required=false)]
            public string Process { get; set; }

            /// <summary>
            /// <para>The start time of the backup task. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format. This value may be an empty string when the task is in the schedule (waiting to be scheduled) state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-09T04:37:01Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page, which can be used as the NextToken parameter in the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
