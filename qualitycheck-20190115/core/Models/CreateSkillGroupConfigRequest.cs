// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class CreateSkillGroupConfigRequest : TeaModel {
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
        /// <para>{&quot;skillGroupFrom&quot;:0,&quot;qualityCheckType&quot;:0,&quot;modelId&quot;:746,&quot;name&quot;:&quot;test&quot;,&quot;rid&quot;:&quot;2493&quot;,&quot;vocabId&quot;:&quot;267&quot;,&quot;skillGroupList&quot;:[{&quot;skillGroupId&quot;:&quot;0903&quot;,&quot;skillGroupName&quot;:&quot;0903&quot;}]}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
