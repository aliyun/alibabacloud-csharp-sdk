// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeParameterGroupsResponseBody : TeaModel {
        [NameInMap("ParameterGroups")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupsResponseBodyParameterGroups> ParameterGroups { get; set; }
        public class DescribeParameterGroupsResponseBodyParameterGroups : TeaModel {
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
            public long? ParameterCounts { get; set; }

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
