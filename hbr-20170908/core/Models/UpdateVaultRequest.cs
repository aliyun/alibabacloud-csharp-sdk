// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateVaultRequest : TeaModel {
        /// <summary>
        /// <para>The description of the backup vault. The description must be 0 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vault description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2fa2xeiebyy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>Specifies whether to enable the immutable backup feature for storage vaults. After the immutable backup feature is enabled, backup vaults and all backup data cannot be deleted until the retention period expires. The immutable backup feature cannot be disabled after it is enabled. Only standard backup vaults and archive vaults support the immutable backup feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WormEnabled")]
        [Validation(Required=false)]
        public bool? WormEnabled { get; set; }

    }

}
