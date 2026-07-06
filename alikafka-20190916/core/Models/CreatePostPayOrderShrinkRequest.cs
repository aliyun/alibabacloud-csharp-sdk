// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePostPayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The deployment type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b>: An instance that is accessible from the Internet and a VPC.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: An instance that is accessible only from a VPC.</para>
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
        /// <para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>Do not specify this parameter if you create a Serverless instance.</para>
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
        /// <item><description><para><b>0</b>: Ultra disk</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: SSD</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Do not specify this parameter if you create a Serverless instance.</para>
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
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Do not specify this parameter if you create a Serverless instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The peak traffic. This parameter is not recommended.</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter or \<c>IoMaxSpec\\</c>. If you specify both parameters, the value of \<c>IoMaxSpec\\</c> takes precedence. We recommend that you specify only \<c>IoMaxSpec\\</c>.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Do not specify this parameter if you create a Serverless instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// <para>The traffic specification. This parameter is recommended.</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter or \<c>IoMax\\</c>. If you specify both parameters, the value of this parameter takes precedence. We recommend that you specify only this parameter.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Do not specify this parameter if you create a Serverless instance.</para>
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
        /// <item><description><para>1 (default): Pay-as-you-go for a reserved instance.</para>
        /// </description></item>
        /// <item><description><para>3: Pay-as-you-go for a reserved Serverless instance and pay-as-you-go for elastic scaling of a Serverless instance.</para>
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
        /// <para>The number of partitions. This parameter is recommended.</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter or \<c>TopicQuota\\</c>. We recommend that you specify only this parameter.</para>
        /// </description></item>
        /// <item><description><para>If you specify both this parameter and \<c>TopicQuota\\</c>, the system verifies whether the values of the two parameters are equivalent based on the previous topic-based sales model. If the values are not equivalent, the system returns a failure. If the values are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Do not specify this parameter if you create a Serverless instance.</para>
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
        /// <para>The ID of the resource group.</para>
        /// <para>If you do not set this parameter, the instance is added to the default resource group. You can view the resource group ID in the Resource Group console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The settings of the Serverless instance. This parameter is required if you create a Serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// <para>The specification type.</para>
        /// <para>If you set \<c>PaidType\\</c> to 1 (pay-as-you-go for a reserved instance), valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>normal: Standard Edition (High-write)</para>
        /// </description></item>
        /// <item><description><para>professional: Professional Edition (High-write)</para>
        /// </description></item>
        /// <item><description><para>professionalForHighRead: Professional Edition (High-read)</para>
        /// </description></item>
        /// </list>
        /// <para>If you set \<c>PaidType\\</c> to 3 (pay-as-you-go for a reserved Serverless instance and pay-as-you-go for elastic scaling of a Serverless instance), valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para>basic: Serverless Basic Edition</para>
        /// </description></item>
        /// <item><description><para>normal: Serverless Standard Edition</para>
        /// </description></item>
        /// <item><description><para>professional: Serverless Professional Edition</para>
        /// </description></item>
        /// </list>
        /// <para>For more information about these specification types, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
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
        public List<CreatePostPayOrderShrinkRequestTag> Tag { get; set; }
        public class CreatePostPayOrderShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <list type="bullet">
            /// <item><description><para>N can be an integer from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>If this parameter is empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length. It cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c> and cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
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
            /// <item><description><para>N can be an integer from 1 to 20.</para>
            /// </description></item>
            /// <item><description><para>This parameter must be empty if the tag key is empty. If this parameter is empty, all tag values are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length. It cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c> and cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
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
        /// <para>The number of topics. This parameter is not recommended.</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify this parameter or \<c>PartitionNum\\</c>. We recommend that you specify only \<c>PartitionNum\\</c>.</para>
        /// </description></item>
        /// <item><description><para>If you specify both this parameter and \<c>PartitionNum\\</c>, the system verifies whether the values of the two parameters are equivalent based on the previous topic-based sales model. If the values are not equivalent, the system returns a failure. If the values are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>The default value of this parameter varies based on the traffic specification. You are charged for the extra topics that exceed the default value.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Do not specify this parameter if you create a Serverless instance.</para>
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
