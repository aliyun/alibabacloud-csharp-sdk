// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateCloudConnectNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The private CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The description of the CCN instance.</para>
        /// <para>The description must be 2 to 128 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The description must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccndesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the CCN instance.</para>
        /// <para>The name must be 2 to 100 characters in length and can contain letters, digits, periods (.), underscores (_),and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccnname</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the CCN instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The private CIDR block used for Source Network Address Translation (SNAT).</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.0/25</para>
        /// </summary>
        [NameInMap("SnatCidrBlock")]
        [Validation(Required=false)]
        public string SnatCidrBlock { get; set; }

    }

}
