// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMSDdcsAttributesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Attribute")]
        [Validation(Required=false)]
        public QueryMSDdcsAttributesResponseBodyAttribute Attribute { get; set; }
        public class QueryMSDdcsAttributesResponseBodyAttribute : TeaModel {
            [NameInMap("AttributeName")]
            [Validation(Required=false)]
            public string AttributeName { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
        };

    }

}
