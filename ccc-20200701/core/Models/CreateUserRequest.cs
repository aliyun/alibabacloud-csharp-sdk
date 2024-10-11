// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateUserRequest : TeaModel {
        [NameInMap("AvatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("DisplayId")]
        [Validation(Required=false)]
        public string DisplayId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent</para>
        /// </summary>
        [NameInMap("LoginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1382114****</para>
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ResetPassword")]
        [Validation(Required=false)]
        public bool? ResetPassword { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent@ccc-test</para>
        /// </summary>
        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;skillGroupId&quot;:&quot;skillgroup1@ccc-test&quot;,&quot;skillLevel&quot;:1},{&quot;skillGroupId&quot;:&quot;skillgroup2@ccc-test&quot;,&quot;skillLevel&quot;:10}]</para>
        /// </summary>
        [NameInMap("SkillLevelList")]
        [Validation(Required=false)]
        public string SkillLevelList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ON_SITE</para>
        /// </summary>
        [NameInMap("WorkMode")]
        [Validation(Required=false)]
        public string WorkMode { get; set; }

    }

}
