// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class SetTenantSkillEnabledRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The skill channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BUSINESS</para>
        /// </summary>
        [NameInMap("SkillChannel")]
        [Validation(Required=false)]
        public string SkillChannel { get; set; }

        /// <summary>
        /// <para>The list of skill IDs.</para>
        /// </summary>
        [NameInMap("SkillIds")]
        [Validation(Required=false)]
        public List<string> SkillIds { get; set; }

    }

}
