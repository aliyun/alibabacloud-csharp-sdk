// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeVaultsRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Replication")]
        [Validation(Required=false)]
        public bool? Replication { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-*********************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

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
        /// <para>Tag information. Supports up to 20 tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6a745bceffb042959b3b5206d6f12ad1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeVaultsRequestTag> Tag { get; set; }
        public class DescribeVaultsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The Value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Backup vault ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-*********************</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

        /// <summary>
        /// <para>The name of the backup vault. The name must be 1 to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vaultname</para>
        /// </summary>
        [NameInMap("VaultName")]
        [Validation(Required=false)]
        public string VaultName { get; set; }

        [NameInMap("VaultOwnerId")]
        [Validation(Required=false)]
        public long? VaultOwnerId { get; set; }

        /// <summary>
        /// <para>The region ID to which the backup vault belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("VaultRegionId")]
        [Validation(Required=false)]
        public string VaultRegionId { get; set; }

        /// <summary>
        /// <para>Backup repository type. The values are as follows: </para>
        /// <list type="bullet">
        /// <item><description><b>STANDARD</b>: Represents a standard repository, which can be used for ECS file backups, OSS backups, NAS backups, etc. </description></item>
        /// <item><description><b>OTS_BACKUP</b>: Represents a TableStore repository, which is only used for TableStore backups, and TableStore must use this type of repository.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STANDARD</para>
        /// </summary>
        [NameInMap("VaultType")]
        [Validation(Required=false)]
        public string VaultType { get; set; }

    }

}
