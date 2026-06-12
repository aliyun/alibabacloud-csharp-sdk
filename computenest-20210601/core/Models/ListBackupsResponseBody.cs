// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backups.</para>
        /// </summary>
        [NameInMap("Backups")]
        [Validation(Required=false)]
        public List<ListBackupsResponseBodyBackups> Backups { get; set; }
        public class ListBackupsResponseBodyBackups : TeaModel {
            /// <summary>
            /// <para>The backup ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup-4e13aa8ca6a34150addd</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The backup mode. The return value is:</para>
            /// <list type="bullet">
            /// <item><description><b>Manual</b>: The backup is created manually.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// <para>The time when the backup was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-03T19:54:38+08:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the backup ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-15T02:24:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The time when the backup was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-09-03T19:54:38+08:00</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The retention period in days. Backups are deleted after the retention period expires. By default, this parameter is empty, which means that the backups do not expire.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public int? RetentionDays { get; set; }

            /// <summary>
            /// <para>The service instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>si-7b6138dfce1e4c41ab71</para>
            /// </summary>
            [NameInMap("ServiceInstanceId")]
            [Validation(Required=false)]
            public string ServiceInstanceId { get; set; }

            /// <summary>
            /// <para>The time when the backup started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// <list type="bullet">
            /// <item><description><para>Creating: The backup is being created.</para>
            /// </description></item>
            /// <item><description><para>Created: The backup is created.</para>
            /// </description></item>
            /// <item><description><para>CreateFailed: The backup failed to be created.</para>
            /// </description></item>
            /// <item><description><para>Deleting: The backup is being deleted.</para>
            /// </description></item>
            /// <item><description><para>Deleted: The backup is deleted.</para>
            /// </description></item>
            /// <item><description><para>DeleteFailed: The backup failed to be deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The details of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Disk i-xxxx backup failed, error message: error</para>
            /// </summary>
            [NameInMap("StatusDetail")]
            [Validation(Required=false)]
            public string StatusDetail { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAc3HCuYhJi/wvpk4xOr0VLYoaeZA6xVdkCrmG9EmGshtmECUGpq9Qm7x5vQkpz9NXH0XzUc9t4Kxaf3UtuPY4a0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB58FE53-ED8F-5D12-9746-CD3A5F463D95</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
