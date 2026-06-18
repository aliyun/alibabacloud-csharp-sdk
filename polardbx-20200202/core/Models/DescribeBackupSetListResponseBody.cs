// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeBackupSetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeBackupSetListResponseBodyData> Data { get; set; }
        public class DescribeBackupSetListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The backup mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: automatic backup.</description></item>
            /// <item><description><b>1</b>: manual backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackupModel")]
            [Validation(Required=false)]
            public int? BackupModel { get; set; }

            /// <summary>
            /// <para>The ID of the backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("BackupSetId")]
            [Validation(Required=false)]
            public string BackupSetId { get; set; }

            /// <summary>
            /// <para>The size of the backup set. Unit: bytes.</para>
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
            /// <item><description><b>0</b>: fast backup.</description></item>
            /// <item><description><b>1</b>: consistent backup.</description></item>
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
            /// <para>1635706960956</para>
            /// </summary>
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public long? BeginTime { get; set; }

            /// <summary>
            /// <para>The time when the backup ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1635706960956</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The status of the backup set. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Being backed up.</description></item>
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
        /// <para>The response message. &quot;success&quot; is returned if the request is successful. Otherwise, an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
