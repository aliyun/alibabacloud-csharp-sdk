// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneAddOrUpdateSceneRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scenes")]
        [Validation(Required=false)]
        public List<DsgSceneAddOrUpdateSceneRequestScenes> Scenes { get; set; }
        public class DsgSceneAddOrUpdateSceneRequestScenes : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("projects")]
            [Validation(Required=false)]
            public List<DsgSceneAddOrUpdateSceneRequestScenesProjects> Projects { get; set; }
            public class DsgSceneAddOrUpdateSceneRequestScenesProjects : TeaModel {
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("dbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("userGroupIds")]
            [Validation(Required=false)]
            public List<long?> UserGroupIds { get; set; }

        }

    }

}
