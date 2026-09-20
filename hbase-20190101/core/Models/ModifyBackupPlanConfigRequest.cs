// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyBackupPlanConfigRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-m5eznlga4k5bcxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The full backup cycle, in days. Valid values: 3 to 9.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("FullBackupCycle")]
        [Validation(Required=false)]
        public string FullBackupCycle { get; set; }

        /// <summary>
        /// <para>The number of full backups to retain. Valid values: 3 to 8.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinHFileBackupCount")]
        [Validation(Required=false)]
        public string MinHFileBackupCount { get; set; }

        /// <summary>
        /// <para>The time of the next full backup. The specified time must be at least 6 minutes later than the current time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-09T18:00:00Z</para>
        /// </summary>
        [NameInMap("NextFullBackupDate")]
        [Validation(Required=false)]
        public string NextFullBackupDate { get; set; }

        /// <summary>
        /// <para>The tables to back up. Specify one table name per line. Wildcards are supported. An asterisk (*) indicates all tables.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tables")]
        [Validation(Required=false)]
        public string Tables { get; set; }

    }

}
