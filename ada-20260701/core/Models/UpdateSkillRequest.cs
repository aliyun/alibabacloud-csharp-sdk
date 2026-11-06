// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class UpdateSkillRequest : TeaModel {
        /// <summary>
        /// <para>The updated description of the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A skill used for code review, security checks, and risk alerts</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expected version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public long? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The updated metadata of the skill. The JSON object is replaced as a whole. The content supports one of the following: Transit ID, bundleUrl, or skillMd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;transitId&quot;:&quot;transit_example456&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public object Metadata { get; set; }

        /// <summary>
        /// <para>The name of the skill to be updated. This parameter is only used to locate the skill and cannot be used to modify the name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The updated visibility. Valid values: <c>user</c> and <c>tenant</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
