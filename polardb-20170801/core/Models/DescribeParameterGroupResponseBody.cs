// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeParameterGroupResponseBody : TeaModel {
        [NameInMap("ParameterGroup")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupResponseBodyParameterGroup> ParameterGroup { get; set; }
        public class DescribeParameterGroupResponseBodyParameterGroup : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            [NameInMap("ParameterCounts")]
            [Validation(Required=false)]
            public int? ParameterCounts { get; set; }

            [NameInMap("ParameterDetail")]
            [Validation(Required=false)]
            public List<DescribeParameterGroupResponseBodyParameterGroupParameterDetail> ParameterDetail { get; set; }
            public class DescribeParameterGroupResponseBodyParameterGroupParameterDetail : TeaModel {
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

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
            public string ParameterGroupType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
