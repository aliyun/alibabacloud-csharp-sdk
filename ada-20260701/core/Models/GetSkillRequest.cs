// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetSkillRequest : TeaModel {
        /// <summary>
        /// <para>The name of the skill.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>code-review</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the download URL. Valid values: public and internal. If omitted, no download URL is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>Specifies the published history version number to query. If omitted, the current main record of the skill is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SkillVersion")]
        [Validation(Required=false)]
        public long? SkillVersion { get; set; }

    }

}
