// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageSupportInstanceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The key of filter N. Only the image ID can be used to filter instance types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>imagId: image ID</description></item>
        /// <item><description>filter: image ID</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>m-o6w3gy99qf89rkga****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>{
        ///     &quot;RequestId&quot;: &quot;CF661E2D-4AFE-4BCD-959A-A65E14416B44&quot;,
        ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,
        ///     &quot;ImageId&quot;: &quot;ubuntu_16_0402_64_20G_alibase_20180409.vhd&quot;,
        ///     &quot;InstanceTypes&quot;: {
        ///         &quot;InstanceType&quot;: [{
        ///             &quot;InstanceTypeId&quot;: &quot;ecs.t1.xsmall&quot;,
        ///             &quot;CpuCoreCount&quot;: 1,
        ///             &quot;MemorySize&quot;: 0.5,
        ///             &quot;InstanceTypeFamily&quot;: &quot;ecs.t1&quot;
        ///         },
        ///         {
        ///             &quot;InstanceTypeId&quot;: &quot;ecs.t1.small&quot;,
        ///             &quot;CpuCoreCount&quot;: 1,
        ///             &quot;MemorySize&quot;: 1,
        ///             &quot;InstanceTypeFamily&quot;: &quot;ecs.t1&quot;
        ///         }]
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public DescribeImageSupportInstanceTypesResponseBodyInstanceTypes InstanceTypes { get; set; }
        public class DescribeImageSupportInstanceTypesResponseBodyInstanceTypes : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public List<DescribeImageSupportInstanceTypesResponseBodyInstanceTypesInstanceType> InstanceType { get; set; }
            public class DescribeImageSupportInstanceTypesResponseBodyInstanceTypesInstanceType : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs of the instance type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// <para>DescribeImageSupportInstanceTypes</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.t1</para>
                /// </summary>
                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                /// <summary>
                /// <para>Queries the instance types supported by an image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.t1.xsmall</para>
                /// </summary>
                [NameInMap("InstanceTypeId")]
                [Validation(Required=false)]
                public string InstanceTypeId { get; set; }

                /// <summary>
                /// <para>The memory size of the instance type. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public float? MemorySize { get; set; }

            }

        }

        /// <summary>
        /// <para>{
        ///     &quot;RequestId&quot;: &quot;CF661E2D-4AFE-4BCD-959A-A65E14416B44&quot;,
        ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,
        ///     &quot;ImageId&quot;: &quot;ubuntu_16_0402_64_20G_alibase_20180409.vhd&quot;,
        ///     &quot;InstanceTypes&quot;: {
        ///         &quot;InstanceType&quot;: [{
        ///             &quot;InstanceTypeId&quot;: &quot;ecs.t1.xsmall&quot;,
        ///             &quot;CpuCoreCount&quot;: 1,
        ///             &quot;MemorySize&quot;: 0.5,
        ///             &quot;InstanceTypeFamily&quot;: &quot;ecs.t1&quot;
        ///         },
        ///         {
        ///             &quot;InstanceTypeId&quot;: &quot;ecs.t1.small&quot;,
        ///             &quot;CpuCoreCount&quot;: 1,
        ///             &quot;MemorySize&quot;: 1,
        ///             &quot;InstanceTypeFamily&quot;: &quot;ecs.t1&quot;
        ///         }]
        ///     }
        /// }</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
