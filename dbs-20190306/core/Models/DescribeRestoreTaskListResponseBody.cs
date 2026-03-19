// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreTaskListResponseBody : TeaModel {
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
        public DescribeRestoreTaskListResponseBodyItems Items { get; set; }
        public class DescribeRestoreTaskListResponseBodyItems : TeaModel {
            [NameInMap("RestoreTaskDetail")]
            [Validation(Required=false)]
            public List<DescribeRestoreTaskListResponseBodyItemsRestoreTaskDetail> RestoreTaskDetail { get; set; }
            public class DescribeRestoreTaskListResponseBodyItemsRestoreTaskDetail : TeaModel {
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

                [NameInMap("BackupPlanId")]
                [Validation(Required=false)]
                public string BackupPlanId { get; set; }

                [NameInMap("BackupSetId")]
                [Validation(Required=false)]
                public string BackupSetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("BackupSourceOssRegion")]
                [Validation(Required=false)]
                public string BackupSourceOssRegion { get; set; }

                [NameInMap("ContinuousRestoreProgress")]
                [Validation(Required=false)]
                public int? ContinuousRestoreProgress { get; set; }

                [NameInMap("CrossAliyunId")]
                [Validation(Required=false)]
                public string CrossAliyunId { get; set; }

                [NameInMap("CrossRoleName")]
                [Validation(Required=false)]
                public string CrossRoleName { get; set; }

                [NameInMap("DestinationEndpointDatabaseName")]
                [Validation(Required=false)]
                public string DestinationEndpointDatabaseName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DestinationEndpointEnableSsl")]
                [Validation(Required=false)]
                public string DestinationEndpointEnableSsl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("DestinationEndpointHost")]
                [Validation(Required=false)]
                public string DestinationEndpointHost { get; set; }

                [NameInMap("DestinationEndpointInstanceID")]
                [Validation(Required=false)]
                public string DestinationEndpointInstanceID { get; set; }

                [NameInMap("DestinationEndpointInstanceType")]
                [Validation(Required=false)]
                public string DestinationEndpointInstanceType { get; set; }

                [NameInMap("DestinationEndpointIpPort")]
                [Validation(Required=false)]
                public string DestinationEndpointIpPort { get; set; }

                [NameInMap("DestinationEndpointOracleSID")]
                [Validation(Required=false)]
                public string DestinationEndpointOracleSID { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("DestinationEndpointPort")]
                [Validation(Required=false)]
                public string DestinationEndpointPort { get; set; }

                [NameInMap("DestinationEndpointRegion")]
                [Validation(Required=false)]
                public string DestinationEndpointRegion { get; set; }

                [NameInMap("DestinationEndpointUserName")]
                [Validation(Required=false)]
                public string DestinationEndpointUserName { get; set; }

                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

                [NameInMap("FullDataRestoreProgress")]
                [Validation(Required=false)]
                public int? FullDataRestoreProgress { get; set; }

                [NameInMap("FullStruAfterRestoreProgress")]
                [Validation(Required=false)]
                public int? FullStruAfterRestoreProgress { get; set; }

                [NameInMap("FullStruforeRestoreProgress")]
                [Validation(Required=false)]
                public int? FullStruforeRestoreProgress { get; set; }

                [NameInMap("PhysicalBackupRecoverProgress")]
                [Validation(Required=false)]
                public int? PhysicalBackupRecoverProgress { get; set; }

                [NameInMap("PhysicalDatabaseOnlineProgress")]
                [Validation(Required=false)]
                public int? PhysicalDatabaseOnlineProgress { get; set; }

                [NameInMap("PhysicalFullAndIncrementBackupRecoverProgress")]
                [Validation(Required=false)]
                public int? PhysicalFullAndIncrementBackupRecoverProgress { get; set; }

                [NameInMap("PhysicalFullBackupRecoverProgress")]
                [Validation(Required=false)]
                public int? PhysicalFullBackupRecoverProgress { get; set; }

                [NameInMap("PhysicalIncrementBackupRecoverProgress")]
                [Validation(Required=false)]
                public int? PhysicalIncrementBackupRecoverProgress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EXIST_INSTANCE</para>
                /// </summary>
                [NameInMap("RestoreDestinationMode")]
                [Validation(Required=false)]
                public string RestoreDestinationMode { get; set; }

                [NameInMap("RestoreDir")]
                [Validation(Required=false)]
                public string RestoreDir { get; set; }

                [NameInMap("RestoreObjects")]
                [Validation(Required=false)]
                public string RestoreObjects { get; set; }

                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                [NameInMap("RestoreTaskCreateTime")]
                [Validation(Required=false)]
                public long? RestoreTaskCreateTime { get; set; }

                [NameInMap("RestoreTaskFinishTime")]
                [Validation(Required=false)]
                public long? RestoreTaskFinishTime { get; set; }

                [NameInMap("RestoreTaskId")]
                [Validation(Required=false)]
                public string RestoreTaskId { get; set; }

                [NameInMap("RestoreTaskName")]
                [Validation(Required=false)]
                public string RestoreTaskName { get; set; }

                [NameInMap("RestoreTime")]
                [Validation(Required=false)]
                public long? RestoreTime { get; set; }

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
        /// <para>9C397502-B4F2-4E22-AD97-C81F0049F3F3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of restore jobs.</para>
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
