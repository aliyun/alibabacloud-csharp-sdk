// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListMessageCampaignShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Meta ad account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239**</para>
        /// </summary>
        [NameInMap("AdAccountId")]
        [Validation(Required=false)]
        public string AdAccountId { get; set; }

        /// <summary>
        /// <para>The budget ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>233**</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>The budget name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-campaign</para>
        /// </summary>
        [NameInMap("CampaignName")]
        [Validation(Required=false)]
        public string CampaignName { get; set; }

        /// <summary>
        /// <para>The SpaceId or instance ID of the ISV sub-customer. This is the channel ID, which you can view on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-**</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The pagination parameter object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public string PageShrink { get; set; }

        /// <summary>
        /// <para>The Page ID of Messenger.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>239***</para>
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
        /// <para>The budget status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
