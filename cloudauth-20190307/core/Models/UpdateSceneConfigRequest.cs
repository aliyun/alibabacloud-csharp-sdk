// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class UpdateSceneConfigRequest : TeaModel {
        /// <summary>
        /// <para>Scene configuration information, in JSON format. For the specific structure definition, please refer to more information about the configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;faceCompareMode\&quot;:\&quot;AUTHORITY\&quot;,\&quot;certConfigs\&quot;:[{\&quot;index\&quot;:0,\&quot;model\&quot;:\&quot;ENROLL\&quot;}],\&quot;screenEvidence\&quot;:false}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Willingness configuration ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>607</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>Selected authentication scene.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000012918</para>
        /// </summary>
        [NameInMap("sceneId")]
        [Validation(Required=false)]
        public long? SceneId { get; set; }

    }

}
