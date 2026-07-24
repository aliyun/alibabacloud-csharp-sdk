// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class UploadDataSyncForLLMRequest : TeaModel {
        /// <summary>
        /// <para>The business space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <para>The complete JSON string. For more information about the content, see the following details.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;tickets\&quot;:[{\&quot;dialogue\&quot;:[{\&quot;role\&quot;:\&quot;Agent\&quot;,\&quot;words\&quot;:\&quot;Yes\&quot;,\&quot;end\&quot;:0,\&quot;beginTime\&quot;:1783909236618,\&quot;begin\&quot;:0}],\&quot;tid\&quot;:\&quot;20260713-20240612032225161783909236618\&quot;}],\&quot;commonRuleIds\&quot;:[\&quot;20773\&quot;]}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
