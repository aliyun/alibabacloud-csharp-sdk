// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The responses code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9FB8EA79-7279-4482-8D6D-3D28EEDD871A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources that are associated with the application group.</para>
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
                /// <para>The name of the cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The resource description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc_test</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The dimensions of the resource that is associated with the application group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;instanceId&quot;:&quot;i-m5e0k0bexac8tykr****&quot;}</para>
                /// </summary>
                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-m5e0k0bexac8tykr****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hostName</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The network type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The region.</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion Region { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceRegion : TeaModel {
                    /// <summary>
                    /// <para>The zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-f</para>
                    /// </summary>
                    [NameInMap("AvailabilityZone")]
                    [Validation(Required=false)]
                    public string AvailabilityZone { get; set; }

                    /// <summary>
                    /// <para>The region ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                }

                /// <summary>
                /// <para>The tag of the resource.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>instanceNetworkType</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>VPC</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The VPC description.</para>
                /// </summary>
                [NameInMap("Vpc")]
                [Validation(Required=false)]
                public DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc Vpc { get; set; }
                public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResourceVpc : TeaModel {
                    /// <summary>
                    /// <para>The VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zew7etgiceg21****</para>
                    /// </summary>
                    [NameInMap("VpcInstanceId")]
                    [Validation(Required=false)]
                    public string VpcInstanceId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-2ze36seq79n992****</para>
                    /// </summary>
                    [NameInMap("VswitchInstanceId")]
                    [Validation(Required=false)]
                    public string VswitchInstanceId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
