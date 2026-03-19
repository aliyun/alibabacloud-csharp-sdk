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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeRestoreRangeInfoResponseBodyItems Items { get; set; }
        public class DescribeRestoreRangeInfoResponseBodyItems : TeaModel {
            [NameInMap("DBSRecoverRange")]
            [Validation(Required=false)]
            public List<DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRange> DBSRecoverRange { get; set; }
            public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRange : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("BackupSourceHost")]
                [Validation(Required=false)]
                public string BackupSourceHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rm-testxx</para>
                /// </summary>
                [NameInMap("BackupSourceInstanceId")]
                [Validation(Required=false)]
                public string BackupSourceInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("BackupSourceInstanceType")]
                [Validation(Required=false)]
                public string BackupSourceInstanceType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("BackupSourcePort")]
                [Validation(Required=false)]
                public string BackupSourcePort { get; set; }

                [NameInMap("BeginTimestampForRestore")]
                [Validation(Required=false)]
                public long? BeginTimestampForRestore { get; set; }

                [NameInMap("EndTimestampForRestore")]
                [Validation(Required=false)]
                public long? EndTimestampForRestore { get; set; }

                [NameInMap("FullBackupList")]
                [Validation(Required=false)]
                public DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupList FullBackupList { get; set; }
                public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupList : TeaModel {
                    [NameInMap("FullBackupDetail")]
                    [Validation(Required=false)]
                    public List<DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupListFullBackupDetail> FullBackupDetail { get; set; }
                    public class DescribeRestoreRangeInfoResponseBodyItemsDBSRecoverRangeFullBackupListFullBackupDetail : TeaModel {
                        [NameInMap("BackupSetId")]
                        [Validation(Required=false)]
                        public string BackupSetId { get; set; }

                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public long? EndTime { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public long? StartTime { get; set; }

                    }

                }

                [NameInMap("RangeType")]
                [Validation(Required=false)]
                public string RangeType { get; set; }

                [NameInMap("SourceEndpointInstanceID")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceID { get; set; }

                [NameInMap("SourceEndpointInstanceType")]
                [Validation(Required=false)]
                public string SourceEndpointInstanceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E2BD9DFC-6760-5F49-97C5-DA739E29****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request succeeded.</para>
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

    }

}
