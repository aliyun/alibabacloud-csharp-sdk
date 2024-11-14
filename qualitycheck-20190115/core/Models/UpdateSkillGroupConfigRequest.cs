// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UpdateSkillGroupConfigRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;skillGroupFrom&quot;:0,&quot;name&quot;:&quot;test&quot;,&quot;qualityCheckType&quot;:0,&quot;rid&quot;:&quot;2493,4098&quot;,&quot;vocabId&quot;:267,&quot;skillGroupList&quot;:[{&quot;skillGroupId&quot;:&quot;090311&quot;,&quot;skillGroupName&quot;:&quot;09031&quot;}],&quot;id&quot;:553}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
