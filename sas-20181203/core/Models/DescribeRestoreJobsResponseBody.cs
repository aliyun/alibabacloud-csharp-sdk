// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRestoreJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeRestoreJobsResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeRestoreJobsResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of restoration tasks returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page. Default value: <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of restoration tasks returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED92280-4363-57D3-A4D3-4D3FBC99B29F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the restoration tasks.</para>
        /// </summary>
        [NameInMap("RestoreJobs")]
        [Validation(Required=false)]
        public List<DescribeRestoreJobsResponseBodyRestoreJobs> RestoreJobs { get; set; }
        public class DescribeRestoreJobsResponseBodyRestoreJobs : TeaModel {
            /// <summary>
            /// <para>The size of backup data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public long? ActualBytes { get; set; }

            /// <summary>
            /// <para>The total size of data that is restored. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("BytesDone")]
            [Validation(Required=false)]
            public long? BytesDone { get; set; }

            /// <summary>
            /// <para>The total size of data that you want to restore. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// <para>The ID of the anti-ransomware agent that is used to perform the restoration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000frxwusjauhp9ajpu6</para>
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// <para>The timestamp when the restoration task is complete. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1583289054000</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the restoration task is created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1583289052000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The duration of the restoration task. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The number of the restoration tasks on which errors occur.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// <para>The name of the CSV file. The CSV file contains the files that fail to be restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-000f4wxm8f7gur6g2otm.csv</para>
            /// </summary>
            [NameInMap("ErrorFile")]
            [Validation(Required=false)]
            public string ErrorFile { get; set; }

            /// <summary>
            /// <para>The URL to download the CSV file. The CSV file contains the files that fail to be restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/home/user&quot;]</para>
            /// </summary>
            [NameInMap("ErrorFileUrl")]
            [Validation(Required=false)]
            public string ErrorFileUrl { get; set; }

            /// <summary>
            /// <para>The error code that is returned for the restoration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NONE</para>
            /// </summary>
            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

            /// <summary>
            /// <para>The timestamp when the in-progress restoration task is expected to be complete. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1583299054</para>
            /// </summary>
            [NameInMap("Eta")]
            [Validation(Required=false)]
            public long? Eta { get; set; }

            /// <summary>
            /// <para>The directory excluded from the anti-ransomware policy. The value is the directory that you specify to skip protection when you create the anti-ransomware policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/home/user&quot;]</para>
            /// </summary>
            [NameInMap("Excludes")]
            [Validation(Required=false)]
            public string Excludes { get; set; }

            /// <summary>
            /// <para>The return value of the restoration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExitCode")]
            [Validation(Required=false)]
            public string ExitCode { get; set; }

            /// <summary>
            /// <para>The time when the restoration task is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-25T19:11Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the restoration task is updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-25T19:11Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The directory in which the restored file is stored. The value is the directory that you specify for protection when you create the anti-ransomware policy</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/root/disk-uuid-test&quot;,&quot;/root/install.sh&quot;]</para>
            /// </summary>
            [NameInMap("Includes")]
            [Validation(Required=false)]
            public string Includes { get; set; }

            /// <summary>
            /// <para>The ID of the server whose data you want to restore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp12xnvdax6307gw****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the server whose data you want to restore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win2012-01</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the server whose data you want to restore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The internal IP address of the server whose data you want to restore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.1.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The number of files that are restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ItemsDone")]
            [Validation(Required=false)]
            public long? ItemsDone { get; set; }

            /// <summary>
            /// <para>The total number of files that need to be restored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ItemsTotal")]
            [Validation(Required=false)]
            public long? ItemsTotal { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The progress of the restoration task in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0ED92280-4363-57D3-A4D3-4D3FBC99B29F</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The ID of the restoration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>r-000gmcypy5dyf9ey3uv7</para>
            /// </summary>
            [NameInMap("RestoreId")]
            [Validation(Required=false)]
            public string RestoreId { get; set; }

            /// <summary>
            /// <para>The name of the restoration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Restore</para>
            /// </summary>
            [NameInMap("RestoreName")]
            [Validation(Required=false)]
            public string RestoreName { get; set; }

            /// <summary>
            /// <para>The type of the file that is restored. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS_FILE</b>: files on Elastic Compute Service (ECS) instances</description></item>
            /// <item><description><b>FILE</b>: files on servers in data centers</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS_FILE</para>
            /// </summary>
            [NameInMap("RestoreType")]
            [Validation(Required=false)]
            public string RestoreType { get; set; }

            /// <summary>
            /// <para>The hash value of the snapshot that stores backup data when the data is backed up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a3992de83f529b844135fe795d949181735a7d20e0ac8539485c61b7983e618f</para>
            /// </summary>
            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            /// <summary>
            /// <para>The hash value ID of the snapshot that stores backup data when the data is backed up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-000gmcypy5dy54e39yny</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// <para>The version of the backup data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-03-03 18:00</para>
            /// </summary>
            [NameInMap("SnapshotVersion")]
            [Validation(Required=false)]
            public string SnapshotVersion { get; set; }

            /// <summary>
            /// <para>The restored content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;/home/admin&quot;,&quot;\\\\servername\\sharename&quot;]</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ID of the anti-ransomware agent that is used to back up data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-000gmcypy5dyf9ey3uv7</para>
            /// </summary>
            [NameInMap("SourceClientId")]
            [Validation(Required=false)]
            public string SourceClientId { get; set; }

            /// <summary>
            /// <para>The speed at which data is restored. Unit: byte/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25766558</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public long? Speed { get; set; }

            /// <summary>
            /// <para>The status of the restoration task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RUNNING</b>: The task is running.</description></item>
            /// <item><description><b>COMPLETE</b>: The task is complete.</description></item>
            /// <item><description><b>FAILED</b>: The task fails.</description></item>
            /// <item><description><b>CANCELING</b>: The task is being canceled.</description></item>
            /// <item><description><b>CANCELED</b>: The task is canceled.</description></item>
            /// <item><description><b>PARTIAL_COMPLETE</b>: The task is partially successful.</description></item>
            /// <item><description><b>CREATED</b>: The task was created but is not run.</description></item>
            /// <item><description><b>EXPIRED</b>: The task is not updated.</description></item>
            /// <item><description><b>QUEUED</b>: The task is waiting to be run.</description></item>
            /// <item><description><b>CLIENT_DELETED</b>: The task fails because the anti-ransomware agent is uninstalled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The folder to which the backup data is restored. After you create the restoration task, the backup data is restored to the specified folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The timestamp when the restoration task was last updated. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1583289054000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The UUID of the server whose data you want to restore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6E3DABB6-3F6A-40DB-9492-2C8B59C****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the backup vault in which the backup data is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v-000b0v0jqzmse2yz06zw</para>
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the backup vault resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("VaultRegionId")]
            [Validation(Required=false)]
            public string VaultRegionId { get; set; }

        }

    }

}
