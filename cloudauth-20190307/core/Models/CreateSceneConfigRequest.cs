// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class CreateSceneConfigRequest : TeaModel {
        /// <summary>
        /// <para>Intention authentication configuration, as a JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;faceCompareMode\&quot;:\&quot;AUTHORITY\&quot;,\&quot;certConfigs\&quot;:[{\&quot;index\&quot;:0,\&quot;openVoiceCompare\&quot;:true,\&quot;openCustomizedContent\&quot;:true,\&quot;model\&quot;:\&quot;FOLLOW\&quot;}],\&quot;screenEvidence\&quot;:false}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Scene ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000014084</para>
        /// </summary>
        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

        /// <summary>
        /// <para>Configuration type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VOLUNTARY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
