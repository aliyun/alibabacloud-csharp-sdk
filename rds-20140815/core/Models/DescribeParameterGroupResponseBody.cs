// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        [NameInMap("ParamGroup")]
        [Validation(Required=false)]
        public DescribeParameterGroupResponseBodyParamGroup ParamGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParamGroup : TeaModel {
            [NameInMap("ParameterGroup")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParamGroupParameterGroup> ParameterGroup { get; set; }
            public class DescribeParameterGroupResponseBodyParamGroupParameterGroup : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ForceRestart")]
                [Validation(Required=false)]
                public int? ForceRestart { get; set; }

                [NameInMap("ParamCounts")]
                [Validation(Required=false)]
                public int? ParamCounts { get; set; }

                [NameInMap("ParamDetail")]
                [Validation(Required=false)]
                public DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetail ParamDetail { get; set; }
                public class DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetail : TeaModel {
                    [NameInMap("ParameterDetail")]
                    [Validation(Required=false)]
                    public List<DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetailParameterDetail> ParameterDetail { get; set; }
                    public class DescribeParameterGroupResponseBodyParamGroupParameterGroupParamDetailParameterDetail : TeaModel {
                        [NameInMap("ParamName")]
                        [Validation(Required=false)]
                        public string ParamName { get; set; }

                        [NameInMap("ParamValue")]
                        [Validation(Required=false)]
                        public string ParamValue { get; set; }

                    }

                }

                [NameInMap("ParameterGroupDesc")]
                [Validation(Required=false)]
                public string ParameterGroupDesc { get; set; }

                [NameInMap("ParameterGroupId")]
                [Validation(Required=false)]
                public string ParameterGroupId { get; set; }

                [NameInMap("ParameterGroupName")]
                [Validation(Required=false)]
                public string ParameterGroupName { get; set; }

                [NameInMap("ParameterGroupType")]
                [Validation(Required=false)]
                public int? ParameterGroupType { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        [NameInMap("RelatedCustinsInfo")]
        [Validation(Required=false)]
        public DescribeParameterGroupResponseBodyRelatedCustinsInfo RelatedCustinsInfo { get; set; }
        public class DescribeParameterGroupResponseBodyRelatedCustinsInfo : TeaModel {
            [NameInMap("RelatedCustinsInfo")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyRelatedCustinsInfoRelatedCustinsInfo> RelatedCustinsInfo { get; set; }
            public class DescribeParameterGroupResponseBodyRelatedCustinsInfoRelatedCustinsInfo : TeaModel {
                [NameInMap("AppliedTime")]
                [Validation(Required=false)]
                public string AppliedTime { get; set; }

                [NameInMap("DBInstanceName")]
                [Validation(Required=false)]
                public string DBInstanceName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
