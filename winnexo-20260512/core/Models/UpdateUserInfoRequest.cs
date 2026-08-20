// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateUserInfoRequest : TeaModel {
        /// <summary>
        /// <para>The profile picture URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/avatar.png">https://example.com/avatar.png</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The language preference: zh-CN, en-US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("languagePreference")]
        [Validation(Required=false)]
        public string LanguagePreference { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The user service description. Maximum length: 1000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("offering")]
        [Validation(Required=false)]
        public string Offering { get; set; }

        /// <summary>
        /// <para>The user role description (used when profileRole is set to Others). Maximum length: 100 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("profileRoleInfo")]
        [Validation(Required=false)]
        public string ProfileRoleInfo { get; set; }

        /// <summary>
        /// <para>The user self-introduction. Maximum length: 1000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("selfIntroduction")]
        [Validation(Required=false)]
        public string SelfIntroduction { get; set; }

        /// <summary>
        /// <para>The effective tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
