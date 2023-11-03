// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// The information about the parameter template.
        /// </summary>
        [NameInMap("ParamGroup")]
        [Validation(Required=false)]
        public DescribeParameterGroupResponseBodyParamGroup ParamGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParamGroup : TeaModel {
            [NameInMap("ParameterGroup")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParamGroupParameterGroup> ParameterGroup { get; set; }
            public class DescribeParameterGroupResponseBodyParamGroupParameterGroup : TeaModel {
                /// <summary>
                /// The time when the parameter template was created.
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
                /// The database engine version of the instance.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// Indicates whether the restart of an instance is required for the parameter template to take effect. Valid values:
                /// 
                /// *   **0**: A restart is not required.
                /// *   **1**: A restart is required.
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
                /// The details of the parameters.
                /// </summary>
                [NameInMap("ParamDetail")]
                [Validation(Required=false)]
                public DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetail ParamDetail { get; set; }
                public class DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetail : TeaModel {
                    [NameInMap("ParameterDetail")]
                    [Validation(Required=false)]
                    public List<DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetailParameterDetail> ParameterDetail { get; set; }
                    public class DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetailParameterDetail : TeaModel {
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
                public int? ParameterGroupType { get; set; }

                /// <summary>
                /// The time when the parameter template was last updated. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The information about the instance to which the parameter template is applied.
        /// 
        /// >  This parameter is available only for ApsaraDB RDS for PostgreSQL instances.
        /// </summary>
        [NameInMap("RelatedCustinsInfo")]
        [Validation(Required=false)]
        public DescribeParameterGroupResponseBodyRelatedCustinsInfo RelatedCustinsInfo { get; set; }
        public class DescribeParameterGroupResponseBodyRelatedCustinsInfo : TeaModel {
            [NameInMap("RelatedCustinsInfo")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyRelatedCustinsInfoRelatedCustinsInfo> RelatedCustinsInfo { get; set; }
            public class DescribeParameterGroupResponseBodyRelatedCustinsInfoRelatedCustinsInfo : TeaModel {
                /// <summary>
                /// The time when the parameter template was applied.
                /// </summary>
                [NameInMap("AppliedTime")]
                [Validation(Required=false)]
                public string AppliedTime { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
