// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneAddOrUpdateSceneRequest : TeaModel {
        /// <summary>
        /// The information about the level-2 data masking scenario.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("scenes")]
        [Validation(Required=false)]
        public List<DsgSceneAddOrUpdateSceneRequestScenes> Scenes { get; set; }
        public class DsgSceneAddOrUpdateSceneRequestScenes : TeaModel {
            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The ID of the level-2 data masking scenario.
            /// 
            /// *   If you do not configure this parameter, the current operation is to add a level-2 data masking scenario.
            /// *   If you configure this parameter, the current operation is to modify a level-2 data masking scenario. You can call the [DsgSceneQuerySceneListByName](https://help.aliyun.com/document_detail/2786322.html) operation to query the ID of the level-2 data masking scenario.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The information about the compute engine for which the data masking scenario takes effect.
            /// </summary>
            [NameInMap("projects")]
            [Validation(Required=false)]
            public List<DsgSceneAddOrUpdateSceneRequestScenesProjects> Projects { get; set; }
            public class DsgSceneAddOrUpdateSceneRequestScenesProjects : TeaModel {
                /// <summary>
                /// If the data masking scenario takes effect for an E-MapReduce (EMR) compute engine, enter the ID of an EMR cluster. This parameter is required only when you use an EMR compute engine.
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The type of the compute engine for which the data masking scenario takes effect. Valid values:
                /// 
                /// *   ODPS: ODPS.ODPS
                /// *   HOLO: HOLO.POSTGRES
                /// *   EMR: EMR
                /// </summary>
                [NameInMap("dbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The name of the compute engine instance for which the data masking scenario takes effect.
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// The code of the level-1 data masking scenario to which the level-2 data masking scenario belongs. Valid values:
            /// 
            /// *   dataworks_display_desense_code: masking of displayed data in DataStudio and Data Map
            /// *   maxcompute_desense_code: data masking at the MaxCompute compute engine layer
            /// *   maxcompute_new_desense_code: data masking at the MaxCompute compute engine layer (new)
            /// *   dataworks_analysis_desense_code: masking of displayed data in DataAnalysis
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("sceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// The name of the level-2 data masking scenario.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("sceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// The information about the user group for which the data masking scenario takes effect.
            /// </summary>
            [NameInMap("userGroupIds")]
            [Validation(Required=false)]
            public List<long?> UserGroupIds { get; set; }

        }

    }

}
