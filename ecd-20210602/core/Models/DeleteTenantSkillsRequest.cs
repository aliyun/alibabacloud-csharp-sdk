// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20210602.Models
{
    public class DeleteTenantSkillsRequest : TeaModel {
        /// <summary>
        /// <para>The skill channel. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENTERPRISE: Enterprise edition.</description></item>
        /// <item><description>BUSINESS: Business edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
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
