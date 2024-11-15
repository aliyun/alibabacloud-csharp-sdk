// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePrePayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of Confluent.</para>
        /// <remarks>
        /// <para> When you create an ApsaraMQ for Confluent instance, you must configure this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public string ConfluentConfigShrink { get; set; }

        /// <summary>
        /// <para>The type of the network in which the instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b>: Internet and virtual private cloud (VPC)</description></item>
        /// <item><description><b>5</b>: VPC</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, set the value to 5. After the instance is created, you can specify whether to enable each component.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("DeployType")]
        [Validation(Required=false)]
        public int? DeployType { get; set; }

        /// <summary>
        /// <para>The disk size. Unit: GB</para>
        /// <para>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
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
        /// <item><description><b>0</b>: ultra disk</description></item>
        /// <item><description><b>1</b>: standard SSD</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
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
        /// <item><description><b>1 to 12</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The maximum Internet traffic in the instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>DeployType</b> to <b>4</b>, you must configure this parameter.</description></item>
        /// <item><description>For information about the valid values, see <a href="https://help.aliyun.com/document_detail/72142.html">Pay-as-you-go</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>The maximum traffic in the instance. We recommend that you do not configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>You must set one of <b>IoMax</b> and <b>IoMaxSpec</b>. If both parameters are configured, the value of <b>IoMaxSpec</b> is used. We recommend that you configure only <b>IoMaxSpec</b>.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// <para>The traffic specification of the instance. We recommend that you configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>You must configure one of <b>IoMax</b> and <b>IoMaxSpec</b>. If both parameters are configured, the value of <b>IoMaxSpec</b> is used. We recommend that you configure only <b>IoMaxSpec</b>.</description></item>
        /// <item><description>For more information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka.hw.2xlarge</para>
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: the subscription billing method</description></item>
        /// <item><description><b>4</b>: the subscription billing method for ApsaraMQ for Confluent instances</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// <para>The number of partitions. We recommend that you configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>You must configure one of PartitionNum and TopicQuota. We recommend that you configure only PartitionNum.</description></item>
        /// <item><description>If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
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
        /// <para>If this parameter is left empty, the default resource group is used. You can view the resource group ID on the Resource Group page in the Resource Management console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ac***********7q</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: Standard Edition (High Write)</description></item>
        /// <item><description><b>professional</b>: Professional Edition (High Write)</description></item>
        /// <item><description><b>professionalForHighRead</b>: Professional Edition (High Read)</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
        /// </remarks>
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
            /// <para>The key of tag N.</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>If this parameter is left empty, the keys of all tags are matched.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length and cannot start with acs: or aliyun or contain <a href="http://https://%E3%80%82">http:// or https://.</a></description></item>
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
            /// <para>The value of tag N.</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>This parameter can be left empty.</description></item>
            /// <item><description>The tag value can be 1 to 128 characters in length and cannot start with acs: or aliyun or contain <a href="http://https://%E3%80%82">http:// or https://.</a></description></item>
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
        /// <para>The number of topics. We recommend that you do not configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>You must configure one of PartitionNum and TopicQuota. We recommend that you configure only PartitionNum.</description></item>
        /// <item><description>If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.</description></item>
        /// <item><description>The default value of TopicQuota varies based on the value of IoMaxSpec. If the number of topics that you use exceeds the default value, you are charged additional fees.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create an ApsaraMQ for Confluent instance, you do not need to configure this parameter.</para>
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
