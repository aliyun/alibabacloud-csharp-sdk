// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class CreateSkillRequest : TeaModel {
        /// <summary>
        /// <para>The description of the Skill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A Skill for reviewing code quality, security risks, and coding standards.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The Skill metadata in JSON object format. Exactly one content source must be provided. For more information about the fields, see &quot;Request parameter description&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;skillMd&quot;:&quot;# Code Review\nCheck code quality, security risks, and coding standards.&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The unique identifier of the Skill. Only letters, digits, underscores, and hyphens are supported. The value can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The visibility of the Skill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>user</description></item>
        /// <item><description>tenant</description></item>
        /// </list>
        /// <para>Default value: user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
