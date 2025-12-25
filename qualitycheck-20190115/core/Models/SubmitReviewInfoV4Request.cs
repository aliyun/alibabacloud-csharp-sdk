// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class SubmitReviewInfoV4Request : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;comments&quot;:&quot;tidComment&quot;,&quot;jsonReviewResult&quot;:&quot;{\&quot;reviewInfoList\&quot;:[{\&quot;changed\&quot;:true,\&quot;comment\&quot;:\&quot;ridComment\&quot;,\&quot;matched\&quot;:true,\&quot;reviewHitResult\&quot;:0,\&quot;reviewResult\&quot;:1,\&quot;rid\&quot;:31459,\&quot;sentenceReviewResults\&quot;:[{\&quot;changed\&quot;:true,\&quot;cid\&quot;:95302,\&quot;comment\&quot;:\&quot;pidComment\&quot;,\&quot;hitStatus\&quot;:0,\&quot;pid\&quot;:\&quot;0\&quot;,\&quot;reviewDimensionType\&quot;:\&quot;2\&quot;,\&quot;rid\&quot;:31459,\&quot;sid\&quot;:54104}]}]}&quot;,&quot;taskId&quot;:&quot;20251224-62931498-881B-1436-A93D-1FFBC5D7D4A0&quot;,&quot;vid&quot;:&quot;8cbe2bccf3be4b42bada45136f77d4e9&quot;}</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
