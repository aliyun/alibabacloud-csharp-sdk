// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupPlanListResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameterValid</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupPlanListResponseBodyItems Items { get; set; }
        public class DescribeBackupPlanListResponseBodyItems : TeaModel {
            [NameInMap("BackupPlanDetail")]
            [Validation(Required=false)]
            public List<DescribeBackupPlanListResponseBodyItemsBackupPlanDetail> BackupPlanDetail { get; set; }
            public class DescribeBackupPlanListResponseBodyItemsBackupPlanDetail : TeaModel {
                [NameInMap("BackupGatewayId")]
                [Validation(Required=false)]
                public long? BackupGatewayId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TESTGATEWAY</para>
                /// </summary>
                [NameInMap("BackupGatewayIdentifier")]
                [Validation(Required=false)]
                public string BackupGatewayIdentifier { get; set; }

                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                [NameInMap("BackupObjects")]
                [Validation(Required=false)]
                public string BackupObjects { get; set; }

                [NameInMap("BackupPeriod")]
                [Validation(Required=false)]
                public string BackupPeriod { get; set; }

                [NameInMap("BackupPlanCreateTime")]
                [Validation(Required=false)]
                public long? BackupPlanCreateTime { get; set; }

                [NameInMap("BackupPlanId")]
                [Validation(Required=false)]
                public string BackupPlanId { get; set; }

                [NameInMap("BackupPlanName")]
                [Validation(Required=false)]
                public string BackupPlanName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("BackupPlanRegion")]
                [Validation(Required=false)]
                public string BackupPlanRegion { get; set; }

                [NameInMap("BackupPlanStatus")]
                [Validation(Required=false)]
                public string BackupPlanStatus { get; set; }

                [NameInMap("BackupRetentionPeriod")]
                [Validation(Required=false)]
                public int? BackupRetentionPeriod { get; set; }

                [NameInMap("BackupSetDownloadDir")]
                [Validation(Required=false)]
                public string BackupSetDownloadDir { get; set; }

                [NameInMap("BackupSetDownloadFullDataFormat")]
                [Validation(Required=false)]
                public string BackupSetDownloadFullDataFormat { get; set; }

                [NameInMap("BackupSetDownloadGatewayId")]
                [Validation(Required=false)]
                public long? BackupSetDownloadGatewayId { get; set; }

                [NameInMap("BackupSetDownloadIncrementDataFormat")]
                [Validation(Required=false)]
                public string BackupSetDownloadIncrementDataFormat { get; set; }

                [NameInMap("BackupSetDownloadTargetType")]
                [Validation(Required=false)]
                public string BackupSetDownloadTargetType { get; set; }

                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                [NameInMap("BackupStorageType")]
                [Validation(Required=false)]
                public string BackupStorageType { get; set; }

                [NameInMap("BeginTimestampForRestore")]
                [Validation(Required=false)]
                public long? BeginTimestampForRestore { get; set; }

                [NameInMap("CrossAliyunId")]
                [Validation(Required=false)]
                public string CrossAliyunId { get; set; }

                [NameInMap("CrossRoleName")]
                [Validation(Required=false)]
                public string CrossRoleName { get; set; }

                [NameInMap("DatabaseType")]
                [Validation(Required=false)]
                public string DatabaseType { get; set; }

                [NameInMap("DuplicationArchivePeriod")]
                [Validation(Required=false)]
                public int? DuplicationArchivePeriod { get; set; }

                [NameInMap("DuplicationInfrequentAccessPeriod")]
                [Validation(Required=false)]
                public int? DuplicationInfrequentAccessPeriod { get; set; }

                [NameInMap("EnableBackupLog")]
                [Validation(Required=false)]
                public bool? EnableBackupLog { get; set; }

                [NameInMap("EnableMysqlPhysicalBackupBinLog")]
                [Validation(Required=false)]
                public bool? EnableMysqlPhysicalBackupBinLog { get; set; }

                [NameInMap("EndTimestampForRestore")]
                [Validation(Required=false)]
                public long? EndTimestampForRestore { get; set; }

                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("IncrementBackupRetentionPeriod")]
                [Validation(Required=false)]
                public string IncrementBackupRetentionPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("IncrementDuplicationArchivePeriod")]
                [Validation(Required=false)]
                public string IncrementDuplicationArchivePeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("IncrementDuplicationInfrequentAccessPeriod")]
                [Validation(Required=false)]
                public string IncrementDuplicationInfrequentAccessPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PREPAY</para>
                /// </summary>
                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1764051253000</para>
                /// </summary>
                [NameInMap("InstanceExpiredTimestamp")]
                [Validation(Required=false)]
                public long? InstanceExpiredTimestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("LogBackupRetentionPeriod")]
                [Validation(Required=false)]
                public string LogBackupRetentionPeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("LogDuplicationArchivePeriod")]
                [Validation(Required=false)]
                public string LogDuplicationArchivePeriod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>365</para>
                /// </summary>
                [NameInMap("LogDuplicationInfrequentAccessPeriod")]
                [Validation(Required=false)]
                public string LogDuplicationInfrequentAccessPeriod { get; set; }

                [NameInMap("OSSBucketName")]
                [Validation(Required=false)]
                public string OSSBucketName { get; set; }

                [NameInMap("OSSBucketRegion")]
                [Validation(Required=false)]
                public string OSSBucketRegion { get; set; }

                [NameInMap("OpenBackupSetAutoDownload")]
                [Validation(Required=false)]
                public bool? OpenBackupSetAutoDownload { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SourceEndpointDatabaseName")]
                [Validation(Required=false)]
                public string SourceEndpointDatabaseName { get; set; }

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

                [NameInMap("SourceEndpointInstanceID")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceID { get; set; }

                [NameInMap("SourceEndpointInstanceType")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceType { get; set; }

                [NameInMap("SourceEndpointIpPort")]
                [Validation(Required=false)]
                public string SourceEndpointIpPort { get; set; }

                [NameInMap("SourceEndpointOracleSID")]
                [Validation(Required=false)]
                public string SourceEndpointOracleSID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("SourceEndpointPort")]
                [Validation(Required=false)]
                public string SourceEndpointPort { get; set; }

                [NameInMap("SourceEndpointRegion")]
                [Validation(Required=false)]
                public string SourceEndpointRegion { get; set; }

                [NameInMap("SourceEndpointUserName")]
                [Validation(Required=false)]
                public string SourceEndpointUserName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>encrypted</para>
                /// </summary>
                [NameInMap("StorageEncryptMethod")]
                [Validation(Required=false)]
                public string StorageEncryptMethod { get; set; }

            }

        }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F1888AC-1138-4995-B9FE-D2734F61C058</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of backup plans.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
