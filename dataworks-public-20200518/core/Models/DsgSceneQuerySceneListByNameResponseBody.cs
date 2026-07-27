// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneQuerySceneListByNameResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data masking scenarios.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DsgSceneQuerySceneListByNameResponseBodyData> Data { get; set; }
        public class DsgSceneQuerySceneListByNameResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The nested data masking scenarios.</para>
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
            /// <para>The engine instances to which the data masking scenario applies.</para>
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<DsgSceneQuerySceneListByNameResponseBodyDataProjects> Projects { get; set; }
            public class DsgSceneQuerySceneListByNameResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// <para>The ID of the E-MapReduce (EMR) cluster. This parameter is returned only if the <c>DbType</c> is <c>EMR</c>.</para>
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
                /// <item><description><para>MaxCompute: <c>ODPS.ODPS</c></para>
                /// </description></item>
                /// <item><description><para>Hologres: <c>HOLO.POSTGRES</c></para>
                /// </description></item>
                /// <item><description><para>E-MapReduce (EMR): <c>EMR</c></para>
                /// </description></item>
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
            /// <para>The code for the level-1 scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Data masking in Data Map and DataStudio: <c>dataworks_display_desense_code</c></para>
            /// </description></item>
            /// <item><description><para>Data masking at the MaxCompute engine layer: <c>maxcompute_desense_code</c></para>
            /// </description></item>
            /// <item><description><para>Data masking at the MaxCompute engine layer (new): <c>maxcompute_new_desense_code</c></para>
            /// </description></item>
            /// <item><description><para>Data masking at the Hologres engine layer: <c>hologres_display_desense_code</c></para>
            /// </description></item>
            /// <item><description><para>Static data masking in Data Integration: <c>dataworks_data_integration_desense_code</c></para>
            /// </description></item>
            /// <item><description><para>Data masking in Data Analysis: <c>dataworks_analysis_desense_code</c></para>
            /// </description></item>
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
            /// <item><description><para><c>0</c>: level-1 scenario</para>
            /// </description></item>
            /// <item><description><para><c>1</c>: level-2 scenario</para>
            /// </description></item>
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
            /// <para>The user groups to which the data masking scenario applies. Multiple user group names are separated by a comma (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1,user2</para>
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public string UserGroups { get; set; }

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
        /// <para>The ID of the request. You can use this ID to troubleshoot issues.</para>
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
        /// <item><description><para><c>true</c>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The request failed.</para>
        /// </description></item>
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
