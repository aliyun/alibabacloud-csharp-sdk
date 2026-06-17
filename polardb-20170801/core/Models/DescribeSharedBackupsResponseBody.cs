// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSharedBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of shared backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSharedBackupsResponseBodyItems> Items { get; set; }
        public class DescribeSharedBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The end time of the backup, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-12T03:25:55Z</para>
            /// </summary>
            [NameInMap("BackupEndTime")]
            [Validation(Required=false)]
            public string BackupEndTime { get; set; }

            /// <summary>
            /// <para>The backup set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111111</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The backup method. Only snapshot backup is supported. The value is fixed to <b>Snapshot</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Snapshot</para>
            /// </summary>
            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }

            /// <summary>
            /// <para>The backup mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Automated</b>: automated backup</para>
            /// </description></item>
            /// <item><description><para><b>Manual</b>: manual backup</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// <para>The size of the backup set, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4639948800</para>
            /// </summary>
            [NameInMap("BackupSetSize")]
            [Validation(Required=false)]
            public string BackupSetSize { get; set; }

            /// <summary>
            /// <para>The start time of the backup, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-15T07:30:05Z</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// <para>The backup status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Success</b>: The backup is complete.</para>
            /// </description></item>
            /// <item><description><para><b>Failed</b>: The backup failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("BackupStatus")]
            [Validation(Required=false)]
            public string BackupStatus { get; set; }

            /// <summary>
            /// <para>The backup type. Only full backups are supported. The value is fixed to <b>FullBackup</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FullBackup</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The backup level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Level-1</b>: Level-1 backup.</para>
            /// </description></item>
            /// <item><description><para><b>Level-2</b>: Level-2 backup.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Level-2</para>
            /// </summary>
            [NameInMap("BackupsLevel")]
            [Validation(Required=false)]
            public string BackupsLevel { get; set; }

            /// <summary>
            /// <para>The UNIX timestamp of the consistent snapshot, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1589253947</para>
            /// </summary>
            [NameInMap("ConsistentTime")]
            [Validation(Required=false)]
            public string ConsistentTime { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pc-****************</para>
            /// </summary>
            [NameInMap("DBClusterId")]
            [Validation(Required=false)]
            public string DBClusterId { get; set; }

            /// <summary>
            /// <para>The database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The database engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.6</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>The billing method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
            /// </description></item>
            /// <item><description><para><b>Prepaid</b>: prepaid (subscription)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Postpaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hongzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The Serverless type. A value of <b>AgileServerless</b> indicates a Serverless cluster, while an empty value indicates a standard cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AgileServerless</para>
            /// </summary>
            [NameInMap("ServerlessType")]
            [Validation(Required=false)]
            public string ServerlessType { get; set; }

            /// <summary>
            /// <para>The share type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ShareIncoming</para>
            /// </summary>
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }

            /// <summary>
            /// <para>The UID of the account that shared the backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170*************</para>
            /// </summary>
            [NameInMap("SharerUID")]
            [Validation(Required=false)]
            public string SharerUID { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total record count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
