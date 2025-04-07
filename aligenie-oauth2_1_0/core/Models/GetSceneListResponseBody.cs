// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieoauth2_1_0.Models
{
    public class GetSceneListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>435CF567-58DC-5761-AFA8-650772602E2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SceneList")]
        [Validation(Required=false)]
        public List<GetSceneListResponseBodySceneList> SceneList { get; set; }
        public class GetSceneListResponseBodySceneList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>840960b85c3c48e0bd7260c1718295fd</para>
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

        }

    }

}
