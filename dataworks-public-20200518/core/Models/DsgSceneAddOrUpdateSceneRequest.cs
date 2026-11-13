// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneAddOrUpdateSceneRequest : TeaModel {
        /// <summary>
        /// <para>The level-2 masking scenario information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scenes")]
        [Validation(Required=false)]
        public List<DsgSceneAddOrUpdateSceneRequestScenes> Scenes { get; set; }
        public class DsgSceneAddOrUpdateSceneRequestScenes : TeaModel {
            /// <summary>
            /// <para>The description.</para>
            /// <para>Note: Specifying this parameter in the current version may return PARAMS.ERROR (400). Specify only the required sceneName and sceneCode fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test scenarios</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The ID of the level-2 masking scenario.</para>
            /// <list type="bullet">
            /// <item><description>If you do not specify this parameter, the current operation creates a level-2 masking scenario.</description></item>
            /// <item><description>If you specify this parameter, the operation modifies the specified level-2 masking scenario. You can call the <a href="https://help.aliyun.com/document_detail/2786322.html">DsgSceneQuerySceneListByName</a> operation to query the ID of the level-2 masking scenario.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The engine information for which the masking scenario takes effect.</para>
            /// <para>Note: Specifying this parameter in the current version may return PARAMS.ERROR (400). Specify only the required sceneName and sceneCode fields.</para>
            /// </summary>
            [NameInMap("projects")]
            [Validation(Required=false)]
            public List<DsgSceneAddOrUpdateSceneRequestScenesProjects> Projects { get; set; }
            public class DsgSceneAddOrUpdateSceneRequestScenesProjects : TeaModel {
                /// <summary>
                /// <para>The ID of the E-MapReduce (EMR) cluster. Specify this parameter only when the masking scenario takes effect on an EMR engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-1234</para>
                /// </summary>
                [NameInMap("clusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The type of the engine for which the masking scenario takes effect. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ODPS: ODPS.ODPS</description></item>
                /// <item><description>HOLO: HOLO.POSTGRES</description></item>
                /// <item><description>EMR: EMR</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS.ODPS</para>
                /// </summary>
                [NameInMap("dbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The name of the engine instance for which the masking scenario takes effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev_project</para>
                /// </summary>
                [NameInMap("projectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <para>The code of the level-1 masking scenario to which the level-2 masking scenario belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dataworks_display_desense_code: masking for display in Data Studio and Data Map</description></item>
            /// <item><description>maxcompute_desense_code: masking at the MaxCompute engine layer</description></item>
            /// <item><description>maxcompute_new_desense_code: masking at the MaxCompute engine layer (new)</description></item>
            /// <item><description>dataworks_analysis_desense_code: masking for display in Data Analysis</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks_display_desense_code</para>
            /// </summary>
            [NameInMap("sceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// <para>The name of the level-2 masking scenario.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev_scene</para>
            /// </summary>
            [NameInMap("sceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The user group information for which the masking scenario takes effect.</para>
            /// <para>Note: Specifying this parameter in the current version may return PARAMS.ERROR (400). Specify only the required sceneName and sceneCode fields.</para>
            /// </summary>
            [NameInMap("userGroupIds")]
            [Validation(Required=false)]
            public List<long?> UserGroupIds { get; set; }

        }

    }

}
