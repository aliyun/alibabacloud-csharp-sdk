// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class SyncMessengerSubscriptionTokenRequest : TeaModel {
        /// <summary>
        /// <para>The Space ID of the Independent Software Vendor (ISV) sub-customer or the instance ID of the direct customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-xi****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The custom audience ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20399***</para>
        /// </summary>
        [NameInMap("CustomAudienceId")]
        [Validation(Required=false)]
        public string CustomAudienceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The Page ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2030***</para>
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
        /// <para>The token type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customAudience</para>
        /// </summary>
        [NameInMap("TokenType")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

    }

}
