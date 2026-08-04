// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePrePayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The Confluent component configurations.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a Confluent instance.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public string ConfluentConfigShrink { get; set; }

        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: Internet- and VPC-connected instance</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: VPC-connected instance</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a Confluent instance, the deployment type is not supported. You can only set this parameter to 5. After the purchase, you can configure whether to enable public access for each component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// <para>The disk capacity. Unit: GB.</para>
        /// <para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If you create a Confluent instance, you do not need to specify this parameter.</para>
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
        /// <item><description><para><b>0</b>: ultra cloud disk</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: SSD</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a Confluent instance, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: months. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Confluent instances: 1 or 12</b></description></item>
        /// <item><description><b>Kafka instances: 1</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The public network traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <b>DeployType</b> is set to <b>4</b>.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/72142.html">Pay-as-you-go billing method</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a Confluent instance, you do not need to specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The peak traffic (not recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify at least one of <b>IoMax</b> and <b>IoMaxSpec</b>. If you specify both, <b>IoMaxSpec</b> takes precedence. We recommend that you specify only <b>IoMaxSpec</b>.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a Confluent instance, you do not need to specify this parameter.</para>
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
        /// <item><description><para>You must specify at least one of <b>IoMax</b> and <b>IoMaxSpec</b>. If you specify both, <b>IoMaxSpec</b> takes precedence. We recommend that you specify only <b>IoMaxSpec</b>.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If you create a Confluent instance, you do not need to specify this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <item><description><para><b>0</b>: subscription</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Confluent subscription</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// <para>The number of partitions (recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify either the number of partitions or the topic specification. We recommend that you specify only the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>If you specify both the number of partitions and the topic specification, the system verifies whether the number of partitions and the topic specification are equivalent based on the legacy topic sales model. If they are not equivalent, the request fails. If they are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a Confluent instance, you do not need to specify this parameter.</para>
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
        /// <para>If you do not specify this parameter, the instance is placed in the default resource group. You can view the resource group ID in the Resource Group console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The specification type.</para>
        /// <para>Valid values for ApsaraMQ for Kafka instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal</b>: Normal Edition (shared high-write)</para>
        /// </description></item>
        /// <item><description><para><b>professional</b>: Professional Edition (shared high-write)</para>
        /// </description></item>
        /// <item><description><para><b>professionalForHighRead</b>: Professional Edition (shared high-read)</para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for Confluent instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>professional</b>: Professional Edition</para>
        /// </description></item>
        /// <item><description><para><b>enterprise</b>: Enterprise Edition</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePrePayOrderShrinkRequestTag> Tag { get; set; }
        public class CreatePrePayOrderShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is left empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// </description></item>
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
            /// <item><description><para>N ranges from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>This parameter can be left empty.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// </description></item>
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
        /// <item><description><para>You must specify either the number of partitions or the topic specification. We recommend that you specify only the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>If you specify both the number of partitions and the topic specification, the system verifies whether the number of partitions and the topic specification are equivalent based on the legacy topic sales model. If they are not equivalent, the request fails. If they are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>The default value varies based on the traffic specification. Additional fees are charged if the value exceeds the default value.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If you create a Confluent instance, you do not need to specify this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
