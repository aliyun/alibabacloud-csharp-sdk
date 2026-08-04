// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePostPayInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: Internet- and VPC-connected instance</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: VPC-connected instance</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// <para>The disk capacity.</para>
        /// <para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>This parameter is not required if you create a serverless instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1500</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: ultra disk</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: SSD</para>
        /// <remarks>
        /// <para>This parameter is not required if you create a serverless instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The Internet traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <b>DeployType</b> is set to <b>4</b>.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required if you create a serverless instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The traffic specification.</para>
        /// <list type="bullet">
        /// <item><description>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required if you create a serverless instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka.hw.2xlarge</para>
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// <para>The billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1 (default): pay-as-you-go for reserved instances.</description></item>
        /// <item><description>3: pay-as-you-go for serverless reserved specifications + pay-as-you-go for serverless elastic scaling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// <para>The number of partitions to purchase.</para>
        /// <list type="bullet">
        /// <item><description>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.<remarks>
        /// <para>This parameter is not required if the instance is a serverless instance.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>If this parameter is not specified, the instance is placed in the default resource group. You can view the resource group ID in the Resource Management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The settings for the serverless instance. This parameter is required when you create a serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CreatePostPayInstanceRequestServerlessConfig ServerlessConfig { get; set; }
        public class CreatePostPayInstanceRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>The reserved publish traffic specification value. Only integers are supported. The minimum value is 60. This parameter is required for serverless instances.</para>
            /// <remarks>
            /// <para>The actual upper limit is subject to the inventory in the current region. Refer to the purchase page for the available range.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("ReservedPublishCapacity")]
            [Validation(Required=false)]
            public long? ReservedPublishCapacity { get; set; }

            /// <summary>
            /// <para>The reserved subscribe traffic specification value. Only integers are supported. The minimum value is 20. This parameter is required for serverless instances.</para>
            /// <remarks>
            /// <para>The actual upper limit is subject to the inventory in the current region. Refer to the purchase page for the available range.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("ReservedSubscribeCapacity")]
            [Validation(Required=false)]
            public long? ReservedSubscribeCapacity { get; set; }

        }

        /// <summary>
        /// <para>The specification type.</para>
        /// <para>Valid values when PaidType is set to 1 (pay-as-you-go for reserved instances):</para>
        /// <list type="bullet">
        /// <item><description>normal: Standard Edition (shared throughput)</description></item>
        /// <item><description>professional: Professional Edition (shared throughput)</description></item>
        /// <item><description>professionalForHighRead: Professional Edition (shared throughput for high read)</description></item>
        /// </list>
        /// <para>Valid values when PaidType is set to 3 (pay-as-you-go for serverless reserved specifications + pay-as-you-go for serverless elastic scaling):</para>
        /// <list type="bullet">
        /// <item><description>basic: Serverless Basic Edition</description></item>
        /// <item><description>normal: Serverless Standard Edition</description></item>
        /// <item><description>professional: Serverless Professional Edition</description></item>
        /// </list>
        /// <para>For more information about the specification types, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePostPayInstanceRequestTag> Tag { get; set; }
        public class CreatePostPayInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description>N ranges from 1 to 20.</description></item>
            /// <item><description>If this parameter is left empty, all tag keys are matched.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <list type="bullet">
            /// <item><description>N ranges from 1 to 20.</description></item>
            /// <item><description>If the tag key is left empty, this parameter must also be left empty. If this parameter is left empty, all tag values are matched.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
