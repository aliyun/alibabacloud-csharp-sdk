// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ListResourceTypesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<ListResourceTypesResponseBodyResourceTypes> ResourceTypes { get; set; }
        public class ListResourceTypesResponseBodyResourceTypes : TeaModel {
            [NameInMap("FilterKeys")]
            [Validation(Required=false)]
            public List<string> FilterKeys { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("ResourceTypeName")]
            [Validation(Required=false)]
            public string ResourceTypeName { get; set; }

        }

    }

}
