// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ResetUserPasswordRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically generate a password. This parameter is valid only when the reset method is DirectPassword. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: Automatically generates a password.</description></item>
        /// <item><description>False (default): Manually sets a password.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("GenerateRandomPassword")]
        [Validation(Required=false)]
        public bool? GenerateRandomPassword { get; set; }

        /// <summary>
        /// <para>The new password.</para>
        /// <para>Format: The password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.</para>
        /// <para>Length: 8 to 32 characters.</para>
        /// <remarks>
        /// <para>If <c>GenerateRandomPassword</c> is set to <c>False</c>, you must specify <c>Password</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>uc)XK$?ictf72CKFDy9vtWaFmISl****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether the user must reset the password upon next logon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True: The user must reset the password.</description></item>
        /// <item><description>False (default): The user does not need to reset the password.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("RequirePasswordResetForNextLogin")]
        [Validation(Required=false)]
        public bool? RequirePasswordResetForNextLogin { get; set; }

        /// <summary>
        /// <para>The reset method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DirectPassword (default): Sets the password directly.</para>
        /// </description></item>
        /// <item><description><para>Email: Sends a password reset email.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DirectPassword</para>
        /// </summary>
        [NameInMap("ResetMethod")]
        [Validation(Required=false)]
        public string ResetMethod { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>u-00q8wbq42wiltcrk****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
