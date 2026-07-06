// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePrePayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of Confluent components.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a Confluent series instance.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public string ConfluentConfigShrink { get; set; }

        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: Internet/VPC instance</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: VPC instance</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you cannot select the deployment type. You can only set the value to 5. After the purchase, you can adjust whether each component is open to the Internet.</para>
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
        /// <para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you do not need to pass this parameter.</para>
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
        /// <item><description><para><b>0</b>: ultra disk</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: SSD</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you do not need to pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Unit: month. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Confluent instances: 1 or 12</b></para>
        /// </description></item>
        /// <item><description><para><b>Kafka instances: 1</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The Internet traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>DeployType</b> is set to <b>4</b>, you must specify this parameter.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/72142.html">pay-as-you-go</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you do not need to pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The traffic peak (not recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify either <b>IoMax</b> or <b>IoMaxSpec</b>. If you specify both parameters, <b>IoMaxSpec</b> takes precedence. We recommend that you specify only <b>IoMaxSpec</b>.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you do not need to pass this parameter.</para>
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
        /// <item><description><para>You must specify either <b>IoMax</b> or <b>IoMaxSpec</b>. If you specify both parameters, <b>IoMaxSpec</b> takes precedence. We recommend that you specify only <b>IoMaxSpec</b>.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you do not need to pass this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka.hw.2xlarge</para>
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: subscription</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: Confluent series subscription</para>
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
        /// <item><description><para>If you specify both the number of partitions and the topic specification, the system verifies whether the number of partitions is equivalent to the topic specification based on the old topic sales model. If they are not equivalent, the system returns a failure. If they are equivalent, the system makes the purchase based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you do not need to pass this parameter.</para>
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
        /// <para>If you do not specify this parameter, the instance is added to the default resource group. You can view the resource group ID in the Resource Group console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The specification type.</para>
        /// <para>Valid values for Kafka instances:</para>
        /// <list type="bullet">
        /// <item><description><para><b>normal</b>: Standard Edition (high write)</para>
        /// </description></item>
        /// <item><description><para><b>professional</b>: Professional Edition (high write)</para>
        /// </description></item>
        /// <item><description><para><b>professionalForHighRead</b>: Professional Edition (high read)</para>
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
        /// <para>The list of tags.</para>
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
            /// <item><description><para>If this parameter is empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http\:// or https\://.</para>
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
            /// <item><description><para>This parameter can be empty.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http\:// or https\://.</para>
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
        /// <item><description><para>If you specify both the number of partitions and the topic specification, the system verifies whether the number of partitions is equivalent to the topic specification based on the old topic sales model. If they are not equivalent, the system returns a failure. If they are equivalent, the system makes the purchase based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>The default value varies based on the traffic specification. Additional fees are charged if the value exceeds the default value.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you are creating a Confluent series instance, you do not need to pass this parameter.</para>
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
