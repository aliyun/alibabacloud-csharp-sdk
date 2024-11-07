// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ModifyUserRequest : TeaModel {
        /// <summary>
        /// <para>The email address of the convenience user. For a user-activated convenience user, the email address or mobile number must be verified. You can choose to verify the email address or the mobile number. For an administrator-activated convenience user, the email address and mobile number can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The name of the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The mobile number of the convenience user. For a user-activated convenience user, the email address or mobile number must be verified. You can choose to verify the email address or the mobile number. For an administrator-activated convenience user, the email address and mobile number can be left empty.</para>
        /// <remarks>
        /// <para> Accounts created on the International site (alibabacloud.com) do not support mobile number-based authentication.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1381111****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

    }

}
