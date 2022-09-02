// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiGroupsResponseBody : TeaModel {
        [NameInMap("ApiGroupAttributes")]
        [Validation(Required=false)]
        public DescribeApiGroupsResponseBodyApiGroupAttributes ApiGroupAttributes { get; set; }
        public class DescribeApiGroupsResponseBodyApiGroupAttributes : TeaModel {
            [NameInMap("ApiGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttribute> ApiGroupAttribute { get; set; }
            public class DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttribute : TeaModel {
                [NameInMap("BasePath")]
                [Validation(Required=false)]
                public string BasePath { get; set; }

                [NameInMap("BillingStatus")]
                [Validation(Required=false)]
                public string BillingStatus { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("HttpsPolicy")]
                [Validation(Required=false)]
                public string HttpsPolicy { get; set; }

                [NameInMap("IllegalStatus")]
                [Validation(Required=false)]
                public string IllegalStatus { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttributeTags Tags { get; set; }
                public class DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttributeTags : TeaModel {
                    [NameInMap("TagInfo")]
                    [Validation(Required=false)]
                    public List<DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttributeTagsTagInfo> TagInfo { get; set; }
                    public class DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttributeTagsTagInfo : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("TrafficLimit")]
                [Validation(Required=false)]
                public int? TrafficLimit { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
