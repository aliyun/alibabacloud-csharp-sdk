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
                [NameInMap("ArchiveBytesDone")]
                [Validation(Required=false)]
                public long? ArchiveBytesDone { get; set; }

                [NameInMap("ArchiveStorageSize")]
                [Validation(Required=false)]
                public long? ArchiveStorageSize { get; set; }

                [NameInMap("BackupPlanStatistics")]
                [Validation(Required=false)]
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

                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                [NameInMap("BytesDone")]
                [Validation(Required=false)]
                public long? BytesDone { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("ChargedStorageSize")]
                [Validation(Required=false)]
                public long? ChargedStorageSize { get; set; }

                [NameInMap("CompressionAlgorithm")]
                [Validation(Required=false)]
                public string CompressionAlgorithm { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("Dedup")]
                [Validation(Required=false)]
                public bool? Dedup { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                [NameInMap("IndexAvailable")]
                [Validation(Required=false)]
                public bool? IndexAvailable { get; set; }

                [NameInMap("IndexLevel")]
                [Validation(Required=false)]
                public string IndexLevel { get; set; }

                [NameInMap("IndexUpdateTime")]
                [Validation(Required=false)]
                public long? IndexUpdateTime { get; set; }

                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                [NameInMap("LatestReplicationTime")]
                [Validation(Required=false)]
                public long? LatestReplicationTime { get; set; }

                [NameInMap("RedundancyType")]
                [Validation(Required=false)]
                public string RedundancyType { get; set; }

                [NameInMap("Replication")]
                [Validation(Required=false)]
                public bool? Replication { get; set; }

                [NameInMap("ReplicationProgress")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultReplicationProgress ReplicationProgress { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultReplicationProgress : TeaModel {
                    [NameInMap("HistoricalReplicationProgress")]
                    [Validation(Required=false)]
                    public int? HistoricalReplicationProgress { get; set; }

                    [NameInMap("NewReplicationProgress")]
                    [Validation(Required=false)]
                    public long? NewReplicationProgress { get; set; }

                }

                [NameInMap("ReplicationSourceRegionId")]
                [Validation(Required=false)]
                public string ReplicationSourceRegionId { get; set; }

                [NameInMap("ReplicationSourceVault")]
                [Validation(Required=false)]
                public bool? ReplicationSourceVault { get; set; }

                [NameInMap("ReplicationSourceVaultId")]
                [Validation(Required=false)]
                public string ReplicationSourceVaultId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                [NameInMap("SearchEnabled")]
                [Validation(Required=false)]
                public bool? SearchEnabled { get; set; }

                [NameInMap("SnapshotCount")]
                [Validation(Required=false)]
                public long? SnapshotCount { get; set; }

                [NameInMap("SourceTypes")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultSourceTypes SourceTypes { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultSourceTypes : TeaModel {
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public List<string> SourceType { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public long? StorageSize { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("TrialInfo")]
                [Validation(Required=false)]
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

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

                [NameInMap("VaultName")]
                [Validation(Required=false)]
                public string VaultName { get; set; }

                [NameInMap("VaultRegionId")]
                [Validation(Required=false)]
                public string VaultRegionId { get; set; }

                [NameInMap("VaultStatusMessage")]
                [Validation(Required=false)]
                public string VaultStatusMessage { get; set; }

                [NameInMap("VaultStorageClass")]
                [Validation(Required=false)]
                public string VaultStorageClass { get; set; }

                [NameInMap("VaultType")]
                [Validation(Required=false)]
                public string VaultType { get; set; }

                [NameInMap("WormEnabled")]
                [Validation(Required=false)]
                public bool? WormEnabled { get; set; }

            }

        }

    }

}
