// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePrePayInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the Confluent components.</para>
        /// <remarks>
        /// <para>This parameter is required if you create a Confluent instance.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public string ConfluentConfigShrink { get; set; }

        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: an instance accessible from the internet and a VPC</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: an instance accessible from a VPC only</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you create a Confluent instance, you cannot specify the deployment type and must set this parameter to 5. After the instance is created, you can configure internet access for each component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// <para>The disk capacity, in GB.</para>
        /// <para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>This parameter is not required if you create a Confluent instance.</para>
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
        /// <para>This parameter is not required if you create a Confluent instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The subscription duration, in months. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Confluent instances: <b>1</b> and <b>12</b></para>
        /// </description></item>
        /// <item><description><para>Kafka instances: <b>1</b></para>
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
        /// <para>The peak internet bandwidth.</para>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if you set <b>DeployType</b> to <b>4</b>.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/72142.html">pay-as-you-go</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required if you create a Confluent instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The I/O specification.</para>
        /// <list type="bullet">
        /// <item><description>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required if you create a Confluent instance.</para>
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
        /// <item><description><para><b>4</b>: subscription for Confluent instances</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// <para>The number of partitions.</para>
        /// <list type="bullet">
        /// <item><description>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required if you create a Confluent instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
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
        /// <para>The ID of the resource group.</para>
        /// <para>If you do not specify this parameter, the instance is placed in the default resource group. You can find the resource group ID in the Resource Group console.</para>
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
        /// <item><description><para><b>normal</b>: Standard Edition (High-write)</para>
        /// </description></item>
        /// <item><description><para><b>professional</b>: Professional Edition (High-write)</para>
        /// </description></item>
        /// <item><description><para><b>professionalForHighRead</b>: Professional Edition (High-read)</para>
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
        /// <para>professional</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The tags to attach to the instance. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePrePayInstanceShrinkRequestTag> Tag { get; set; }
        public class CreatePrePayInstanceShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description><para>The key must be 1 to 128 characters long. It cannot start with aliyun or acs:, nor can it contain http\:// or https\://.</para>
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
            /// <para>The tag value.</para>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// <item><description><para>The value can be 0 to 128 characters long. It cannot start with aliyun or acs:, nor can it contain http\:// or https\://.</para>
            /// </description></item>
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
