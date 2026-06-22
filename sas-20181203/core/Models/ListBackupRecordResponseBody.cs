// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBackupRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backup records.</para>
        /// </summary>
        [NameInMap("BackupRecordList")]
        [Validation(Required=false)]
        public List<ListBackupRecordResponseBodyBackupRecordList> BackupRecordList { get; set; }
        public class ListBackupRecordResponseBodyBackupRecordList : TeaModel {
            /// <summary>
            /// <para>The backup end time. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699600611000</para>
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public long? BackupEndTime { get; set; }

            /// <summary>
            /// <para>The backup task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a006f24d069843c88688672d74ee****</para>
            /// </summary>
            [NameInMap("BackupJobId")]
            [Validation(Required=false)]
            public string BackupJobId { get; set; }

            /// <summary>
            /// <para>The backup plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan-000c4tt43nolmx96****</para>
            /// </summary>
            [NameInMap("BackupPlanId")]
            [Validation(Required=false)]
            public string BackupPlanId { get; set; }

            /// <summary>
            /// <para>The backup start time. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699514211000</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public long? BackupStartTime { get; set; }

            /// <summary>
            /// <para>The backup task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BACKUP_COMPLETE</b>: backup succeeded</description></item>
            /// <item><description><b>BACKUP_FAILED</b>: backup failed</description></item>
            /// <item><description><b>PARTIAL_COMPLETE</b>: partial backup succeeded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BACKUP_COMPLETE</para>
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// <para>The anti-ransomware client ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-0002bgagelj3d2sc****</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The error code of the backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE_CACHE_NO_SPACE</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error details of the backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FILE_CACHE_NO_SPACE</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The ID of the server instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-wz9ikn44p46krnic****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>openapi</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.1</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.1</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The region ID of the backup service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The UUID of the server backed up by database anti-ransomware.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b93cccb9-f19f-4886-97fe-47df26ba****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListBackupRecordResponseBodyPageInfo PageInfo { get; set; }
        public class ListBackupRecordResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3956048F-9D73-5EDB-834B-4827BB48****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
