// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneQuerySceneListByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DsgSceneQuerySceneListByNameResponseBodyData> Data { get; set; }
        public class DsgSceneQuerySceneListByNameResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The parameter information of multi-level masking scenarios.</para>
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<object> Children { get; set; }

            /// <summary>
            /// <para>The description of the masking scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test scenarios</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The ID of the masking scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The engine information where the masking scenario takes effect.</para>
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<DsgSceneQuerySceneListByNameResponseBodyDataProjects> Projects { get; set; }
            public class DsgSceneQuerySceneListByNameResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// <para>The ID of the EMR cluster. This parameter is returned only when the data scope where the masking scenario takes effect is an EMR engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-123456</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The engine type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ODPS: ODPS.ODPS</description></item>
                /// <item><description>HOLO: HOLO.POSTGRES</description></item>
                /// <item><description>EMR: EMR</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS.ODPS</para>
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// <para>The name of the engine instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev_project</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <para>The code of the level-1 masking scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dataworks_display_desense_code: masking for Data Studio and Data Map display</description></item>
            /// <item><description>maxcompute_desense_code: masking at the MaxCompute engine layer</description></item>
            /// <item><description>maxcompute_new_desense_code: masking at the MaxCompute engine layer (new)</description></item>
            /// <item><description>hologres_display_desense_code: masking at the Hologres engine layer</description></item>
            /// <item><description>dataworks_data_integration_desense_code: static data masking for Data Integration</description></item>
            /// <item><description>dataworks_analysis_desense_code: masking for Data Analysis display</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks_display_desense_code</para>
            /// </summary>
            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// <para>The level of the masking scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: level-1 scenario</description></item>
            /// <item><description>1: level-2 scenario</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneLevel")]
            [Validation(Required=false)]
            public int? SceneLevel { get; set; }

            /// <summary>
            /// <para>The name of the masking scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_scene</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The list of user group names for the masking scenario. Multiple names are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1,user2</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public string UserGroups { get; set; }

            /// <summary>
            /// <para>The data source type of the masking scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EMR</para>
            /// </summary>
            [NameInMap("scenceDbType")]
            [Validation(Required=false)]
            public string ScenceDbType { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1029030003</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>param error</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102400001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
