// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpdateBackupPolicyResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateBackupPolicyResponseBodyData Data { get; set; }
        public class UpdateBackupPolicyResponseBodyData : TeaModel {
            [NameInMap("BackupPeriod")]
            [Validation(Required=false)]
            public string BackupPeriod { get; set; }

            [NameInMap("BackupPlanBegin")]
            [Validation(Required=false)]
            public string BackupPlanBegin { get; set; }

            [NameInMap("BackupSetRetention")]
            [Validation(Required=false)]
            public int? BackupSetRetention { get; set; }

            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            [NameInMap("BackupWay")]
            [Validation(Required=false)]
            public string BackupWay { get; set; }

            [NameInMap("ColdDataBackupInterval")]
            [Validation(Required=false)]
            public int? ColdDataBackupInterval { get; set; }

            [NameInMap("ColdDataBackupRetention")]
            [Validation(Required=false)]
            public int? ColdDataBackupRetention { get; set; }

            [NameInMap("CrossRegionDataBackupRetention")]
            [Validation(Required=false)]
            public int? CrossRegionDataBackupRetention { get; set; }

            [NameInMap("CrossRegionLogBackupRetention")]
            [Validation(Required=false)]
            public int? CrossRegionLogBackupRetention { get; set; }

            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            [NameInMap("DestCrossRegion")]
            [Validation(Required=false)]
            public string DestCrossRegion { get; set; }

            [NameInMap("ForceCleanOnHighSpaceUsage")]
            [Validation(Required=false)]
            public int? ForceCleanOnHighSpaceUsage { get; set; }

            [NameInMap("IsCrossRegionDataBackupEnabled")]
            [Validation(Required=false)]
            public bool? IsCrossRegionDataBackupEnabled { get; set; }

            [NameInMap("IsCrossRegionLogBackupEnabled")]
            [Validation(Required=false)]
            public bool? IsCrossRegionLogBackupEnabled { get; set; }

            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public int? IsEnabled { get; set; }

            [NameInMap("LocalLogRetention")]
            [Validation(Required=false)]
            public int? LocalLogRetention { get; set; }

            [NameInMap("LocalLogRetentionNumber")]
            [Validation(Required=false)]
            public int? LocalLogRetentionNumber { get; set; }

            [NameInMap("LogLocalRetentionSpace")]
            [Validation(Required=false)]
            public int? LogLocalRetentionSpace { get; set; }

            [NameInMap("RemoveLogRetention")]
            [Validation(Required=false)]
            public int? RemoveLogRetention { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
