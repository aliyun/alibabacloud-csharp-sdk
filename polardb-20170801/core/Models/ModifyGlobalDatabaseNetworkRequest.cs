// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyGlobalDatabaseNetworkRequest : TeaModel {
        /// <summary>
        /// <para>Create a global domain</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableGlobalDomainName")]
        [Validation(Required=false)]
        public bool? EnableGlobalDomainName { get; set; }

        /// <summary>
        /// <para>The description of the GDN. The description must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The description cannot start with http:// or https://.</description></item>
        /// <item><description>The description must start with a letter.</description></item>
        /// <item><description>The description can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>The description must be 2 to 126 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GDN-fortest</para>
        /// </summary>
        [NameInMap("GDNDescription")]
        [Validation(Required=false)]
        public string GDNDescription { get; set; }

        /// <summary>
        /// <para>The GDN ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gdn-bp1fttxsrmv*****</para>
        /// </summary>
        [NameInMap("GDNId")]
        [Validation(Required=false)]
        public string GDNId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
