// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpdateBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1001000</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>03:00Z</para>
        /// </summary>
        [NameInMap("BackupPlanBegin")]
        [Validation(Required=false)]
        public string BackupPlanBegin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupSetRetention")]
        [Validation(Required=false)]
        public int? BackupSetRetention { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>P</para>
        /// </summary>
        [NameInMap("BackupWay")]
        [Validation(Required=false)]
        public string BackupWay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ColdDataBackupInterval")]
        [Validation(Required=false)]
        public int? ColdDataBackupInterval { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ColdDataBackupRetention")]
        [Validation(Required=false)]
        public int? ColdDataBackupRetention { get; set; }

        [NameInMap("CrossRegionDataBackupRetention")]
        [Validation(Required=false)]
        public int? CrossRegionDataBackupRetention { get; set; }

        [NameInMap("CrossRegionLogBackupRetention")]
        [Validation(Required=false)]
        public int? CrossRegionLogBackupRetention { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzjasdyuoo</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("DestCrossRegion")]
        [Validation(Required=false)]
        public string DestCrossRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ForceCleanOnHighSpaceUsage")]
        [Validation(Required=false)]
        public int? ForceCleanOnHighSpaceUsage { get; set; }

        [NameInMap("IsCrossRegionDataBackupEnabled")]
        [Validation(Required=false)]
        public bool? IsCrossRegionDataBackupEnabled { get; set; }

        [NameInMap("IsCrossRegionLogBackupEnabled")]
        [Validation(Required=false)]
        public bool? IsCrossRegionLogBackupEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsEnabled")]
        [Validation(Required=false)]
        public int? IsEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LocalLogRetention")]
        [Validation(Required=false)]
        public int? LocalLogRetention { get; set; }

        [NameInMap("LocalLogRetentionNumber")]
        [Validation(Required=false)]
        public int? LocalLogRetentionNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LogLocalRetentionSpace")]
        [Validation(Required=false)]
        public int? LogLocalRetentionSpace { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("RemoveLogRetention")]
        [Validation(Required=false)]
        public int? RemoveLogRetention { get; set; }

    }

}
