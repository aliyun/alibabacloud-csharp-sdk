// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeVaultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The message that is returned. If the call is successful, &quot;successful&quot; is returned. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number for pagination, starting from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size, with a minimum value of 1, a maximum value of 99, and a default value of 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request was successful.</para>
        /// <list type="bullet">
        /// <item><description>true: Success - false: Failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Returns the total number of backup repositories.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
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
                    [NameInMap("Archive")]
                    [Validation(Required=false)]
                    public int? Archive { get; set; }

                    [NameInMap("CommonFileSystem")]
                    [Validation(Required=false)]
                    public int? CommonFileSystem { get; set; }

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

                [NameInMap("ReplicationSourceOwnerId")]
                [Validation(Required=false)]
                public long? ReplicationSourceOwnerId { get; set; }

                [NameInMap("ReplicationSourceRegionId")]
                [Validation(Required=false)]
                public string ReplicationSourceRegionId { get; set; }

                [NameInMap("ReplicationSourceVault")]
                [Validation(Required=false)]
                public bool? ReplicationSourceVault { get; set; }

                [NameInMap("ReplicationSourceVaultId")]
                [Validation(Required=false)]
                public string ReplicationSourceVaultId { get; set; }

                [NameInMap("ReplicationStatus")]
                [Validation(Required=false)]
                public string ReplicationStatus { get; set; }

                [NameInMap("ReplicationTargetOwnerId")]
                [Validation(Required=false)]
                public long? ReplicationTargetOwnerId { get; set; }

                [NameInMap("ReplicationTargetRegionId")]
                [Validation(Required=false)]
                public string ReplicationTargetRegionId { get; set; }

                [NameInMap("ReplicationTargetVaultId")]
                [Validation(Required=false)]
                public string ReplicationTargetVaultId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                [NameInMap("RsTargetAccountIds")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultRsTargetAccountIds RsTargetAccountIds { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultRsTargetAccountIds : TeaModel {
                    [NameInMap("RsTargetAccountId")]
                    [Validation(Required=false)]
                    public List<long?> RsTargetAccountId { get; set; }

                }

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

                [NameInMap("VaultOwnerId")]
                [Validation(Required=false)]
                public long? VaultOwnerId { get; set; }

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
