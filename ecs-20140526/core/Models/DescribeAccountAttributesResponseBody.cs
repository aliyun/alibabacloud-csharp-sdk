// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAccountAttributesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AccountAttributeItems")]
        [Validation(Required=false)]
        public List<DescribeAccountAttributesResponseBodyAccountAttributeItems> AccountAttributeItems { get; set; }
        public class DescribeAccountAttributesResponseBodyAccountAttributeItems : TeaModel {
            [NameInMap("AttributeName")]
            [Validation(Required=false)]
            public string AttributeName { get; set; }

            [NameInMap("AttributeValues")]
            [Validation(Required=false)]
            public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAttributeValues> AttributeValues { get; set; }
            public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAttributeValues : TeaModel {
                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("InstanceChargeType")]
                [Validation(Required=false)]
                public string InstanceChargeType { get; set; }

            }

        }

    }

}
