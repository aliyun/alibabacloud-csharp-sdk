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
                public string CreateTime { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public int? ForceRestart { get; set; }
                public int? ParamCounts { get; set; }
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
                public string ParameterGroupDesc { get; set; }
                public string ParameterGroupId { get; set; }
                public string ParameterGroupName { get; set; }
                public int? ParameterGroupType { get; set; }
                public string UpdateTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
