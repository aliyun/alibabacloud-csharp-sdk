// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceGroupResponseBody : TeaModel {
        [NameInMap("Group")]
        [Validation(Required=false)]
        public DescribeDefenseResourceGroupResponseBodyGroup Group { get; set; }
        public class DescribeDefenseResourceGroupResponseBodyGroup : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public string ResourceList { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
