// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class ModifyBackupPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The details of data backup policies.</para>
        /// </summary>
        [NameInMap("AdvanceDataPolicies")]
        [Validation(Required=false)]
        public string AdvanceDataPoliciesShrink { get; set; }

        [NameInMap("AdvanceIncPolicies")]
        [Validation(Required=false)]
        public string AdvanceIncPoliciesShrink { get; set; }

        [NameInMap("AdvanceLogPolicies")]
        [Validation(Required=false)]
        public string AdvanceLogPoliciesShrink { get; set; }

        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public string BackupRetentionPolicyOnClusterDeletion { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("EnableIncBackup")]
        [Validation(Required=false)]
        public bool? EnableIncBackup { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2ze3nrr64c5****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The start time of a basic backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupWindowBegin")]
        [Validation(Required=false)]
        public string PreferredBackupWindowBegin { get; set; }

        /// <summary>
        /// <para>The region in which backup sets reside.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionCode")]
        [Validation(Required=false)]
        public string RegionCode { get; set; }

    }

}
