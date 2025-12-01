// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupSetDownloadTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backup schedules.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupSetDownloadTaskListResponseBodyItems Items { get; set; }
        public class DescribeBackupSetDownloadTaskListResponseBodyItems : TeaModel {
            [NameInMap("BackupSetDownloadTaskDetail")]
            [Validation(Required=false)]
            public List<DescribeBackupSetDownloadTaskListResponseBodyItemsBackupSetDownloadTaskDetail> BackupSetDownloadTaskDetail { get; set; }
            public class DescribeBackupSetDownloadTaskListResponseBodyItemsBackupSetDownloadTaskDetail : TeaModel {
                /// <summary>
                /// <para>The backup gateway that is used to download the backup set. This parameter is available only if the value of the BackupSetDownloadWay parameter is auto.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
                /// </summary>
                [NameInMap("BackupGatewayId")]
                [Validation(Required=false)]
                public long? BackupGatewayId { get; set; }

                /// <summary>
                /// <para>The ID of the backup schedule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qhnuhyw3****</para>
                /// </summary>
                [NameInMap("BackupPlanId")]
                [Validation(Required=false)]
                public string BackupPlanId { get; set; }

                /// <summary>
                /// <para>The code of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql-bin.00XXXX</para>
                /// </summary>
                [NameInMap("BackupSetCode")]
                [Validation(Required=false)]
                public string BackupSetCode { get; set; }

                /// <summary>
                /// <para>The format in which the backup set is downloaded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Native</b></description></item>
                /// <item><description><b>SQL</b></description></item>
                /// <item><description><b>CSV</b></description></item>
                /// <item><description><b>JSON</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Native</para>
                /// </summary>
                [NameInMap("BackupSetDataFormat")]
                [Validation(Required=false)]
                public string BackupSetDataFormat { get; set; }

                /// <summary>
                /// <para>The size of the data in the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>237837</para>
                /// </summary>
                [NameInMap("BackupSetDataSize")]
                [Validation(Required=false)]
                public long? BackupSetDataSize { get; set; }

                /// <summary>
                /// <para>The type of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("BackupSetDbType")]
                [Validation(Required=false)]
                public string BackupSetDbType { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the backup set download task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1642044001000</para>
                /// </summary>
                [NameInMap("BackupSetDownloadCreateTime")]
                [Validation(Required=false)]
                public long? BackupSetDownloadCreateTime { get; set; }

                /// <summary>
                /// <para>The server directory to which the backup set is downloaded.</para>
                /// <remarks>
                /// <para>This parameter is available only if the value of the BackupSetDownloadWay parameter is auto.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
                /// </summary>
                [NameInMap("BackupSetDownloadDir")]
                [Validation(Required=false)]
                public string BackupSetDownloadDir { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates when the backup set download task is complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1642044013000</para>
                /// </summary>
                [NameInMap("BackupSetDownloadFinishTime")]
                [Validation(Required=false)]
                public long? BackupSetDownloadFinishTime { get; set; }

                /// <summary>
                /// <para>The public download URL of the backup set.</para>
                /// <remarks>
                /// <para>This parameter is available only if the value of the BackupSetDownloadWay parameter is manual and the conversion is complete.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;//dbs-137XXXX-cn-hangzhou-1hr5cpbtmXXXX.oss-cn-hangzhou.example&quot;</para>
                /// </summary>
                [NameInMap("BackupSetDownloadInternetUrl")]
                [Validation(Required=false)]
                public string BackupSetDownloadInternetUrl { get; set; }

                /// <summary>
                /// <para>The internal download URL of the backup set.</para>
                /// <remarks>
                /// <para>This parameter is available only if the value of the BackupSetDownloadWay parameter is manual and the conversion is complete.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;//dbs-13XXXX-cn-hangzhou-1hr5cpbtmXXXX.oss-cn-hangzhou-internal.example&quot;</para>
                /// </summary>
                [NameInMap("BackupSetDownloadIntranetUrl")]
                [Validation(Required=false)]
                public string BackupSetDownloadIntranetUrl { get; set; }

                /// <summary>
                /// <para>The status of the backup set download task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>checking</b>: The backup set download task is being prechecked.</description></item>
                /// <item><description><b>init</b>: The backup set download task is not started and fails to pass the precheck.</description></item>
                /// <item><description><b>check_pass</b>: The backup set download task passes the precheck.</description></item>
                /// <item><description><b>pause</b>: The backup set download task is paused.</description></item>
                /// <item><description><b>schedule</b>: The backup set download task is waiting to be scheduled</description></item>
                /// <item><description><b>running</b>: The backup set download task is running.</description></item>
                /// <item><description><b>stop</b>: The backup set download task fails.</description></item>
                /// <item><description><b>finish</b>: The backup set download task is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>finish</para>
                /// </summary>
                [NameInMap("BackupSetDownloadStatus")]
                [Validation(Required=false)]
                public string BackupSetDownloadStatus { get; set; }

                /// <summary>
                /// <para>The type of the destination server to which the backup set is downloaded.</para>
                /// <remarks>
                /// <para>This parameter is available only if the value of the BackupSetDownloadWay parameter is auto. A value of agent indicates a server on which a backup gateway is installed.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
                /// </summary>
                [NameInMap("BackupSetDownloadTargetType")]
                [Validation(Required=false)]
                public string BackupSetDownloadTargetType { get; set; }

                /// <summary>
                /// <para>The ID of the backup set download task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>urxgrxt7****</para>
                /// </summary>
                [NameInMap("BackupSetDownloadTaskId")]
                [Validation(Required=false)]
                public string BackupSetDownloadTaskId { get; set; }

                /// <summary>
                /// <para>The name of the backup set download task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1h7za2yws****-ManualCont</para>
                /// </summary>
                [NameInMap("BackupSetDownloadTaskName")]
                [Validation(Required=false)]
                public string BackupSetDownloadTaskName { get; set; }

                /// <summary>
                /// <para>The method in which the backup set is downloaded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>manual</b>: The backup set is manually downloaded.</description></item>
                /// <item><description><b>auto</b>: The backup set is automatically downloaded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>manual</para>
                /// </summary>
                [NameInMap("BackupSetDownloadWay")]
                [Validation(Required=false)]
                public string BackupSetDownloadWay { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1h7za2yws****</para>
                /// </summary>
                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                /// <summary>
                /// <para>The type of the backup set task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cbs_backup_sub_full</b>: logical full backup set download task</description></item>
                /// <item><description><b>cbs_backup_sub_cont</b>: logical incremental backup set download task</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cbs_backup_sub_cont</para>
                /// </summary>
                [NameInMap("BackupSetJobType")]
                [Validation(Required=false)]
                public string BackupSetJobType { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.IndexOutOfBoundsException.</para>
                /// </summary>
                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DC3D286-E0E6-5988-A558-2184984B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of backup set download tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
