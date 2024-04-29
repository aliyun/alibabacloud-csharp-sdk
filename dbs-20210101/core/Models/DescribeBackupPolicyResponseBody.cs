// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyData Data { get; set; }
        public class DescribeBackupPolicyResponseBodyData : TeaModel {
            [NameInMap("AdvanceDataPolicies")]
            [Validation(Required=false)]
            public List<DescribeBackupPolicyResponseBodyDataAdvanceDataPolicies> AdvanceDataPolicies { get; set; }
            public class DescribeBackupPolicyResponseBodyDataAdvanceDataPolicies : TeaModel {
                [NameInMap("AutoCreated")]
                [Validation(Required=false)]
                public bool? AutoCreated { get; set; }

                [NameInMap("BakType")]
                [Validation(Required=false)]
                public string BakType { get; set; }

                [NameInMap("DestRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

                [NameInMap("DumpAction")]
                [Validation(Required=false)]
                public string DumpAction { get; set; }

                [NameInMap("FilterKey")]
                [Validation(Required=false)]
                public string FilterKey { get; set; }

                [NameInMap("FilterType")]
                [Validation(Required=false)]
                public string FilterType { get; set; }

                [NameInMap("FilterValue")]
                [Validation(Required=false)]
                public string FilterValue { get; set; }

                [NameInMap("RetentionType")]
                [Validation(Required=false)]
                public string RetentionType { get; set; }

                [NameInMap("RetentionValue")]
                [Validation(Required=false)]
                public string RetentionValue { get; set; }

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

            [NameInMap("AdvanceLogPolicies")]
            [Validation(Required=false)]
            public List<DescribeBackupPolicyResponseBodyDataAdvanceLogPolicies> AdvanceLogPolicies { get; set; }
            public class DescribeBackupPolicyResponseBodyDataAdvanceLogPolicies : TeaModel {
                [NameInMap("DestRegion")]
                [Validation(Required=false)]
                public string DestRegion { get; set; }

                [NameInMap("DestType")]
                [Validation(Required=false)]
                public string DestType { get; set; }

                [NameInMap("EnableLogBackup")]
                [Validation(Required=false)]
                public bool? EnableLogBackup { get; set; }

                [NameInMap("LogRetentionType")]
                [Validation(Required=false)]
                public string LogRetentionType { get; set; }

                [NameInMap("LogRetentionValue")]
                [Validation(Required=false)]
                public string LogRetentionValue { get; set; }

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

            [NameInMap("BackupMethod")]
            [Validation(Required=false)]
            public string BackupMethod { get; set; }

            [NameInMap("BackupPriority")]
            [Validation(Required=false)]
            public int? BackupPriority { get; set; }

            [NameInMap("BackupRetentionPeriod")]
            [Validation(Required=false)]
            public int? BackupRetentionPeriod { get; set; }

            [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
            [Validation(Required=false)]
            public string BackupRetentionPolicyOnClusterDeletion { get; set; }

            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("EnableBackup")]
            [Validation(Required=false)]
            public int? EnableBackup { get; set; }

            [NameInMap("EnableIncBackup")]
            [Validation(Required=false)]
            public int? EnableIncBackup { get; set; }

            [NameInMap("EnableLogBackup")]
            [Validation(Required=false)]
            public int? EnableLogBackup { get; set; }

            [NameInMap("HighFrequencyBakInterval")]
            [Validation(Required=false)]
            public int? HighFrequencyBakInterval { get; set; }

            [NameInMap("HighSpaceUsageProtection")]
            [Validation(Required=false)]
            public string HighSpaceUsageProtection { get; set; }

            [NameInMap("IncBackupInterval")]
            [Validation(Required=false)]
            public int? IncBackupInterval { get; set; }

            [NameInMap("LocalLogRetentionSpace")]
            [Validation(Required=false)]
            public int? LocalLogRetentionSpace { get; set; }

            [NameInMap("LogBackupLocalRetentionNumber")]
            [Validation(Required=false)]
            public string LogBackupLocalRetentionNumber { get; set; }

            [NameInMap("LogBackupRetention")]
            [Validation(Required=false)]
            public int? LogBackupRetention { get; set; }

            [NameInMap("PreferredBackupDate")]
            [Validation(Required=false)]
            public string PreferredBackupDate { get; set; }

            [NameInMap("PreferredBackupWindow")]
            [Validation(Required=false)]
            public string PreferredBackupWindow { get; set; }

            [NameInMap("PreferredBackupWindowBegin")]
            [Validation(Required=false)]
            public string PreferredBackupWindowBegin { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
