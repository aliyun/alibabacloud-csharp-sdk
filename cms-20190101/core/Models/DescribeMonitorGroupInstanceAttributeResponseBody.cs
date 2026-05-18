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

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeMonitorGroupInstanceAttributeResponseBodyResources Resources { get; set; }
        public class DescribeMonitorGroupInstanceAttributeResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeMonitorGroupInstanceAttributeResponseBodyResourcesResource : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Dimension")]
                [Validation(Required=false)]
                public string Dimension { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

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

                [NameInMap("Tags")]
                [Validation(Required=false)]
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
