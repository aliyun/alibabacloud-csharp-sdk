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
        /// <para>The flag that indicates whether this is the last batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BatchLastFlag")]
        [Validation(Required=false)]
        public bool? BatchLastFlag { get; set; }

        /// <summary>
        /// <para>The SpaceId of the ISV sub-customer.</para>
        /// <list type="bullet">
        /// <item><description>The instance ID of the direct customer.</description></item>
        /// </list>
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
        /// <para>The estimated number of phone numbers.</para>
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
        /// <para>The PageId of Messenger.</para>
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
        /// <para>The list of users.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public string UsersShrink { get; set; }

    }

}
