// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreatePostPayOrderRequest : TeaModel {
        /// <summary>
        /// <para>The deployment mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b>: deploys the instance that allows access from the Internet and a VPC.</description></item>
        /// <item><description><b>5</b>: deploys the instance that allows access only from a VPC.</description></item>
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
        /// <para>The disk size.</para>
        /// <para>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para> If you create a serverless ApsaraMQ for Kafka instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The disk type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: ultra disk</description></item>
        /// <item><description><b>1</b>: standard SSD</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create a serverless ApsaraMQ for Kafka instance, you do not need to configure this parameter.</para>
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
        /// <item><description>If you set <b>DeployType</b> to <b>4</b>, you must configure this parameter.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create a serverless ApsaraMQ for Kafka instance, you do not need to configure this parameter.</para>
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
        /// <item><description>You must configure at least one of IoMax and IoMaxSpec. If you configure both parameters, the value of IoMaxSpec takes effect. We recommend that you configure only IoMaxSpec.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create a serverless ApsaraMQ for Kafka instance, you do not need to configure this parameter.</para>
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
        /// <item><description>You must configure at least one of IoMax and IoMaxSpec. If you configure both parameters, the value of IoMaxSpec takes effect. We recommend that you configure only IoMaxSpec.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create a serverless ApsaraMQ for Kafka instance, you do not need to configure this parameter.</para>
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
        /// <item><description>1: pay-as-you-go (reserved capacity).</description></item>
        /// <item><description>3: pay-as-you-go (reserved capacity) + pay-as-you-go (on-demand capacity)</description></item>
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
        /// <item><description>You must configure one of PartitionNum and TopicQuota. We recommend that you configure only ParittionNum.</description></item>
        /// <item><description>If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create a serverless ApsaraMQ for Kafka instance, you do not need to configure this parameter.</para>
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
        /// <para>The parameters configured for the serverless ApsaraMQ for Kafka instance. These parameters are required only when you create a serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CreatePostPayOrderRequestServerlessConfig ServerlessConfig { get; set; }
        public class CreatePostPayOrderRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>The reserved capacity for publishing messages. You can specify only an integer for this parameter. Minimum value: 60.</para>
            /// <remarks>
            /// <para> The actual maximum reserved capacity for publishing messages varies based on available resources in the region. The actual range displayed on the buy page shall prevail.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("ReservedPublishCapacity")]
            [Validation(Required=false)]
            public long? ReservedPublishCapacity { get; set; }

            /// <summary>
            /// <para>The reserved capacity for subscribing to messages. You can specify only an integer for this parameter. Minimum value: 20.</para>
            /// <remarks>
            /// <para> The actual maximum reserved capacity for subscribing to messages varies based on available resources in the region. The actual range displayed on the buy page shall prevail.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("ReservedSubscribeCapacity")]
            [Validation(Required=false)]
            public long? ReservedSubscribeCapacity { get; set; }

        }

        /// <summary>
        /// <para>The instance edition.</para>
        /// <para>Valid values if you set PaidType to 1:</para>
        /// <list type="bullet">
        /// <item><description>normal: Standard Edition (High Write)</description></item>
        /// <item><description>professional: Professional Edition (High Write)</description></item>
        /// <item><description>professionalForHighRead: Professional Edition (High Read)</description></item>
        /// </list>
        /// <para>Valid values if you set PaidType to 3:</para>
        /// <list type="bullet">
        /// <item><description>normal: Serverless Standard Edition</description></item>
        /// </list>
        /// <para>For more information about the instance editions, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
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
        public List<CreatePostPayOrderRequestTag> Tag { get; set; }
        public class CreatePostPayOrderRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N.</para>
            /// <list type="bullet">
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>If this parameter is left empty, the keys of all tags are matched.</description></item>
            /// <item><description>The tag key must be up to 128 characters in length. It cannot start with acs: or aliyun or contain <a href="http://https://%E3%80%82">http:// or https://.</a></description></item>
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
            /// <item><description>If you do not specify a tag key, you cannot specify a tag value. If this parameter is not configured, all tag values are matched.</description></item>
            /// <item><description>The tag value must be 1 to 128 characters in length. It cannot start with acs: or aliyun or contain <a href="http://https://%E3%80%82">http:// or https://.</a></description></item>
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
        /// <item><description>You must configure one of PartitionNum and TopicQuota. We recommend that you configure only ParittionNum.</description></item>
        /// <item><description>If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.</description></item>
        /// <item><description>The default value of TopicQuota varies based on the value of IoMaxSpec. If the number of topics that you consume exceeds the default value, you are charged additional fees.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you create a serverless ApsaraMQ for Kafka instance, you do not need to configure this parameter.</para>
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
