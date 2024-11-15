// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateGlobalDatabaseNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the primary cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1q76364ird*****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a global domain name.</para>
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
        /// <item><description>It cannot start with <a href="http://https://%E3%80%82">http:// or https://.</a></description></item>
        /// <item><description>It must start with a letter.</description></item>
        /// <item><description>It can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// <item><description>It must be 2 to 126 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GDN-fortest</para>
        /// </summary>
        [NameInMap("GDNDescription")]
        [Validation(Required=false)]
        public string GDNDescription { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
