// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class ListSupportResourceTypesResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportResourceTypes")]
        [Validation(Required=false)]
        public List<ListSupportResourceTypesResponseBodySupportResourceTypes> SupportResourceTypes { get; set; }
        public class ListSupportResourceTypesResponseBodySupportResourceTypes : TeaModel {
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("SupportItems")]
            [Validation(Required=false)]
            public List<ListSupportResourceTypesResponseBodySupportResourceTypesSupportItems> SupportItems { get; set; }
            public class ListSupportResourceTypesResponseBodySupportResourceTypesSupportItems : TeaModel {
                [NameInMap("Support")]
                [Validation(Required=false)]
                public bool? Support { get; set; }

                [NameInMap("SupportCode")]
                [Validation(Required=false)]
                public string SupportCode { get; set; }

            }

        }

    }

}
