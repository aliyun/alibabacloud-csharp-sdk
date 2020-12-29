// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGrantRulesToCenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GrantRules")]
        [Validation(Required=false)]
        public List<DescribeGrantRulesToCenResponseBodyGrantRules> GrantRules { get; set; }
        public class DescribeGrantRulesToCenResponseBodyGrantRules : TeaModel {
            [NameInMap("ChildInstanceType")]
            [Validation(Required=false)]
            public string ChildInstanceType { get; set; }

            [NameInMap("ChildInstanceRegionId")]
            [Validation(Required=false)]
            public string ChildInstanceRegionId { get; set; }

            [NameInMap("ChildInstanceOwnerId")]
            [Validation(Required=false)]
            public long? ChildInstanceOwnerId { get; set; }

            [NameInMap("ChildInstanceId")]
            [Validation(Required=false)]
            public string ChildInstanceId { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

        }

    }

}
