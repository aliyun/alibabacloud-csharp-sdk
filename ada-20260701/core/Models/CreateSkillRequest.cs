// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class CreateSkillRequest : TeaModel {
        /// <summary>
        /// <para>The description of the skill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A Skill for reviewing code quality, security risks, and coding standards.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The metadata of the skill, in JSON object format. You must and can only provide one content source. For specific fields, refer to the supplementary description of request parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;skillMd&quot;:&quot;# Code Review\nChecks code quality, security risks, and coding standards.&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The unique identifier of the skill. Only English letters, digits, underscores, and hyphens are supported. The length cannot exceed 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The visibility of the skill. Valid values: user and tenant. Default value: user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
