// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class CreateUserInvitationCodeRequest : TeaModel {
        /// <summary>
        /// <para>The logon identifier (EndUserId) of a single user, used for compatibility with single-user creation. You must specify either this parameter or EndUserIds, but not both. If neither is specified, PARAMETER_MISSING is returned. If both are specified, PARAM_ERROR is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-001</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The array of user logon identifiers (EndUserIds). You must specify either this parameter or EndUserId. You can specify 1 to 100 unique, non-empty strings at a time, and a code is generated for each user. If any user does not exist, USER_NOT_FOUND is returned. If the array is empty, or contains duplicate items, empty items, or non-string items, PARAM_ERROR is returned.</para>
        /// </summary>
        [NameInMap("EndUserIds")]
        [Validation(Required=false)]
        public List<string> EndUserIds { get; set; }

        /// <summary>
        /// <para>The ID of the terminal group. The group must belong to the current account and must not be deleted. After the corresponding terminal uses the management code to complete management, it is added to this group. If the group does not exist, is deleted, or does not belong to the current account, TERMINAL_GROUP_NOT_FOUND is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tg-example</para>
        /// </summary>
        [NameInMap("TerminalGroupId")]
        [Validation(Required=false)]
        public string TerminalGroupId { get; set; }

        /// <summary>
        /// <para>The validity period of the management code, in minutes. A value of -1 indicates that the code is permanently valid. For values between 60 and 1440, only integer multiples of 60 (1 to 24 hours) are allowed. For values greater than 1440, only integer multiples of 1440 are allowed, up to a maximum of 12960 (2 to 9 days). Other values return PARAM_ERROR. The server calculates the validity period based on this duration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1440</para>
        /// </summary>
        [NameInMap("ValidityMinutes")]
        [Validation(Required=false)]
        public int? ValidityMinutes { get; set; }

    }

}
