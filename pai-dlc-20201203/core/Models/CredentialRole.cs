// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CredentialRole : TeaModel {
        /// <summary>
        /// <para>The account on whose behalf the role is assumed.</para>
        /// </summary>
        [NameInMap("AssumeRoleFor")]
        [Validation(Required=false)]
        public string AssumeRoleFor { get; set; }

        /// <summary>
        /// <para>The user identity information used for role assumption.</para>
        /// </summary>
        [NameInMap("AssumeUserInfo")]
        [Validation(Required=false)]
        public AssumeUserInfo AssumeUserInfo { get; set; }

        /// <summary>
        /// <para>The access policy attached during role assumption.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1872xxxxxxxxx:role/account-pai-prod</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The role type. Valid values: service and user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
