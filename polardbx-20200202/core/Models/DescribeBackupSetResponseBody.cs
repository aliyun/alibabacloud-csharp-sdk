// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeBackupSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The data list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBackupSetResponseBodyData> Data { get; set; }
        public class DescribeBackupSetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The backup mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Automatic backup.</description></item>
            /// <item><description><b>1</b>: Manual backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackupModel")]
            [Validation(Required=false)]
            public int? BackupModel { get; set; }

            /// <summary>
            /// <para>The backup set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public long? BackupSetId { get; set; }

            /// <summary>
            /// <para>The size of the backup set, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>88803195</para>
            /// </summary>
            [NameInMap("BackupSetSize")]
            [Validation(Required=false)]
            public long? BackupSetSize { get; set; }

            /// <summary>
            /// <para>The backup type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Fast backup.</description></item>
            /// <item><description><b>1</b>: Consistent backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public int? BackupType { get; set; }

            /// <summary>
            /// <para>The time when the backup started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650250861754</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>The time when the backup ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1650251308000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The list of OSS information for the backup set.</para>
            /// </summary>
            [NameInMap("OSSList")]
            [Validation(Required=false)]
            public List<DescribeBackupSetResponseBodyDataOSSList> OSSList { get; set; }
            public class DescribeBackupSetResponseBodyDataOSSList : TeaModel {
                /// <summary>
                /// <para>The OSS file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hins3084_data_20220418110623_qp.xb</para>
                /// </summary>
                [NameInMap("BackupSetFile")]
                [Validation(Required=false)]
                public string BackupSetFile { get; set; }

                /// <summary>
                /// <para>The public download URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://pre-rdsbak-cn-xxx.oss-cn-beijing.aliyuncs.com/custins2255/hins3084_data_20220418110623_qp.xb?OSSAccessKeyId=LTAI****************&Expires=1650441697&dd=7KJzkUSbXf6dwy">https://pre-rdsbak-cn-xxx.oss-cn-beijing.aliyuncs.com/custins2255/hins3084_data_20220418110623_qp.xb?OSSAccessKeyId=LTAI****************&amp;Expires=1650441697&amp;dd=7KJzkUSbXf6dwy</a></para>
                /// </summary>
                [NameInMap("DownloadLink")]
                [Validation(Required=false)]
                public string DownloadLink { get; set; }

                /// <summary>
                /// <para>The internal network download URL for the OSS file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://pre-rdsbak-cn-beijing.oss-cn-beijing-internal.aliyuncs.com/custins2255/hins3084_data_20220418110623_qp.xb">http://pre-rdsbak-cn-beijing.oss-cn-beijing-internal.aliyuncs.com/custins2255/hins3084_data_20220418110623_qp.xb</a>?</para>
                /// </summary>
                [NameInMap("IntranetDownloadLink")]
                [Validation(Required=false)]
                public string IntranetDownloadLink { get; set; }

                /// <summary>
                /// <para>The expiration time of the OSS file link.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-20T08:01:37Z</para>
                /// </summary>
                [NameInMap("LinkExpiredTime")]
                [Validation(Required=false)]
                public string LinkExpiredTime { get; set; }

            }

            /// <summary>
            /// <para>The status of the backup set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Backing up.</description></item>
            /// <item><description><b>1</b>: Backup succeeded.</description></item>
            /// <item><description><b>2</b>: Backup failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successs</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A6D328C-84B8-40DC-BF49-6C73984D7494</para>
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

    }

}
