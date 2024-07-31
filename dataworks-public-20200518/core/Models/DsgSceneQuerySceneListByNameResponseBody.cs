// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgSceneQuerySceneListByNameResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DsgSceneQuerySceneListByNameResponseBodyData> Data { get; set; }
        public class DsgSceneQuerySceneListByNameResponseBodyData : TeaModel {
            /// <summary>
            /// The information about multiple levels of data masking scenarios.
            /// </summary>
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<object> Children { get; set; }

            /// <summary>
            /// The description of the data masking scenario.
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The ID of the data masking scenario.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The information about the compute engine for which the data masking scenario takes effect.
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<DsgSceneQuerySceneListByNameResponseBodyDataProjects> Projects { get; set; }
            public class DsgSceneQuerySceneListByNameResponseBodyDataProjects : TeaModel {
                /// <summary>
                /// The ID of the EMR cluster. This parameter is returned only when the data scope that takes effect in the data masking scenario is an EMR compute engine.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The type of the compute engine. Valid values:
                /// 
                /// *   ODPS: ODPS.ODPS
                /// *   HOLO: HOLO.POSTGRES
                /// *   EMR: EMR
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The name of the compute engine.
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

            }

            /// <summary>
            /// The code of the level-1 data masking scenario. Valid values:
            /// 
            /// *   dataworks_display_desense_code: masking of displayed data in DataStudio and Data Map
            /// *   maxcompute_desense_code: data masking at the MaxCompute compute engine layer
            /// *   maxcompute_new_desense_code: data masking at the MaxCompute compute engine layer (new)
            /// *   hologres_display_desense_code: data masking at the Hologres compute engine layer
            /// *   dataworks_data_integration_desense_code: static data masking in Data Integration
            /// *   dataworks_analysis_desense_code: masking of displayed data in DataAnalysis
            /// </summary>
            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// The level of the data masking scenario. Valid values:
            /// 
            /// *   0: level-1 data masking scenario
            /// *   1: level-2 data masking scenario
            /// </summary>
            [NameInMap("SceneLevel")]
            [Validation(Required=false)]
            public int? SceneLevel { get; set; }

            /// <summary>
            /// The name of the data masking scenario.
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// The list of user groups in the data masking scenario. Separate user groups with commas (,).
            /// </summary>
            [NameInMap("UserGroups")]
            [Validation(Required=false)]
            public string UserGroups { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
