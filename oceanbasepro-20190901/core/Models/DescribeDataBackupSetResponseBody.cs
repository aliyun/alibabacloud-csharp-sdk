// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeDataBackupSetResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDataBackupSetResponseBodyData> Data { get; set; }
        public class DescribeDataBackupSetResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cluster</para>
            /// </summary>
            [NameInMap("BackupObjectType")]
            [Validation(Required=false)]
            public string BackupObjectType { get; set; }

            [NameInMap("BackupObjects")]
            [Validation(Required=false)]
            public List<DescribeDataBackupSetResponseBodyDataBackupObjects> BackupObjects { get; set; }
            public class DescribeDataBackupSetResponseBodyDataBackupObjects : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test-****way</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("DatabaseTablesList")]
                [Validation(Required=false)]
                public List<DescribeDataBackupSetResponseBodyDataBackupObjectsDatabaseTablesList> DatabaseTablesList { get; set; }
                public class DescribeDataBackupSetResponseBodyDataBackupObjectsDatabaseTablesList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sms_pre</para>
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    [NameInMap("Tables")]
                    [Validation(Required=false)]
                    public List<string> Tables { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ob2mr3oae0****</para>
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

            }

            [NameInMap("BackupResults")]
            [Validation(Required=false)]
            public List<DescribeDataBackupSetResponseBodyDataBackupResults> BackupResults { get; set; }
            public class DescribeDataBackupSetResponseBodyDataBackupResults : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>container-opa-****-02</para>
                /// </summary>
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("TableBackupResults")]
                [Validation(Required=false)]
                public List<DescribeDataBackupSetResponseBodyDataBackupResultsTableBackupResults> TableBackupResults { get; set; }
                public class DescribeDataBackupSetResponseBodyDataBackupResultsTableBackupResults : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>order_ce****_online</para>
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Create tag success</para>
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>RUNNING</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tr_sale_order_****</para>
                    /// </summary>
                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ob2mr3oae0****</para>
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-05-15T07:11:08Z</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>31457280</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public int? DataSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1678847020352</para>
            /// </summary>
            [NameInMap("DataVersion")]
            [Validation(Required=false)]
            public int? DataVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100***012</para>
            /// </summary>
            [NameInMap("DownloadTaskId")]
            [Validation(Required=false)]
            public long? DownloadTaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>not_exist</para>
            /// </summary>
            [NameInMap("DownloadTaskStatus")]
            [Validation(Required=false)]
            public string DownloadTaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-13T03:38:10Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>logical</para>
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>automated</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>52</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>imm-test-set-cb****ee-b7d7-11ed-956f-****3e10bd70</para>
            /// </summary>
            [NameInMap("SetId")]
            [Validation(Required=false)]
            public string SetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-05-22T17:04:18</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("Validity")]
            [Validation(Required=false)]
            public string Validity { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
