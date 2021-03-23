// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class FindCustomizedPropertiesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CustomizedPropertyList")]
        [Validation(Required=false)]
        public FindCustomizedPropertiesResponseBodyCustomizedPropertyList CustomizedPropertyList { get; set; }
        public class FindCustomizedPropertiesResponseBodyCustomizedPropertyList : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<FindCustomizedPropertiesResponseBodyCustomizedPropertyListItems> Items { get; set; }
            public class FindCustomizedPropertiesResponseBodyCustomizedPropertyListItems : TeaModel {
                public long? Id { get; set; }
                public string Name { get; set; }
                public string Value { get; set; }
                public string GmtCreate { get; set; }
                public long? GmtCreateTimestamp { get; set; }
            }
        };

    }

}
