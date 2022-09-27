// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAccountAttributesResponseBody : TeaModel {
        [NameInMap("AccountAttributeItems")]
        [Validation(Required=false)]
        public DescribeAccountAttributesResponseBodyAccountAttributeItems AccountAttributeItems { get; set; }
        public class DescribeAccountAttributesResponseBodyAccountAttributeItems : TeaModel {
            [NameInMap("AccountAttributeItem")]
            [Validation(Required=false)]
            public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem> AccountAttributeItem { get; set; }
            public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItem : TeaModel {
                [NameInMap("AttributeName")]
                [Validation(Required=false)]
                public string AttributeName { get; set; }

                [NameInMap("AttributeValues")]
                [Validation(Required=false)]
                public DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues AttributeValues { get; set; }
                public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValues : TeaModel {
                    [NameInMap("ValueItem")]
                    [Validation(Required=false)]
                    public List<DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem> ValueItem { get; set; }
                    public class DescribeAccountAttributesResponseBodyAccountAttributeItemsAccountAttributeItemAttributeValuesValueItem : TeaModel {
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public int? Count { get; set; }

                        [NameInMap("DiskCategory")]
                        [Validation(Required=false)]
                        public string DiskCategory { get; set; }

                        [NameInMap("ExpiredTime")]
                        [Validation(Required=false)]
                        public string ExpiredTime { get; set; }

                        [NameInMap("InstanceChargeType")]
                        [Validation(Required=false)]
                        public string InstanceChargeType { get; set; }

                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        [NameInMap("ZoneId")]
                        [Validation(Required=false)]
                        public string ZoneId { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
