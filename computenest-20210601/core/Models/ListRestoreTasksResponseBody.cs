// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListRestoreTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>464C8CB6-A548-5206-B83C-D32A8E43EC21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of restore jobs.</para>
        /// </summary>
        [NameInMap("RestoreTasks")]
        [Validation(Required=false)]
        public List<ListRestoreTasksResponseBodyRestoreTasks> RestoreTasks { get; set; }
        public class ListRestoreTasksResponseBodyRestoreTasks : TeaModel {
            /// <summary>
            /// <para>The backup ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-728f128bf92c4e3da970</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-07T11:37:37Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the restore job ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-27T18:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the job was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-07T12:16:16Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the restore job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>restore-xxxxxx</para>
            /// </summary>
            [NameInMap("RestoreTaskId")]
            [Validation(Required=false)]
            public string RestoreTaskId { get; set; }

            /// <summary>
            /// <para>The ID of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-8c367c27c84e44a79d36</para>
            /// </summary>
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the restore job started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-27T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Restoring: The service instance is being restored.</para>
            /// </description></item>
            /// <item><description><para>Restored: The service instance was restored.</para>
            /// </description></item>
            /// <item><description><para>RestoreFailed: The service instance failed to be restored.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Restoring</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The details of the instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxx  failed, error message: error</para>
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that meet the filter criteria.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
