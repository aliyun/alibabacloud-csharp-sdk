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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupSetDownloadTaskListResponseBodyItems Items { get; set; }
        public class DescribeBackupSetDownloadTaskListResponseBodyItems : TeaModel {
            [NameInMap("BackupSetDownloadTaskDetail")]
            [Validation(Required=false)]
            public List<DescribeBackupSetDownloadTaskListResponseBodyItemsBackupSetDownloadTaskDetail> BackupSetDownloadTaskDetail { get; set; }
            public class DescribeBackupSetDownloadTaskListResponseBodyItemsBackupSetDownloadTaskDetail : TeaModel {
                [NameInMap("BackupGatewayId")]
                [Validation(Required=false)]
                public long? BackupGatewayId { get; set; }

                [NameInMap("BackupPlanId")]
                [Validation(Required=false)]
                public string BackupPlanId { get; set; }

                [NameInMap("BackupSetCode")]
                [Validation(Required=false)]
                public string BackupSetCode { get; set; }

                [NameInMap("BackupSetDataFormat")]
                [Validation(Required=false)]
                public string BackupSetDataFormat { get; set; }

                [NameInMap("BackupSetDataSize")]
                [Validation(Required=false)]
                public long? BackupSetDataSize { get; set; }

                [NameInMap("BackupSetDbType")]
                [Validation(Required=false)]
                public string BackupSetDbType { get; set; }

                [NameInMap("BackupSetDownloadCreateTime")]
                [Validation(Required=false)]
                public long? BackupSetDownloadCreateTime { get; set; }

                [NameInMap("BackupSetDownloadDir")]
                [Validation(Required=false)]
                public string BackupSetDownloadDir { get; set; }

                [NameInMap("BackupSetDownloadFinishTime")]
                [Validation(Required=false)]
                public long? BackupSetDownloadFinishTime { get; set; }

                [NameInMap("BackupSetDownloadInternetUrl")]
                [Validation(Required=false)]
                public string BackupSetDownloadInternetUrl { get; set; }

                [NameInMap("BackupSetDownloadIntranetUrl")]
                [Validation(Required=false)]
                public string BackupSetDownloadIntranetUrl { get; set; }

                [NameInMap("BackupSetDownloadStatus")]
                [Validation(Required=false)]
                public string BackupSetDownloadStatus { get; set; }

                [NameInMap("BackupSetDownloadTargetType")]
                [Validation(Required=false)]
                public string BackupSetDownloadTargetType { get; set; }

                [NameInMap("BackupSetDownloadTaskId")]
                [Validation(Required=false)]
                public string BackupSetDownloadTaskId { get; set; }

                [NameInMap("BackupSetDownloadTaskName")]
                [Validation(Required=false)]
                public string BackupSetDownloadTaskName { get; set; }

                [NameInMap("BackupSetDownloadWay")]
                [Validation(Required=false)]
                public string BackupSetDownloadWay { get; set; }

                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                [NameInMap("BackupSetJobType")]
                [Validation(Required=false)]
                public string BackupSetJobType { get; set; }

                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6DC3D286-E0E6-5988-A558-2184984B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of download records for backup sets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
