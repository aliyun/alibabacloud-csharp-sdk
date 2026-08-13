// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateUserInfoRequest : TeaModel {
        /// <summary>
        /// <para>用户头像 URL</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/avatar.png">https://example.com/avatar.png</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>语言偏好: zh-CN, en-US</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("languagePreference")]
        [Validation(Required=false)]
        public string LanguagePreference { get; set; }

        /// <summary>
        /// <para>文件名</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称.pdf</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>用户服务描述，最多1000字符</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("offering")]
        [Validation(Required=false)]
        public string Offering { get; set; }

        /// <summary>
        /// <para>用户角色描述（当profileRole为Others时使用），最多100字符</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("profileRoleInfo")]
        [Validation(Required=false)]
        public string ProfileRoleInfo { get; set; }

        /// <summary>
        /// <para>用户自我介绍，最多1000字符</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("selfIntroduction")]
        [Validation(Required=false)]
        public string SelfIntroduction { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
