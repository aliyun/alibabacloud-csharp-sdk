// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeRestoreRangeInfoResponseBody : TeaModel {
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
        /// <para>The information about the time ranges to which you can restore data.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeRestoreRangeInfoResponseBodyItems Items { get; set; }
        public class DescribeRestoreRangeInfoResponseBodyItems : TeaModel {
            [NameInMap("DBSRecoverRange")]
            [Validation(Required=false)]
            public List<DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRange> DBSRecoverRange { get; set; }
            public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRange : TeaModel {
                /// <summary>
                /// <para>The beginning of the time range to which you can restore data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1646760282000</para>
                /// </summary>
                [NameInMap("BeginTimestampForRestore")]
                [Validation(Required=false)]
                public long? BeginTimestampForRestore { get; set; }

                /// <summary>
                /// <para>The end of the time range to which you can restore data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1646760308000</para>
                /// </summary>
                [NameInMap("EndTimestampForRestore")]
                [Validation(Required=false)]
                public long? EndTimestampForRestore { get; set; }

                /// <summary>
                /// <para>If the value of the RangeType parameter is point, this parameter is returned. The value of this parameter describes information about all backup points in the time range.</para>
                /// </summary>
                [NameInMap("FullBackupList")]
                [Validation(Required=false)]
                public DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupList FullBackupList { get; set; }
                public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupList : TeaModel {
                    [NameInMap("FullBackupDetail")]
                    [Validation(Required=false)]
                    public List<DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupListFullBackupDetail> FullBackupDetail { get; set; }
                    public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupListFullBackupDetail : TeaModel {
                        /// <summary>
                        /// <para>The ID of the backup set.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qecnsxkd****</para>
                        /// </summary>
                        [NameInMap("BackupSetId")]
                        [Validation(Required=false)]
                        public string BackupSetId { get; set; }

                        /// <summary>
                        /// <para>The end time of the full backup task. Example: 1646760308000.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1646760308000</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        /// <summary>
                        /// <para>The start time of the full backup task. Example: 1646760282000.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1646760282000</para>
                        /// </summary>
                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the time range to which you can restore data.</para>
                /// <list type="bullet">
                /// <item><description><b>point</b>: The time range contains discrete points in time at which full backups were performed.</description></item>
                /// <item><description><b>range</b>: The time range is a period of time for which continuous backup is performed. You can specify a random point in time in the time range to restore data.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>point</para>
                /// </summary>
                [NameInMap("RangeType")]
                [Validation(Required=false)]
                public string RangeType { get; set; }

                /// <summary>
                /// <para>The ID of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-bp106x9tk2c91****</para>
                /// </summary>
                [NameInMap("SourceEndpointInstanceID")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceID { get; set; }

                /// <summary>
                /// <para>The location of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("SourceEndpointInstanceType")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2BD9DFC-6760-5F49-97C5-DA739E29****</para>
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

    }

}
