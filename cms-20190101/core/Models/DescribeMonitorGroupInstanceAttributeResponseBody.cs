// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// The responses code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resources that are associated with the application group.
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
                /// The name of the cloud service.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The resource description.
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// The dimensions of the resource that is associated with the application group.
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The network type.
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The region.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion Region { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion : TeaModel {
                    /// <summary>
                    /// The zone.
                    /// </summary>
                    [NameInMap("AvailabilityZone")]
                    [Validation(Required=false)]
                    public string AvailabilityZone { get; set; }

                    /// <summary>
                    /// The region ID.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// The tag of the resource.
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
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The VPC description.
                /// </summary>
                [NameInMap("Vpc")]
                [Validation(Required=false)]
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc Vpc { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc : TeaModel {
                    /// <summary>
                    /// The VPC ID.
                    /// </summary>
                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                    /// <summary>
                    /// The vSwitch ID.
                    /// </summary>
                    [NameInMap("VswitchInstanceId")]
                    [Validation(Required=false)]
                    public string VswitchInstanceId { get; set; }

                }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
