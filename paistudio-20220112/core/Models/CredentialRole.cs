// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CredentialRole : TeaModel {
        /// <summary>
        /// <para>The entity that uses the role credentials.</para>
        /// </summary>
        [NameInMap("AssumeRoleFor")]
        [Validation(Required=false)]
        public string AssumeRoleFor { get; set; }

        /// <summary>
        /// <para>The user information for role assumption.</para>
        /// </summary>
        [NameInMap("AssumeUserInfo")]
        [Validation(Required=false)]
        public AssumeUserInfo AssumeUserInfo { get; set; }

        /// <summary>
        /// <para>The access policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1157703270994901:role/aliyunserviceroleforpaiworkspace</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The role type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
