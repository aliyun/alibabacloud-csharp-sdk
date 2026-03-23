// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("AdvancedBackupPolicyEnabled")]
        [Validation(Required=false)]
        public bool? AdvancedBackupPolicyEnabled { get; set; }

        [NameInMap("AdvancedDataPolicies")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyAdvancedDataPolicies AdvancedDataPolicies { get; set; }
        public class DescribeBackupPolicyResponseBodyAdvancedDataPolicies : TeaModel {
            [NameInMap("AdvancedDataPolicy")]
            [Validation(Required=false)]
            public List<DescribeBackupPolicyResponseBodyAdvancedDataPoliciesAdvancedDataPolicy> AdvancedDataPolicy { get; set; }
            public class DescribeBackupPolicyResponseBodyAdvancedDataPoliciesAdvancedDataPolicy : TeaModel {
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                [NameInMap("BakType")]
                [Validation(Required=false)]
                public string BakType { get; set; }

                [NameInMap("DestRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

                [NameInMap("FilterKey")]
                [Validation(Required=false)]
                public string FilterKey { get; set; }

                [NameInMap("FilterType")]
                [Validation(Required=false)]
                public string FilterType { get; set; }

                [NameInMap("FilterValue")]
                [Validation(Required=false)]
                public string FilterValue { get; set; }

                [NameInMap("OnlyPreserveOneEachDay")]
                [Validation(Required=false)]
                public bool? OnlyPreserveOneEachDay { get; set; }

                [NameInMap("OnlyPreserveOneEachHour")]
                [Validation(Required=false)]
                public bool? OnlyPreserveOneEachHour { get; set; }

                [NameInMap("RetentionType")]
                [Validation(Required=false)]
                public string RetentionType { get; set; }

                [NameInMap("RetentionValue")]
                [Validation(Required=false)]
                public int? RetentionValue { get; set; }

                [NameInMap("SrcRegion")]
                [Validation(Required=false)]
                public string SrcRegion { get; set; }

                [NameInMap("SrcType")]
                [Validation(Required=false)]
                public string SrcType { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

            }

        }

        [NameInMap("AdvancedLogPolicies")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyAdvancedLogPolicies AdvancedLogPolicies { get; set; }
        public class DescribeBackupPolicyResponseBodyAdvancedLogPolicies : TeaModel {
            [NameInMap("AdvancedLogPolicy")]
            [Validation(Required=false)]
            public List<DescribeBackupPolicyResponseBodyAdvancedLogPoliciesAdvancedLogPolicy> AdvancedLogPolicy { get; set; }
            public class DescribeBackupPolicyResponseBodyAdvancedLogPoliciesAdvancedLogPolicy : TeaModel {
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                [NameInMap("DestRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

                [NameInMap("EnableLogBackup")]
                [Validation(Required=false)]
                public int? EnableLogBackup { get; set; }

                [NameInMap("FilterKey")]
                [Validation(Required=false)]
                public string FilterKey { get; set; }

                [NameInMap("FilterValue")]
                [Validation(Required=false)]
                public string FilterValue { get; set; }

                [NameInMap("LogRetentionType")]
                [Validation(Required=false)]
                public string LogRetentionType { get; set; }

                [NameInMap("LogRetentionValue")]
                [Validation(Required=false)]
                public int? LogRetentionValue { get; set; }

                [NameInMap("SrcRegion")]
                [Validation(Required=false)]
                public string SrcRegion { get; set; }

                [NameInMap("SrcType")]
                [Validation(Required=false)]
                public string SrcType { get; set; }

                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

            }

        }

        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepCount { get; set; }

        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        [NameInMap("ArchiveBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string ArchiveBackupRetentionPeriod { get; set; }

        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        [NameInMap("BackupPriority")]
        [Validation(Required=false)]
        public int? BackupPriority { get; set; }

        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        [NameInMap("EnableIncrementDataBackup")]
        [Validation(Required=false)]
        public bool? EnableIncrementDataBackup { get; set; }

        [NameInMap("EnablePitrProtection")]
        [Validation(Required=false)]
        public bool? EnablePitrProtection { get; set; }

        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        [NameInMap("PitrRetentionPeriod")]
        [Validation(Required=false)]
        public int? PitrRetentionPeriod { get; set; }

        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportModifyBackupPriority")]
        [Validation(Required=false)]
        public bool? SupportModifyBackupPriority { get; set; }

        [NameInMap("SupportReleasedKeep")]
        [Validation(Required=false)]
        public int? SupportReleasedKeep { get; set; }

        [NameInMap("SupportVolumeShadowCopy")]
        [Validation(Required=false)]
        public int? SupportVolumeShadowCopy { get; set; }

        [NameInMap("SupportsHighFrequencyBackup")]
        [Validation(Required=false)]
        public long? SupportsHighFrequencyBackup { get; set; }

    }

}
