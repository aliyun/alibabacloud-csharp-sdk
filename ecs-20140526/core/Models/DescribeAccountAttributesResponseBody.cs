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
        public DescribeAccountAttributesResponseBodyAccountAttributeItems AccountAttributeItems { get; set; }
        public class DescribeAccountAttributesResponseBodyAccountAttributeItems : TeaModel {
            [NameInMap("AccountAttributeItem")]
            [Validation(Required=false)]
            public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem> AccountAttributeItem { get; set; }
            public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem : TeaModel {
                public string AttributeName { get; set; }
                public DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues AttributeValues { get; set; }
                public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues : TeaModel {
                    [NameInMap("ValueItem")]
                    [Validation(Required=false)]
                    public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem> ValueItem { get; set; }
                    public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem : TeaModel {
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
        };

    }

}
