// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiGroupsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ApiGroupAttributes")]
        [Validation(Required=false)]
        public DescribeApiGroupsResponseBodyApiGroupAttributes ApiGroupAttributes { get; set; }
        public class DescribeApiGroupsResponseBodyApiGroupAttributes : TeaModel {
            [NameInMap("ApiGroupAttribute")]
            [Validation(Required=false)]
            public List<DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttribute> ApiGroupAttribute { get; set; }
            public class DescribeApiGroupsResponseBodyApiGroupAttributesApiGroupAttribute : TeaModel {
                public string BasePath { get; set; }
                public string BillingStatus { get; set; }
                public int? TrafficLimit { get; set; }
                public string InstanceId { get; set; }
                public string InstanceType { get; set; }
                public string RegionId { get; set; }
                public string ModifiedTime { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string Description { get; set; }
                public string IllegalStatus { get; set; }
                public string HttpsPolicy { get; set; }
                public string SubDomain { get; set; }
                public string CreatedTime { get; set; }
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
            }
        };

    }

}
