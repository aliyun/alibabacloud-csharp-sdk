// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneQuerySceneListByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The data entries returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DsgSceneQuerySceneListByNameResponseBodyData> Data { get; set; }
        public class DsgSceneQuerySceneListByNameResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about multiple levels of data masking scenarios.</para>
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<object> Children { get; set; }

            /// <summary>
            /// <para>The description of the data masking scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test scenarios</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The ID of the data masking scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The information about the compute engine for which the data masking scenario takes effect.</para>
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<DsgSceneQuerySceneListByNameResponseBodyDataProjects> Projects { get; set; }
            public class DsgSceneQuerySceneListByNameResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// <para>The ID of the EMR cluster. This parameter is returned only when the data scope that takes effect in the data masking scenario is an EMR compute engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c-1234</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The type of the compute engine. Valid values:</para>
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
                /// <para>The name of the compute engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev_project</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// <para>The code of the level-1 data masking scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>dataworks_display_desense_code: masking of displayed data in DataStudio and Data Map</description></item>
            /// <item><description>maxcompute_desense_code: data masking at the MaxCompute compute engine layer</description></item>
            /// <item><description>maxcompute_new_desense_code: data masking at the MaxCompute compute engine layer (new)</description></item>
            /// <item><description>hologres_display_desense_code: data masking at the Hologres compute engine layer</description></item>
            /// <item><description>dataworks_data_integration_desense_code: static data masking in Data Integration</description></item>
            /// <item><description>dataworks_analysis_desense_code: masking of displayed data in DataAnalysis</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks_display_desense_code</para>
            /// </summary>
            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// <para>The level of the data masking scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: level-1 data masking scenario</description></item>
            /// <item><description>1: level-2 data masking scenario</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SceneLevel")]
            [Validation(Required=false)]
            public int? SceneLevel { get; set; }

            /// <summary>
            /// <para>The name of the data masking scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_scene</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The list of user groups in the data masking scenario. Separate user groups with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1,user2</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public string UserGroups { get; set; }

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
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102400001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
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
