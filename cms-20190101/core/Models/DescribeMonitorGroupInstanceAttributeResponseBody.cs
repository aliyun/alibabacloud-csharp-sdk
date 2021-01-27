// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupInstanceAttributeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMonitorGroupInstanceAttributeResponseBodyResources Resources { get; set; }
        public class DescribeMonitorGroupInstanceAttributeResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResource : TeaModel {
                public string InstanceName { get; set; }
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion Region { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion : TeaModel {
                    [NameInMap("AvailabilityZone")]
                    [Validation(Required=false)]
                    public string AvailabilityZone { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc Vpc { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc : TeaModel {
                    [NameInMap("VswitchInstanceId")]
                    [Validation(Required=false)]
                    public string VswitchInstanceId { get; set; }

                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                }
                public string Dimension { get; set; }
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTags Tags { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTagsTag> Tag { get; set; }
                    public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string Category { get; set; }
                public string InstanceId { get; set; }
                public string NetworkType { get; set; }
                public string Desc { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
