// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ListUserBackupFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of user backup file details.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<ListUserBackupFilesResponseBodyRecords> Records { get; set; }
        public class ListUserBackupFilesResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The user backup ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b-kwwvr7v8t7of****</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The binary log file information in the backup file. This parameter is returned if incremental data exists during the backup process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;binlogPosition\&quot;:\&quot;154\&quot;,\&quot;binlogFile\&quot;:\&quot;0.000002\&quot;}</para>
            /// </summary>
            [NameInMap("BinlogInfo")]
            [Validation(Required=false)]
            public string BinlogInfo { get; set; }

            /// <summary>
            /// <para>The comment of the user backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BackupTest</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The time when the user backup import started. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623231084000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The database engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The time when the user backup was successfully imported. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623231750000</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The time when the user backup import was completed. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1623231750000</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket in which the user backup file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BackupTest</para>
            /// </summary>
            [NameInMap("OssBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// <para>The metadata of the user backup file. For more information, see <a href="https://help.aliyun.com/document_detail/31859.html">Manage object metadata</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Accept-Ranges\&quot;:\&quot;bytes\&quot;,\&quot;Connection\&quot;:\&quot;keep-alive\&quot;,\&quot;Content-Length\&quot;:81014337,\&quot;Content-Type\&quot;:\&quot;application/octet-stream\&quot;,\&quot;Date\&quot;:1623309548000,\&quot;ETag\&quot;:\&quot;889FE9E5FCEBFE4781829488A352863B-1\&quot;,\&quot;Last-Modified\&quot;:1622186844000,\&quot;Server\&quot;:\&quot;AliyunOSS\&quot;,\&quot;x-oss-hash-crc64ecma\&quot;:\&quot;5793608435727323129\&quot;,\&quot;x-oss-object-type\&quot;:\&quot;Multipart\&quot;,\&quot;x-oss-request-id\&quot;:\&quot;60C1BCEC92572F37318BD499\&quot;,\&quot;x-oss-server-time\&quot;:\&quot;166\&quot;,\&quot;x-oss-storage-class\&quot;:\&quot;Standard\&quot;}</para>
            /// </summary>
            [NameInMap("OssFileMetaData")]
            [Validation(Required=false)]
            public string OssFileMetaData { get; set; }

            /// <summary>
            /// <para>The name of the user backup file in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>backup_qp.xb</para>
            /// </summary>
            [NameInMap("OssFileName")]
            [Validation(Required=false)]
            public string OssFileName { get; set; }

            /// <summary>
            /// <para>The path of the user backup file in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test/backup_qp.xb</para>
            /// </summary>
            [NameInMap("OssFilePath")]
            [Validation(Required=false)]
            public string OssFilePath { get; set; }

            /// <summary>
            /// <para>The size of the user backup file in OSS. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>79115</para>
            /// </summary>
            [NameInMap("OssFileSize")]
            [Validation(Required=false)]
            public long? OssFileSize { get; set; }

            /// <summary>
            /// <para>The OSS download URL of the user backup file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https://<b><b>.oss-ap-</b></b>.aliyuncs.com/backup_qp.xb</para>
            /// </summary>
            [NameInMap("OssUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }

            /// <summary>
            /// <para>The reason why the user backup file failed to be imported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The storage space required to restore the user backup. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("RestoreSize")]
            [Validation(Required=false)]
            public string RestoreSize { get; set; }

            /// <summary>
            /// <para>The retention period of the user backup file. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public int? Retention { get; set; }

            /// <summary>
            /// <para>The status of the user backup file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Importing</b>: The backup is being imported.</description></item>
            /// <item><description><b>Failed</b>: The import failed.</description></item>
            /// <item><description><b>CheckSuccess</b>: The verification passed.</description></item>
            /// <item><description><b>BackupSuccess</b>: The import succeeded.</description></item>
            /// <item><description><b>Deleted</b>: The backup is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BackupSuccess</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The zone ID of the user backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD67C22F-64F3-4448-A9A8-D1606D242879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
