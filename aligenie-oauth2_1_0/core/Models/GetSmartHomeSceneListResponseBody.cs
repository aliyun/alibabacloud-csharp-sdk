// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieoauth2_1_0.Models
{
    public class GetSmartHomeSceneListResponseBody : TeaModel {
        [NameInMap("FamilySceneList")]
        [Validation(Required=false)]
        public List<GetSmartHomeSceneListResponseBodyFamilySceneList> FamilySceneList { get; set; }
        public class GetSmartHomeSceneListResponseBodyFamilySceneList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2iS1AH5eo8qrw1PYBL/Ulq==</para>
            /// </summary>
            [NameInMap("familyId")]
            [Validation(Required=false)]
            public string FamilyId { get; set; }

            [NameInMap("familyName")]
            [Validation(Required=false)]
            public string FamilyName { get; set; }

            [NameInMap("sceneList")]
            [Validation(Required=false)]
            public List<GetSmartHomeSceneListResponseBodyFamilySceneListSceneList> SceneList { get; set; }
            public class GetSmartHomeSceneListResponseBodyFamilySceneListSceneList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>6813AH5586qrw1P5ln/123==</para>
                /// </summary>
                [NameInMap("SceneId")]
                [Validation(Required=false)]
                public string SceneId { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>435CF567-12DC-5761-AFA8-650774502E2D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
