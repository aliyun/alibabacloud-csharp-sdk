// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// Details about the parameter templates.
        /// </summary>
        [NameInMap("ParameterGroup")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupResponseBodyParameterGroup> ParameterGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParameterGroup : TeaModel {
            /// <summary>
            /// The time when the parameter template was created. The time is in the `yyyy-MM-ddTHH:mm:ssZ` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The type of the database engine.
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// The version of the database engine.
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// Indicates whether to restart the cluster when this parameter template is applied. Valid values:
            /// 
            /// *   **0**: A restart is not required.
            /// *   **1**: A restart is required.
            /// </summary>
            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            /// <summary>
            /// The number of parameters in the parameter template.
            /// </summary>
            [NameInMap("ParameterCounts")]
            [Validation(Required=false)]
            public int? ParameterCounts { get; set; }

            /// <summary>
            /// Details about the parameters.
            /// </summary>
            [NameInMap("ParameterDetail")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParameterGroupParameterDetail> ParameterDetail { get; set; }
            public class DescribeParameterGroupResponseBodyParameterGroupParameterDetail : TeaModel {
                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            /// <summary>
            /// The description of the parameter template.
            /// </summary>
            [NameInMap("ParameterGroupDesc")]
            [Validation(Required=false)]
            public string ParameterGroupDesc { get; set; }

            /// <summary>
            /// The ID of the parameter template.
            /// </summary>
            [NameInMap("ParameterGroupId")]
            [Validation(Required=false)]
            public string ParameterGroupId { get; set; }

            /// <summary>
            /// The name of the parameter template.
            /// </summary>
            [NameInMap("ParameterGroupName")]
            [Validation(Required=false)]
            public string ParameterGroupName { get; set; }

            /// <summary>
            /// The type of the parameter template. Valid values:
            /// 
            /// *   **0**: the default parameter template.
            /// *   **1**: a custom parameter template.
            /// *   **2**: an automatic backup parameter template. After you apply this type of template, the system automatically backs up the original parameter settings and saves the backup as a template.
            /// </summary>
            [NameInMap("ParameterGroupType")]
            [Validation(Required=false)]
            public string ParameterGroupType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
