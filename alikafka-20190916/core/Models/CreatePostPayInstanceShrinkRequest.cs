// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePostPayInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: instance that is accessible over the internet and a VPC</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: instance that is accessible only over a VPC</para>
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
        /// <para>For more information about the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>This parameter is not required when you create a Serverless instance.</para>
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
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required when you create a Serverless instance.</para>
        /// </remarks>
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
        /// <item><description><para>This parameter is required if you set <b>DeployType</b> to <b>4</b>.</para>
        /// </description></item>
        /// <item><description><para>For more information about the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required when you create a Serverless instance.</para>
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
        /// <item><description>For more information about the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required when you create a Serverless instance.</para>
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
        /// <item><description><para>1 (default): pay-as-you-go for reserved instances.</para>
        /// </description></item>
        /// <item><description><para>3: pay-as-you-go for reserved capacity and elastic scaling of Serverless instances.</para>
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
        /// <para>The number of partitions.</para>
        /// <list type="bullet">
        /// <item><description>For more information about the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not required if the instance is a Serverless instance.</para>
        /// </remarks>
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
        /// <para>The ID of the resource group.</para>
        /// <para>If you do not specify this parameter, the instance is added to the default resource group. You can view the resource group ID in the Resource Group console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The settings of the Serverless instance. This parameter is required when you create a Serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// <para>The edition of the instance.</para>
        /// <para>If you set the PaidType parameter to 1 (pay-as-you-go for reserved instances), valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>normal: Standard Edition (High-write)</para>
        /// </description></item>
        /// <item><description><para>professional: Professional Edition (High-write)</para>
        /// </description></item>
        /// <item><description><para>professionalForHighRead: Professional Edition (High-read)</para>
        /// </description></item>
        /// </list>
        /// <para>If you set the PaidType parameter to 3 (pay-as-you-go for reserved capacity and elastic scaling of Serverless instances), valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>basic: Serverless Basic Edition</para>
        /// </description></item>
        /// <item><description><para>normal: Serverless Standard Edition</para>
        /// </description></item>
        /// <item><description><para>professional: Serverless Professional Edition</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about these instance editions, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("SpecType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreatePostPayInstanceShrinkRequestTag> Tag { get; set; }
        public class CreatePostPayInstanceShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>The value of N can be from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is left empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http\:// or https\://.</para>
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
            /// <item><description><para>The value of N can be from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>If the tag key is empty, this parameter must also be empty. If this parameter is empty, all tag values are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http\:// or https\://.</para>
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
