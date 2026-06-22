// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddCustomAudienceUserShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Meta ad account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3939**</para>
        /// </summary>
        [NameInMap("AdAccountId")]
        [Validation(Required=false)]
        public string AdAccountId { get; set; }

        /// <summary>
        /// <para>Indicates whether this is the last batch of data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BatchLastFlag")]
        [Validation(Required=false)]
        public bool? BatchLastFlag { get; set; }

        /// <summary>
        /// <para>The space ID of the Independent Software Vendor (ISV) sub-customer or the instance ID of a direct customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-**</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The ID of the custom audience.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>399**</para>
        /// </summary>
        [NameInMap("CustomAudienceId")]
        [Validation(Required=false)]
        public string CustomAudienceId { get; set; }

        /// <summary>
        /// <para>The estimated total number of users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("EstimatedNumTotal")]
        [Validation(Required=false)]
        public long? EstimatedNumTotal { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The Page ID for Messenger.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239**</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>A list of users.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string UsersShrink { get; set; }

    }

}
