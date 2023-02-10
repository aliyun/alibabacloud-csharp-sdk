// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskItemTypeResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskItemTypeResponseBodyList> List { get; set; }
        public class DescribeRiskItemTypeResponseBodyList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
