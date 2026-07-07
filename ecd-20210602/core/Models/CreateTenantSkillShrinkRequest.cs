// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class CreateTenantSkillShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The API key of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>akm-98f66829***</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The description of the skill. Maximum length: 500 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This skill is used for****</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name****</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The environment variables.</para>
        /// </summary>
        [NameInMap("EnvVars")]
        [Validation(Required=false)]
        public string EnvVarsShrink { get; set; }

        /// <summary>
        /// <para>The icon parsing tag. This parameter is required when SkillIcon is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21E9A5B273CB8EC0675*********</para>
        /// </summary>
        [NameInMap("IconETag")]
        [Validation(Required=false)]
        public string IconETag { get; set; }

        /// <summary>
        /// <para>The skill channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENTERPRISE: Enterprise Edition.</description></item>
        /// <item><description>BUSINESS: Business Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BUSINESS</para>
        /// </summary>
        [NameInMap("SkillChannel")]
        [Validation(Required=false)]
        public string SkillChannel { get; set; }

        /// <summary>
        /// <para>The skill icon.</para>
        /// </summary>
        [NameInMap("SkillIcon")]
        [Validation(Required=false)]
        public string SkillIcon { get; set; }

        /// <summary>
        /// <para>The skill version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.1</para>
        /// </summary>
        [NameInMap("SkillVersion")]
        [Validation(Required=false)]
        public string SkillVersion { get; set; }

        /// <summary>
        /// <para>The slug identifier of the skill. This parameter is user-defined and must be unique within the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>find-skills****</para>
        /// </summary>
        [NameInMap("Slug")]
        [Validation(Required=false)]
        public string Slug { get; set; }

        /// <summary>
        /// <para>The file parsing task key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1CF3D69-529D-****</para>
        /// </summary>
        [NameInMap("TaskKey")]
        [Validation(Required=false)]
        public string TaskKey { get; set; }

    }

}
