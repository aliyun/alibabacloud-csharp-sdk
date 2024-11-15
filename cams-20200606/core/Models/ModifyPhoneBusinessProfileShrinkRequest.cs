// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ModifyPhoneBusinessProfileShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>business profile</para>
        /// </summary>
        [NameInMap("About")]
        [Validation(Required=false)]
        public string About { get; set; }

        /// <summary>
        /// <para>The address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The phone number.</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The space ID of the RAM user within the independent software vendor (ISV) account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>293483938849****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The description of the phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:aa@aliyun.com">aa@aliyun.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The mobile phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8613800001234</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>The URL of the profile picture.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://a.img">http://a.img</a></para>
        /// </summary>
        [NameInMap("ProfilePictureUrl")]
        [Validation(Required=false)]
        public string ProfilePictureUrl { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The industry.</para>
        /// <remarks>
        /// <para> Valid values: OTHER, AUTO, BEAUTY, APPAREL, EDU, ENTERTAIN, EVENT_PLAN, FINANCE, GROCERY, GOVT, HOTEL, HEALTH, NONPROFIT, PROF_SERVICES, RETAIL, TRAVEL, and RESTAURANT.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OTHER</para>
        /// </summary>
        [NameInMap("Vertical")]
        [Validation(Required=false)]
        public string Vertical { get; set; }

        /// <summary>
        /// <para>The URLs of the websites.</para>
        /// </summary>
        [NameInMap("Websites")]
        [Validation(Required=false)]
        public string WebsitesShrink { get; set; }

    }

}
