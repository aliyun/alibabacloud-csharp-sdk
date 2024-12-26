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

        /// <summary>
        /// <para>The backup vaults.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Vault\&quot;: []}</para>
        /// </summary>
        [NameInMap("Vaults")]
        [Validation(Required=false)]
        public DescribeVaultsResponseBodyVaults Vaults { get; set; }
        public class DescribeVaultsResponseBodyVaults : TeaModel {
            [NameInMap("Vault")]
            [Validation(Required=false)]
            public List<DescribeVaultsResponseBodyVaultsVault> Vault { get; set; }
            public class DescribeVaultsResponseBodyVaultsVault : TeaModel {
                /// <summary>
                /// <para>Archival tier backup data volume. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024000</para>
                /// </summary>
                [NameInMap("ArchiveBytesDone")]
                [Validation(Required=false)]
                public long? ArchiveBytesDone { get; set; }

                /// <summary>
                /// <para>The billable storage usage of the Archive tier. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024000</para>
                /// </summary>
                [NameInMap("ArchiveStorageSize")]
                [Validation(Required=false)]
                public long? ArchiveStorageSize { get; set; }

                /// <summary>
                /// <para>The statistics of backup plans that use the backup vault.</para>
                /// </summary>
                [NameInMap("BackupPlanStatistics")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultBackupPlanStatistics BackupPlanStatistics { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultBackupPlanStatistics : TeaModel {
                    /// <summary>
                    /// <para>The number of archive plans.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Archive")]
                    [Validation(Required=false)]
                    public int? Archive { get; set; }

                    /// <summary>
                    /// <para>The number of Cloud Parallel File Storage (CPFS) backup plans.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CommonFileSystem")]
                    [Validation(Required=false)]
                    public int? CommonFileSystem { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for General-purpose NAS file systems.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CommonNas")]
                    [Validation(Required=false)]
                    public int? CommonNas { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for Cloud Storage Gateway (CSG) gateways.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Csg")]
                    [Validation(Required=false)]
                    public int? Csg { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for ECS files.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EcsFile")]
                    [Validation(Required=false)]
                    public int? EcsFile { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for SAP HANA instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EcsHana")]
                    [Validation(Required=false)]
                    public int? EcsHana { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for Isilon storage systems.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Isilon")]
                    [Validation(Required=false)]
                    public int? Isilon { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for on-premises servers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("LocalFile")]
                    [Validation(Required=false)]
                    public int? LocalFile { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for on-premises virtual machines (VMs).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("LocalVm")]
                    [Validation(Required=false)]
                    public int? LocalVm { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for MySQL databases.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MySql")]
                    [Validation(Required=false)]
                    public int? MySql { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for NAS file systems.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Nas")]
                    [Validation(Required=false)]
                    public int? Nas { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for Oracle databases.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Oracle")]
                    [Validation(Required=false)]
                    public int? Oracle { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for OSS buckets.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Oss")]
                    [Validation(Required=false)]
                    public int? Oss { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for Tablestore instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Ots")]
                    [Validation(Required=false)]
                    public int? Ots { get; set; }

                    /// <summary>
                    /// <para>The number of backup plans for SQL Server databases.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SqlServer")]
                    [Validation(Required=false)]
                    public int? SqlServer { get; set; }

                }

                /// <summary>
                /// <para>The name of the OSS bucket used by the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hbr-0005i51******t58</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The amount of data that is backed up. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("BytesDone")]
                [Validation(Required=false)]
                public long? BytesDone { get; set; }

                /// <summary>
                /// <para>The billing method of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FREE</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The billable storage usage of the archive vault. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024000</para>
                /// </summary>
                [NameInMap("ChargedStorageSize")]
                [Validation(Required=false)]
                public long? ChargedStorageSize { get; set; }

                /// <summary>
                /// <para>The encryption algorithm used to compress the backup vault. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DISABLED: The backup vault is not compressed.</description></item>
                /// <item><description>SNAPPY: The backup vault is compressed by using the SNAPPY encryption algorithm.</description></item>
                /// <item><description>ZSTD: The backup vault is compressed by using Zstandard, a fast lossless compression algorithm.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ZSTD</para>
                /// </summary>
                [NameInMap("CompressionAlgorithm")]
                [Validation(Required=false)]
                public string CompressionAlgorithm { get; set; }

                /// <summary>
                /// <para>The time when the backup vault was created. The value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the deduplication feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Dedup")]
                [Validation(Required=false)]
                public bool? Dedup { get; set; }

                /// <summary>
                /// <para>The description of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vault description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The encryption type of the backup vault. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NONE: The backup vault is not encrypted.</description></item>
                /// <item><description>HBR_PRIVATE (default): The backup vault is encrypted by using a key provided by Cloud Backup.</description></item>
                /// <item><description>KMS: The backup vault is encrypted by using a custom master key (CMK) created in Key Management Service (KMS).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HBR_PRIVATE</para>
                /// </summary>
                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                /// <summary>
                /// <para>Indicates whether indexes are available. Indexes are available when they are not being updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IndexAvailable")]
                [Validation(Required=false)]
                public bool? IndexAvailable { get; set; }

                /// <summary>
                /// <para>The index level.</para>
                /// <list type="bullet">
                /// <item><description>OFF: No indexes are created.</description></item>
                /// <item><description>META: Metadata indexes are created.</description></item>
                /// <item><description>ALL: Full-text indexes are created.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OFF</para>
                /// </summary>
                [NameInMap("IndexLevel")]
                [Validation(Required=false)]
                public string IndexLevel { get; set; }

                /// <summary>
                /// <para>The time when the index was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1639645628</para>
                /// </summary>
                [NameInMap("IndexUpdateTime")]
                [Validation(Required=false)]
                public long? IndexUpdateTime { get; set; }

                /// <summary>
                /// <para>The ID or alias of the CMK created in KMS. This parameter is returned only when EncryptType is set to KMS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alias/acs/acm</para>
                /// </summary>
                [NameInMap("KmsKeyId")]
                [Validation(Required=false)]
                public string KmsKeyId { get; set; }

                /// <summary>
                /// <para>The time when the last remote backup was synchronized. The value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("LatestReplicationTime")]
                [Validation(Required=false)]
                public long? LatestReplicationTime { get; set; }

                /// <summary>
                /// <para>The data redundancy type of the backup vault. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>LRS: Locally redundant storage (LRS) is enabled for the backup vault. Cloud Backup stores the copies of each object on multiple devices of different facilities in the same zone. This way, Cloud Backup ensures data durability and availability even if hardware failures occur.</description></item>
                /// <item><description>ZRS: Zone-redundant storage (ZRS) is enabled for the backup vault. Cloud Backup uses the multi-zone mechanism to distribute data across three zones within the same region. If a zone fails, the data that is stored in the other two zones is still accessible.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LRS</para>
                /// </summary>
                [NameInMap("RedundancyType")]
                [Validation(Required=false)]
                public string RedundancyType { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup vault is a remote backup vault. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The backup vault is a remote backup vault.</description></item>
                /// <item><description>false: The backup vault is a local backup vault.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Replication")]
                [Validation(Required=false)]
                public bool? Replication { get; set; }

                /// <summary>
                /// <para>The progress of data synchronization from the backup vault to the mirror vault.</para>
                /// </summary>
                [NameInMap("ReplicationProgress")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultReplicationProgress ReplicationProgress { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultReplicationProgress : TeaModel {
                    /// <summary>
                    /// <para>The progress of historical data synchronization from the backup vault to the mirror vault. Valid values: 0 to 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("HistoricalReplicationProgress")]
                    [Validation(Required=false)]
                    public int? HistoricalReplicationProgress { get; set; }

                    /// <summary>
                    /// <para>The latest synchronization time of incremental data in the mirror vault.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579413159</para>
                    /// </summary>
                    [NameInMap("NewReplicationProgress")]
                    [Validation(Required=false)]
                    public long? NewReplicationProgress { get; set; }

                }

                /// <summary>
                /// <para>The ID of the region in which the source vault resides. This parameter is valid only for remote backup vaults.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-*********************</para>
                /// </summary>
                [NameInMap("ReplicationSourceRegionId")]
                [Validation(Required=false)]
                public string ReplicationSourceRegionId { get; set; }

                /// <summary>
                /// <para>Indicate whether the backup vault is the source vault that corresponds to the remote backup vault. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ReplicationSourceVault")]
                [Validation(Required=false)]
                public bool? ReplicationSourceVault { get; set; }

                /// <summary>
                /// <para>The ID of the source vault that corresponds to the remote backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-*********************</para>
                /// </summary>
                [NameInMap("ReplicationSourceVaultId")]
                [Validation(Required=false)]
                public string ReplicationSourceVaultId { get; set; }

                /// <summary>
                /// <para>Target region for remote backup repository.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("ReplicationTargetRegionId")]
                [Validation(Required=false)]
                public string ReplicationTargetRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-*********************</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The retention period of the backup vault. Unit: days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Retention")]
                [Validation(Required=false)]
                public long? Retention { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup search feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SearchEnabled")]
                [Validation(Required=false)]
                public bool? SearchEnabled { get; set; }

                /// <summary>
                /// <para>The number of snapshots in the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SnapshotCount")]
                [Validation(Required=false)]
                public long? SnapshotCount { get; set; }

                /// <summary>
                /// <para>The data source types of the backup vault.</para>
                /// </summary>
                [NameInMap("SourceTypes")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultSourceTypes SourceTypes { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultSourceTypes : TeaModel {
                    [NameInMap("SourceType")]
                    [Validation(Required=false)]
                    public List<string> SourceType { get; set; }

                }

                /// <summary>
                /// <para>The status of the backup vault. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UNKNOWN</b>: The backup vault is in an unknown state.</description></item>
                /// <item><description><b>INITIALIZING</b>: The backup vault is being initialized.</description></item>
                /// <item><description><b>CREATED</b>: The backup vault is created.</description></item>
                /// <item><description><b>ERROR</b>: An error occurs on the backup vault.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CREATED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The usage of the backup vault. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public long? StorageSize { get; set; }

                /// <summary>
                /// <para>The tags of the backup vault.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultTags Tags { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeVaultsResponseBodyVaultsVaultTagsTag> Tag { get; set; }
                    public class DescribeVaultsResponseBodyVaultsVaultTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key of the backup vault. Valid values of N: 1 to 20.</para>
                        /// <list type="bullet">
                        /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
                        /// <item><description>The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
                        /// <item><description>The tag key cannot be an empty string.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>aaa</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value of the backup vault. Valid values of N: 1 to 20.</para>
                        /// <list type="bullet">
                        /// <item><description>The tag value cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
                        /// <item><description>The tag value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
                        /// <item><description>The tag value cannot be an empty string.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The free trial information.</para>
                /// </summary>
                [NameInMap("TrialInfo")]
                [Validation(Required=false)]
                public DescribeVaultsResponseBodyVaultsVaultTrialInfo TrialInfo { get; set; }
                public class DescribeVaultsResponseBodyVaultsVaultTrialInfo : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether you are billed based on the pay-as-you-go method after the free trial ends.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("KeepAfterTrialExpiration")]
                    [Validation(Required=false)]
                    public bool? KeepAfterTrialExpiration { get; set; }

                    /// <summary>
                    /// <para>The expiration time of the free trial.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1584597600</para>
                    /// </summary>
                    [NameInMap("TrialExpireTime")]
                    [Validation(Required=false)]
                    public long? TrialExpireTime { get; set; }

                    /// <summary>
                    /// <para>The start time of the free trial.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1579413159</para>
                    /// </summary>
                    [NameInMap("TrialStartTime")]
                    [Validation(Required=false)]
                    public long? TrialStartTime { get; set; }

                    /// <summary>
                    /// <para>The time when the free-trial backup vault is released.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1594965600</para>
                    /// </summary>
                    [NameInMap("TrialVaultReleaseTime")]
                    [Validation(Required=false)]
                    public long? TrialVaultReleaseTime { get; set; }

                }

                /// <summary>
                /// <para>The time when the backup vault was updated. The value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554347313</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-*********************</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

                /// <summary>
                /// <para>The name of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vaultname</para>
                /// </summary>
                [NameInMap("VaultName")]
                [Validation(Required=false)]
                public string VaultName { get; set; }

                /// <summary>
                /// <para>The ID of the region in which the backup vault resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("VaultRegionId")]
                [Validation(Required=false)]
                public string VaultRegionId { get; set; }

                /// <summary>
                /// <para>The status message that is returned when the backup vault is in the ERROR state. This parameter is valid only for remote backup vaults. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UNKNOWN_ERROR</b>: An unknown error occurs.</description></item>
                /// <item><description><b>SOURCE_VAULT_ALREADY_HAS_REPLICATION</b>: A mirror vault is configured for the source vault.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SOURCE_VAULT_ALREADY_HAS_REPLICATION</para>
                /// </summary>
                [NameInMap("VaultStatusMessage")]
                [Validation(Required=false)]
                public string VaultStatusMessage { get; set; }

                /// <summary>
                /// <para>The storage class of the backup vault. Valid value: <b>STANDARD</b>, which indicates standard storage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("VaultStorageClass")]
                [Validation(Required=false)]
                public string VaultStorageClass { get; set; }

                /// <summary>
                /// <para>The type of the backup vault. Valid value: <b>STANDARD</b>, which indicates a standard backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STANDARD</para>
                /// </summary>
                [NameInMap("VaultType")]
                [Validation(Required=false)]
                public string VaultType { get; set; }

                /// <summary>
                /// <para>Indicates whether the immutable backup feature is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("WormEnabled")]
                [Validation(Required=false)]
                public bool? WormEnabled { get; set; }

            }

        }

    }

}
