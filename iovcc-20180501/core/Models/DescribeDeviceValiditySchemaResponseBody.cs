// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeDeviceValiditySchemaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ItemList")]
        [Validation(Required=false)]
        public List<DescribeDeviceValiditySchemaResponseBodyItemList> ItemList { get; set; }
        public class DescribeDeviceValiditySchemaResponseBodyItemList : TeaModel {
            [NameInMap("Minimum")]
            [Validation(Required=false)]
            public float? Minimum { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Maximum")]
            [Validation(Required=false)]
            public float? Maximum { get; set; }

            [NameInMap("ItemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            [NameInMap("EnumListStr")]
            [Validation(Required=false)]
            public string EnumListStr { get; set; }

            [NameInMap("ExclusiveMinimum")]
            [Validation(Required=false)]
            public bool? ExclusiveMinimum { get; set; }

            [NameInMap("MaxLength")]
            [Validation(Required=false)]
            public int? MaxLength { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public string Required { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExclusiveMaximum")]
            [Validation(Required=false)]
            public bool? ExclusiveMaximum { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("MinLength")]
            [Validation(Required=false)]
            public int? MinLength { get; set; }

        }

    }

}
