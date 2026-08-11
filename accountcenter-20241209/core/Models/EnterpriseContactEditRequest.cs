// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseContactEditRequest : TeaModel {
        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Specifies whether to asynchronously verify the email address. Set this parameter to true for API calls. Otherwise, the verification code is synchronously and strictly verified. Call SendAsyncEmailCaptcha to send a verification link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncEmailVerify")]
        [Validation(Required=false)]
        public bool? AsyncEmailVerify { get; set; }

        /// <summary>
        /// <para>Specifies whether to asynchronously verify the mobile phone number. Set this parameter to true for API calls. Otherwise, the verification code is synchronously and strictly verified. Call SendAsyncMobileCaptcha to send a verification link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncMobileVerify")]
        [Validation(Required=false)]
        public bool? AsyncMobileVerify { get; set; }

        /// <summary>
        /// <para>The email address of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxx@xxx.xx">xxx@xxx.xx</a></para>
        /// </summary>
        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <para>The ID of the contact to modify. You can invoke the EnterpriseContactQueryPageList operation to perform a paged query of account contact information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ContactMobile")]
        [Validation(Required=false)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// <para>The name of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>The position of the contact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ContactPosition")]
        [Validation(Required=false)]
        public string ContactPosition { get; set; }

        /// <summary>
        /// <para>The email verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("EmailCode")]
        [Validation(Required=false)]
        public string EmailCode { get; set; }

        /// <summary>
        /// <para>The SMS verification code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MobileCode")]
        [Validation(Required=false)]
        public string MobileCode { get; set; }

        /// <summary>
        /// <para>The entity ID of the cross-enterprise management object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrientedEcId")]
        [Validation(Required=false)]
        public string OrientedEcId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise to which you have switched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrientedLeId")]
        [Validation(Required=false)]
        public string OrientedLeId { get; set; }

        /// <summary>
        /// <para>The sales channel ID of the cross-enterprise management object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrientedNbId")]
        [Validation(Required=false)]
        public string OrientedNbId { get; set; }

        /// <summary>
        /// <para>Specifies whether the contact is a public contact. This operation sets this parameter to true by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SharedContact")]
        [Validation(Required=false)]
        public bool? SharedContact { get; set; }

    }

}
