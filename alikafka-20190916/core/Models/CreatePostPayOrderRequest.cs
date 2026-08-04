// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePostPayOrderRequest : TeaModel {
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
        /// <para>5</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// <para>The disk capacity.</para>
        /// <para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing overview</a>.</para>
        /// <remarks>
        /// <para>If you create a serverless instance, you do not need to set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: premium cloud disk</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: SSD</para>
        /// <remarks>
        /// <para>If you create a serverless instance, you do not need to set this parameter.</para>
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
        /// <item><description><para>If <b>DeployType</b> is set to <b>4</b>, this parameter is required.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing overview</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a serverless instance, you do not need to set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The maximum traffic (not recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify one of IoMax and IoMaxSpec. If both parameters are specified, the value of IoMaxSpec takes precedence. Specify only IoMaxSpec.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing overview</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a serverless instance, you do not need to set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// <para>The traffic specification (recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify one of IoMax and IoMaxSpec. If both parameters are specified, the value of IoMaxSpec takes precedence. Specify only IoMaxSpec.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing overview</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a serverless instance, you do not need to set this parameter.</para>
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
        /// <item><description>1 (default): reserved instance with pay-as-you-go billing.</description></item>
        /// <item><description>3: serverless instance with reserved specification pay-as-you-go billing + serverless elastic scaling pay-as-you-go billing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// <para>The number of partitions (recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify one of PartitionNum and TopicQuota. Specify only PartitionNum.</para>
        /// </description></item>
        /// <item><description><para>If both PartitionNum and TopicQuota are specified, the system verifies whether the values are equivalent based on the legacy topic sales model. If the values are not equivalent, the request fails. If the values are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing overview</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a serverless instance, you do not need to set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
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
        /// <para>The settings of the serverless instance. This parameter is required when you create a serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CreatePostPayOrderRequestServerlessConfig ServerlessConfig { get; set; }
        public class CreatePostPayOrderRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>The reserved publish traffic specification value. Only integers are supported. The minimum value is 60. This parameter is required for serverless instances.</para>
            /// <remarks>
            /// <para>The actual upper limit depends on the inventory in the current region. Refer to the purchase page for the available range.</para>
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
            /// <para>The actual upper limit depends on the inventory in the current region. Refer to the purchase page for the available range.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("ReservedSubscribeCapacity")]
            [Validation(Required=false)]
            public long? ReservedSubscribeCapacity { get; set; }

        }

        /// <summary>
        /// <para>The specification type.</para>
        /// <para>Valid values when PaidType is set to 1 (reserved instance with pay-as-you-go billing):</para>
        /// <list type="bullet">
        /// <item><description>normal: Standard Edition (shared throughput for writes)</description></item>
        /// <item><description>professional: Professional Edition (shared throughput for writes)</description></item>
        /// <item><description>professionalForHighRead: Professional Edition (shared throughput for reads)</description></item>
        /// </list>
        /// <para>Valid values when PaidType is set to 3 (serverless instance with reserved specification pay-as-you-go billing + serverless elastic scaling pay-as-you-go billing):</para>
        /// <list type="bullet">
        /// <item><description>basic: Serverless Basic Edition</description></item>
        /// <item><description>normal: Serverless Standard Edition</description></item>
        /// <item><description>professional: Serverless Professional Edition</description></item>
        /// </list>
        /// <para>For more information about these specification types, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePostPayOrderRequestTag> Tag { get; set; }
        public class CreatePostPayOrderRequestTag : TeaModel {
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
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of topics (not recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify one of PartitionNum and TopicQuota. Specify only PartitionNum.</para>
        /// </description></item>
        /// <item><description><para>If both PartitionNum and TopicQuota are specified, the system verifies whether the values are equivalent based on the legacy topic sales model. If the values are not equivalent, the request fails. If the values are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>The default value varies based on the traffic specification. If the value exceeds the default value, additional fees are charged.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing overview</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a serverless instance, you do not need to set this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
