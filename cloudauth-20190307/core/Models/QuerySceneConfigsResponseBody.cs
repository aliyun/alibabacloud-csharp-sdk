// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class QuerySceneConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Willingness configuration list.</para>
        /// </summary>
        [NameInMap("sceneConfigs")]
        [Validation(Required=false)]
        public List<QuerySceneConfigsResponseBodySceneConfigs> SceneConfigs { get; set; }
        public class QuerySceneConfigsResponseBodySceneConfigs : TeaModel {
            /// <summary>
            /// <para>Specific configuration content, in JSON string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;faceCompareMode\&quot;:\&quot;CUSTOM\&quot;,\&quot;certConfigs\&quot;:[{\&quot;index\&quot;:0,\&quot;openVoiceCompare\&quot;:false,\&quot;openCustomizedContent\&quot;:true,\&quot;model\&quot;:\&quot;QA\&quot;}],\&quot;screenEvidence\&quot;:true}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760782820000</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1760782820000</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>607</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Scene ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000009045</para>
            /// </summary>
            [NameInMap("sceneId")]
            [Validation(Required=false)]
            public long? SceneId { get; set; }

            /// <summary>
            /// <para>Configuration type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VOLUNTARY</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Scene configuration version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

    }

}
