// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20160314.Models
{
    public class DescribeResourceFilterAttributesResponseBody : TeaModel {
        [NameInMap("FilterAttributes")]
        [Validation(Required=false)]
        public DescribeResourceFilterAttributesResponseBodyFilterAttributes FilterAttributes { get; set; }
        public class DescribeResourceFilterAttributesResponseBodyFilterAttributes : TeaModel {
            [NameInMap("FilterAttribute")]
            [Validation(Required=false)]
            public List<DescribeResourceFilterAttributesResponseBodyFilterAttributesFilterAttribute> FilterAttribute { get; set; }
            public class DescribeResourceFilterAttributesResponseBodyFilterAttributesFilterAttribute : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SupportOperations")]
                [Validation(Required=false)]
                public DescribeResourceFilterAttributesResponseBodyFilterAttributesFilterAttributeSupportOperations SupportOperations { get; set; }
                public class DescribeResourceFilterAttributesResponseBodyFilterAttributesFilterAttributeSupportOperations : TeaModel {
                    [NameInMap("SupportOperation")]
                    [Validation(Required=false)]
                    public List<string> SupportOperation { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public DescribeResourceFilterAttributesResponseBodyFilterAttributesFilterAttributeValues Values { get; set; }
                public class DescribeResourceFilterAttributesResponseBodyFilterAttributesFilterAttributeValues : TeaModel {
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public List<string> Value { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
