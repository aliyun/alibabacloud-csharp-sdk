// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// The information about the virtual private cloud (VPC).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Valid values: 1 to 1000000000.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the VPC.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 1000000000.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The dimensions of the resource that is associated with the application group.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMonitorGroupInstanceAttributeResponseBodyResources Resources { get; set; }
        public class DescribeMonitorGroupInstanceAttributeResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// The network type.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The total number of returned pages.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// Specifies whether to return the total number of resources in the specified application group. Valid values:
                /// 
                /// *   true (default value)
                /// *   false
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The resources that are associated with the application group.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion Region { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion : TeaModel {
                    [NameInMap("AvailabilityZone")]
                    [Validation(Required=false)]
                    public string AvailabilityZone { get; set; }

                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// The tags of the resource.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTags Tags { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTagsTag> Tag { get; set; }
                    public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceTagsTag : TeaModel {
                        /// <summary>
                        /// The name of the instance.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The description of the resource.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Vpc")]
                [Validation(Required=false)]
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc Vpc { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc : TeaModel {
                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                    [NameInMap("VswitchInstanceId")]
                    [Validation(Required=false)]
                    public string VswitchInstanceId { get; set; }

                }

            }

        }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the resource. Separate multiple resource IDs with commas (,). You can query the details about a maximum of 20 resources in each request.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
