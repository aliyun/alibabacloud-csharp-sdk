// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class AccountContactEditRequest : TeaModel {
        /// <summary>
        /// <para>Application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>Whether to asynchronously verify the email. Must be set to true for API calls. Otherwise, the verification code will be synchronously validated. Use the SendAsyncEmailCaptcha API to send the verification link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncEmailVerify")]
        [Validation(Required=false)]
        public bool? AsyncEmailVerify { get; set; }

        /// <summary>
        /// <para>Whether to asynchronously verify the mobile number. Must be set to true for API calls. Otherwise, the verification code will be synchronously validated. Use the SendAsyncMobileCaptcha API to send the verification link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsyncMobileVerify")]
        [Validation(Required=false)]
        public bool? AsyncMobileVerify { get; set; }

        /// <summary>
        /// <para>Contact email</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:xxx@xxx.xx">xxx@xxx.xx</a></para>
        /// </summary>
        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        /// <summary>
        /// <para>Contact ID. You can call AccountContactQueryPageList to query account contact information by page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ContactId")]
        [Validation(Required=false)]
        public long? ContactId { get; set; }

        /// <summary>
        /// <para>Contact mobile number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ContactMobile")]
        [Validation(Required=false)]
        public string ContactMobile { get; set; }

        /// <summary>
        /// <para>Contact name</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        /// <summary>
        /// <para>Position:</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ContactPosition")]
        [Validation(Required=false)]
        public string ContactPosition { get; set; }

        /// <summary>
        /// <para>Email verification code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("EmailCode")]
        [Validation(Required=false)]
        public string EmailCode { get; set; }

        /// <summary>
        /// <para>SMS verification code</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MobileCode")]
        [Validation(Required=false)]
        public string MobileCode { get; set; }

        /// <summary>
        /// <para>Cross-enterprise management object entity ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrientedEcId")]
        [Validation(Required=false)]
        public string OrientedEcId { get; set; }

        /// <summary>
        /// <para>Currently switched enterprise</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrientedLeId")]
        [Validation(Required=false)]
        public string OrientedLeId { get; set; }

        /// <summary>
        /// <para>Cross-enterprise management object marketplace ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("OrientedNbId")]
        [Validation(Required=false)]
        public string OrientedNbId { get; set; }

        /// <summary>
        /// <para>Whether it is an enterprise contact. This API sets the value to false by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SharedContact")]
        [Validation(Required=false)]
        public bool? SharedContact { get; set; }

    }

}
