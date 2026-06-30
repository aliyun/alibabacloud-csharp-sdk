// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SaveConfigDataSetRequest : TeaModel {
        /// <summary>
        /// <para>baseMeAgentId</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>A complete JSON string. For details, see the following information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{&quot;judgeType&quot;:1,&quot;setId&quot;:851,&quot;jsonStrForRule&quot;:{&quot;conditions&quot;:[{&quot;cid&quot;:&quot;1&quot;,&quot;check_range&quot;:{},&quot;lambda&quot;:&quot;1&quot;,&quot;operators&quot;:[{&quot;oid&quot;:1,&quot;type&quot;:&quot;HIT_ANY_KEYWORDS&quot;,&quot;param&quot;:{&quot;keywords&quot;:[&quot;有什么可以帮您&quot;,&quot;客服中心&quot;],&quot;in_sentence&quot;:false}}]}],&quot;rules&quot;:[{&quot;externalProperty&quot;:0,&quot;lambda&quot;:&quot;1&quot;,&quot;rid&quot;:&quot;1&quot;}],&quot;roleJudgeMethod&quot;:&quot;keyword&quot;},&quot;channelType&quot;:1}&quot;</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
