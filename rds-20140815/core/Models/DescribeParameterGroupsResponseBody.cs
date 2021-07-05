// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        [NameInMap("SignalForOptimizeParams")]
        [Validation(Required=false)]
        public bool? SignalForOptimizeParams { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ParameterGroups")]
        [Validation(Required=false)]
        public DescribeParameterGroupsResponseBodyParameterGroups ParameterGroups { get; set; }
        public class DescribeParameterGroupsResponseBodyParameterGroups : TeaModel {
            [NameInMap("ParameterGroup")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup> ParameterGroup { get; set; }
            public class DescribeParameterGroupsResponseBodyParameterGroupsParameterGroup : TeaModel {
                public string UpdateTime { get; set; }
                public string ParameterGroupDesc { get; set; }
                public string CreateTime { get; set; }
                public int? ForceRestart { get; set; }
                public string ParameterGroupId { get; set; }
                public string ParameterGroupName { get; set; }
                public string Engine { get; set; }
                public int? ParamCounts { get; set; }
                public string EngineVersion { get; set; }
                public int? ParameterGroupType { get; set; }
            }
        };

    }

}
