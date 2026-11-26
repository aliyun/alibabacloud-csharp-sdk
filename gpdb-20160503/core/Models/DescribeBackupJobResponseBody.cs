// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeBackupJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup set ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/210093.html">DescribeDataBackups</a> operation to query the IDs of all backup sets for the target instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The backup task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("BackupJobId")]
        [Validation(Required=false)]
        public string BackupJobId { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Automated</b>: automatic backup</description></item>
        /// <item><description><b>Manual</b>: manual backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Automated</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The backup status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>schedule</b>: initializing</description></item>
        /// <item><description><b>check</b>: checking</description></item>
        /// <item><description><b>backup</b>: backing up</description></item>
        /// <item><description><b>finish</b>: completed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>backup</para>
        /// </summary>
        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// <para>The progress percentage of the backup task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50%</para>
        /// </summary>
        [NameInMap("Process")]
        [Validation(Required=false)]
        public string Process { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time of the backup task in UTC. The format is YYYY-MM-DDThh:mm:ssZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-03T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
