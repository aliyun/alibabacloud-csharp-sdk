// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeVSwitchesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VSwitchs")]
        [Validation(Required=false)]
        public List<DescribeVSwitchesResponseBodyVSwitchs> VSwitchs { get; set; }
        public class DescribeVSwitchesResponseBodyVSwitchs : TeaModel {
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            [NameInMap("IzNo")]
            [Validation(Required=false)]
            public string IzNo { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("VSwitchName")]
            [Validation(Required=false)]
            public string VSwitchName { get; set; }

        }

    }

}
