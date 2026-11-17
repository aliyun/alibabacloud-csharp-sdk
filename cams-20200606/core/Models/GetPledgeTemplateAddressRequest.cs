// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetPledgeTemplateAddressRequest : TeaModel {
        /// <summary>
        /// <para>The SpaceId or instance ID of the ISV sub-customer. This is the channel ID, which you can view on the <a href="https://chatapp.console.aliyun.com/ChannelsManagement">Channel Management</a> page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-x***</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The industry type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>it</para>
        /// </summary>
        [NameInMap("IndustryType")]
        [Validation(Required=false)]
        public string IndustryType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
