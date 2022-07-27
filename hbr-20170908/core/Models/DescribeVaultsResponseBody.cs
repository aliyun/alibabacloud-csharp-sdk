// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeVaultsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Vaults")]
        [Validation(Required=false)]
        public DescribeVaultsResponseBodyVaults Vaults { get; set; }
        public class DescribeVaultsResponseBodyVaults : TeaModel {
            [NameInMap("Vault")]
            [Validation(Required=false)]
            public List<DescribeVaultsResponseBodyVaultsVault> Vault { get; set; }
            public class DescribeVaultsResponseBodyVaultsVault : TeaModel {
                public DescribeVaultsResponseBodyVaultsVaultBackupPlanStatistics BackupPlanStatistics { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultBackupPlanStatistics : TeaModel {
                    [NameInMap("CommonNas")]
                    [Validation(Required=false)]
                    public int? CommonNas { get; set; }

                    [NameInMap("Csg")]
                    [Validation(Required=false)]
                    public int? Csg { get; set; }

                    [NameInMap("EcsFile")]
                    [Validation(Required=false)]
                    public int? EcsFile { get; set; }

                    [NameInMap("EcsHana")]
                    [Validation(Required=false)]
                    public int? EcsHana { get; set; }

                    [NameInMap("Isilon")]
                    [Validation(Required=false)]
                    public int? Isilon { get; set; }

                    [NameInMap("LocalFile")]
                    [Validation(Required=false)]
                    public int? LocalFile { get; set; }

                    [NameInMap("LocalVm")]
                    [Validation(Required=false)]
                    public int? LocalVm { get; set; }

                    [NameInMap("MySql")]
                    [Validation(Required=false)]
                    public int? MySql { get; set; }

                    [NameInMap("Nas")]
                    [Validation(Required=false)]
                    public int? Nas { get; set; }

                    [NameInMap("Oracle")]
                    [Validation(Required=false)]
                    public int? Oracle { get; set; }

                    [NameInMap("Oss")]
                    [Validation(Required=false)]
                    public int? Oss { get; set; }

                    [NameInMap("Ots")]
                    [Validation(Required=false)]
                    public int? Ots { get; set; }

                    [NameInMap("SqlServer")]
                    [Validation(Required=false)]
                    public int? SqlServer { get; set; }

                }
                public string BucketName { get; set; }
                public long? BytesDone { get; set; }
                public string ChargeType { get; set; }
                public long? ChargedStorageSize { get; set; }
                public string CompressionAlgorithm { get; set; }
                public long? CreatedTime { get; set; }
                public bool? Dedup { get; set; }
                public string Description { get; set; }
                public string EncryptType { get; set; }
                public bool? IndexAvailable { get; set; }
                public string IndexLevel { get; set; }
                public long? IndexUpdateTime { get; set; }
                public string KmsKeyId { get; set; }
                public long? LatestReplicationTime { get; set; }
                public string RedundancyType { get; set; }
                public bool? Replication { get; set; }
                public DescribeVaultsResponseBodyVaultsVaultReplicationProgress ReplicationProgress { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultReplicationProgress : TeaModel {
                    [NameInMap("HistoricalReplicationProgress")]
                    [Validation(Required=false)]
                    public int? HistoricalReplicationProgress { get; set; }

                    [NameInMap("NewReplicationProgress")]
                    [Validation(Required=false)]
                    public long? NewReplicationProgress { get; set; }

                }
                public string ReplicationSourceRegionId { get; set; }
                public string ReplicationSourceVaultId { get; set; }
                public string ResourceGroupId { get; set; }
                public long? Retention { get; set; }
                public bool? SearchEnabled { get; set; }
                public long? SnapshotCount { get; set; }
                public DescribeVaultsResponseBodyVaultsVaultSourceTypes SourceTypes { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultSourceTypes : TeaModel {
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public List<string> SourceType { get; set; }

                }
                public string Status { get; set; }
                public long? StorageSize { get; set; }
                public DescribeVaultsResponseBodyVaultsVaultTags Tags { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVaultsResponseBodyVaultsVaultTagsTag> Tag { get; set; }
                    public class DescribeVaultsResponseBodyVaultsVaultTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public DescribeVaultsResponseBodyVaultsVaultTrialInfo TrialInfo { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultTrialInfo : TeaModel {
                    [NameInMap("KeepAfterTrialExpiration")]
                    [Validation(Required=false)]
                    public bool? KeepAfterTrialExpiration { get; set; }

                    [NameInMap("TrialExpireTime")]
                    [Validation(Required=false)]
                    public long? TrialExpireTime { get; set; }

                    [NameInMap("TrialStartTime")]
                    [Validation(Required=false)]
                    public long? TrialStartTime { get; set; }

                    [NameInMap("TrialVaultReleaseTime")]
                    [Validation(Required=false)]
                    public long? TrialVaultReleaseTime { get; set; }

                }
                public long? UpdatedTime { get; set; }
                public string VaultId { get; set; }
                public string VaultName { get; set; }
                public string VaultRegionId { get; set; }
                public string VaultStatusMessage { get; set; }
                public string VaultStorageClass { get; set; }
                public string VaultType { get; set; }
                public bool? WormEnabled { get; set; }
            }
        };

    }

}
