// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpdateBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The backup cycle. You must specify at least 2 days. The value is a 7-digit number. From left to right, each digit indicates whether backup is enabled from Monday to Sunday. A value of 0 indicates that backup is disabled, and a value of 1 indicates that backup is enabled:</para>
        /// <list type="bullet">
        /// <item><description>First digit: Monday</description></item>
        /// <item><description>Second digit: Tuesday</description></item>
        /// <item><description>Third digit: Wednesday</description></item>
        /// <item><description>Fourth digit: Thursday</description></item>
        /// <item><description>Fifth digit: Friday</description></item>
        /// <item><description>Sixth digit: Saturday</description></item>
        /// <item><description>Seventh digit: Sunday.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1001000</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <para>The start time of the daily backup, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03:00Z</para>
        /// </summary>
        [NameInMap("BackupPlanBegin")]
        [Validation(Required=false)]
        public string BackupPlanBegin { get; set; }

        /// <summary>
        /// <para>The retention period of backup sets. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("BackupSetRetention")]
        [Validation(Required=false)]
        public int? BackupSetRetention { get; set; }

        /// <summary>
        /// <para>The backup type. Currently, only &quot;0&quot; is supported, which indicates fast backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>P</b>: physical backup</description></item>
        /// <item><description><b>L</b>: logical backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>P</para>
        /// </summary>
        [NameInMap("BackupWay")]
        [Validation(Required=false)]
        public string BackupWay { get; set; }

        /// <summary>
        /// <para>The interval for cold data backups. Unit: days. Valid values: 1 to 59.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ColdDataBackupInterval")]
        [Validation(Required=false)]
        public int? ColdDataBackupInterval { get; set; }

        /// <summary>
        /// <para>The retention period for cold data backups. Unit: days. Valid values: 30 to 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("ColdDataBackupRetention")]
        [Validation(Required=false)]
        public int? ColdDataBackupRetention { get; set; }

        /// <summary>
        /// <para>The retention period for cross-region data backups. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CrossRegionDataBackupRetention")]
        [Validation(Required=false)]
        public int? CrossRegionDataBackupRetention { get; set; }

        [NameInMap("CrossRegionFilterValue")]
        [Validation(Required=false)]
        public string CrossRegionFilterValue { get; set; }

        /// <summary>
        /// <para>The retention period for cross-region log backups. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CrossRegionLogBackupRetention")]
        [Validation(Required=false)]
        public int? CrossRegionLogBackupRetention { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzjasdyuoo</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The destination region for cross-region backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("DestCrossRegion")]
        [Validation(Required=false)]
        public string DestCrossRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly clean up binary logs when the total space usage of the instance exceeds 80% or the remaining space is less than 50 GB. The cleanup starts from the earliest logs until the total space usage drops below 80% and the remaining space exceeds 50 GB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ForceCleanOnHighSpaceUsage")]
        [Validation(Required=false)]
        public int? ForceCleanOnHighSpaceUsage { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cross-region data backup. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsCrossRegionDataBackupEnabled")]
        [Validation(Required=false)]
        public bool? IsCrossRegionDataBackupEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cross-region log backup. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsCrossRegionLogBackupEnabled")]
        [Validation(Required=false)]
        public bool? IsCrossRegionLogBackupEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable backup. The value is fixed to 1, which indicates that backup is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsEnabled")]
        [Validation(Required=false)]
        public int? IsEnabled { get; set; }

        /// <summary>
        /// <para>The number of hours that log backups are retained locally. Valid values: 0 to 168 (7 × 24 hours). A value of 0 indicates that log backups are not retained locally. Default value: 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LocalLogRetention")]
        [Validation(Required=false)]
        public int? LocalLogRetention { get; set; }

        /// <summary>
        /// <para>The number of binary logs retained locally. Default value: 60. Valid values: 6 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("LocalLogRetentionNumber")]
        [Validation(Required=false)]
        public int? LocalLogRetentionNumber { get; set; }

        /// <summary>
        /// <para>The maximum space usage for binary logs, expressed as a percentage. Valid values: 0 to 50. This parameter specifies a loop space. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LogLocalRetentionSpace")]
        [Validation(Required=false)]
        public int? LogLocalRetentionSpace { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of days that log backups are retained remotely. Valid values: 7 to 730. Unit: days. Default value: 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("RemoveLogRetention")]
        [Validation(Required=false)]
        public int? RemoveLogRetention { get; set; }

    }

}
