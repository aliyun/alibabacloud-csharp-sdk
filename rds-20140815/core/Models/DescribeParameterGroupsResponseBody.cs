// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        /// <summary>
        /// The details of the parameter templates.
        /// </summary>
        [NameInMap("ParameterGroups")]
        [Validation(Required=false)]
        public DescribeParameterGroupsResponseBodyParameterGroups ParameterGroups { get; set; }
        public class DescribeParameterGroupsResponseBodyParameterGroups : TeaModel {
            [NameInMap("ParameterGroup")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup> ParameterGroup { get; set; }
            public class DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup : TeaModel {
                /// <summary>
                /// The time when the parameter template was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The database engine of the instance.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The version of the database engine.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// Indicates whether the restart of an instance is required for the parameter template to take effect. Valid values:
                /// 
                /// *   0: A restart is not required.
                /// *   1: A restart is required.
                /// </summary>
                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public int? ForceRestart { get; set; }

                /// <summary>
                /// The number of parameters in the parameter template.
                /// </summary>
                [NameInMap("ParamCounts")]
                [Validation(Required=false)]
                public int? ParamCounts { get; set; }

                /// <summary>
                /// The type of the parameter template. Valid values:
                /// 
                /// *   0: the default parameter template.
                /// *   1: a custom parameter template.
                /// *   2: an automatic backup parameter template. After you apply this type of template, the system automatically backs up the original parameter settings and saves the backup as a template.
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
                /// *   0: the default parameter template.
                /// *   1: a custom parameter template.
                /// *   2: an automatic backup parameter template. After you apply this type of template, the system automatically backs up the original parameter settings and saves the backup as a template.
                /// </summary>
                [NameInMap("ParameterGroupType")]
                [Validation(Required=false)]
                public int? ParameterGroupType { get; set; }

                /// <summary>
                /// The time when the parameter template was last updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether parameter templates exist in the specified region. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("SignalForOptimizeParams")]
        [Validation(Required=false)]
        public bool? SignalForOptimizeParams { get; set; }

    }

}
