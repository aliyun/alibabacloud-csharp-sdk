// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListRestoreTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates the read position returned by the current call. An empty value means all data has been read.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>464C8CB6-A548-5206-B83C-D32A8E43EC21</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of restore tasks.</para>
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-09-07T11:37:37Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The expiration time of the service instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-27T18:00:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-07T12:16:16Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The ID of the restore task.</para>
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
            /// <para>The time when the update started.</para>
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
            /// <item><description>Restoring</description></item>
            /// <item><description>Restored</description></item>
            /// <item><description>RestoreFailed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Restoring</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The description of the service instance deployment information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-xxxx  failed, error message: error</para>
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

        }

        /// <summary>
        /// <para>Total data count under the current request conditions (optional; not returned by default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
