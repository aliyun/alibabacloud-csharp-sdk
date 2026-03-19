// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeFullBackupListResponseBody : TeaModel {
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
        public DescribeFullBackupListResponseBodyItems Items { get; set; }
        public class DescribeFullBackupListResponseBodyItems : TeaModel {
            [NameInMap("FullBackupFile")]
            [Validation(Required=false)]
            public List<DescribeFullBackupListResponseBodyItemsFullBackupFile> FullBackupFile { get; set; }
            public class DescribeFullBackupListResponseBodyItemsFullBackupFile : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TESTGATEWAY</para>
                /// </summary>
                [NameInMap("BackupGatewayIdentifier")]
                [Validation(Required=false)]
                public string BackupGatewayIdentifier { get; set; }

                [NameInMap("BackupObjects")]
                [Validation(Required=false)]
                public string BackupObjects { get; set; }

                [NameInMap("BackupSetExpiredTime")]
                [Validation(Required=false)]
                public long? BackupSetExpiredTime { get; set; }

                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2xxx7778xxxxxxxxxx</para>
                /// </summary>
                [NameInMap("CrossAliyunId")]
                [Validation(Required=false)]
                public string CrossAliyunId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ram-for-dbs</para>
                /// </summary>
                [NameInMap("CrossRoleName")]
                [Validation(Required=false)]
                public string CrossRoleName { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LogicalFullBackupProgress")]
                [Validation(Required=false)]
                public int? LogicalFullBackupProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LogicalStructureBackupProgress")]
                [Validation(Required=false)]
                public int? LogicalStructureBackupProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SourceEndpointEnableSsl")]
                [Validation(Required=false)]
                public string SourceEndpointEnableSsl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("SourceEndpointHost")]
                [Validation(Required=false)]
                public string SourceEndpointHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rm-testxx</para>
                /// </summary>
                [NameInMap("SourceEndpointInstanceId")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("SourceEndpointInstanceType")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceType { get; set; }

                [NameInMap("SourceEndpointIpPort")]
                [Validation(Required=false)]
                public string SourceEndpointIpPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("SourceEndpointPort")]
                [Validation(Required=false)]
                public string SourceEndpointPort { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("SourceEndpointRegion")]
                [Validation(Required=false)]
                public string SourceEndpointRegion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dbs_backup</para>
                /// </summary>
                [NameInMap("SourceEndpointUserName")]
                [Validation(Required=false)]
                public string SourceEndpointUserName { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>encrypted</para>
                /// </summary>
                [NameInMap("StorageEncryptMethod")]
                [Validation(Required=false)]
                public string StorageEncryptMethod { get; set; }

                [NameInMap("StorageMethod")]
                [Validation(Required=false)]
                public string StorageMethod { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>636BC118-6080-4119-A6B5-C199CEC1037D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The operation succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The operation failed.</para>
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
        /// <para>The total number of full backup jobs.</para>
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
