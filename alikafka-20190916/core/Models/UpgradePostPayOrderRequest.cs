// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpgradePostPayOrderRequest : TeaModel {
        /// <summary>
        /// <para>The disk size. Unit: GB.</para>
        /// <list type="bullet">
        /// <item><description>The disk size that you specify must be greater than or equal to the current disk size of the instance.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The Internet traffic for the instance.</para>
        /// <list type="bullet">
        /// <item><description>The Internet traffic that you specify must be greater than or equal to the current Internet traffic of the instance.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set <b>EipModel</b> to <b>true</b>, set <b>EipMax</b> to a value that is greater than 0.</description></item>
        /// <item><description>If you set <b>EipModel</b> to <b>false</b>, set <b>EipMax</b> to <b>0</b>.</description></item>
        /// <item><description>When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables Internet access.</description></item>
        /// <item><description>false: disables Internet access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EipModel")]
        [Validation(Required=false)]
        public bool? EipModel { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-mp919o4v****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum traffic for the instance. We recommend that you do not configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>The maximum traffic that you specify must be greater than or equal to the current maximum traffic of the instance.</description></item>
        /// <item><description>You must configure at least one of IoMax and IoMaxSpec. If you configure both parameters, the value of IoMaxSpec takes effect. We recommend that you configure only IoMaxSpec.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// <para>The traffic specification of the instance. We recommend that you configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>The traffic specification that you specify must be greater than or equal to the current traffic specification of the instance.</description></item>
        /// <item><description>You must configure at least one of IoMax and IoMaxSpec. If you configure both parameters, the value of IoMaxSpec takes effect. We recommend that you configure only IoMaxSpec.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka.hw.6xlarge</para>
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// <para>The number of partitions. We recommend that you configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>You must configure one of PartitionNum and TopicQuota. We recommend that you configure only ParittionNum.</description></item>
        /// <item><description>If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
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
        /// <para>The parameters that are configured for the ApsaraMQ for Kafka serverless instance. When you create a serverless ApsaraMQ for Kafka instance, you must configure these parameters.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public UpgradePostPayOrderRequestServerlessConfig ServerlessConfig { get; set; }
        public class UpgradePostPayOrderRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>The reserved capacity for publishing messages. You can specify only integers for this parameter. Minimum value: 60.</para>
            /// <remarks>
            /// <para> The maximum capacity that you can reserve for an instance varies based on available resources in a region. The reserved capacity range displayed on the buy page shall prevail.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("ReservedPublishCapacity")]
            [Validation(Required=false)]
            public long? ReservedPublishCapacity { get; set; }

            /// <summary>
            /// <para>The reserved capacity for subscribing to messages. You can specify only integers for this parameter. Minimum value: 50.</para>
            /// <remarks>
            /// <para> The maximum capacity that you can reserve for an instance varies based on available resources in a region. The reserved capacity range displayed on the buy page shall prevail.</para>
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
        /// <para>Valid values for this parameter if you set PaidType to 1:</para>
        /// <list type="bullet">
        /// <item><description>normal: Standard Edition (High Write)</description></item>
        /// <item><description>professional: Professional Edition (High Write)</description></item>
        /// <item><description>professionalForHighRead: Professional Edition (High Read)</description></item>
        /// </list>
        /// <para>Valid values for this parameter if you set PaidType to 3:</para>
        /// <list type="bullet">
        /// <item><description>normal: Serverless Standard Edition</description></item>
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
        /// <para>The number of topics. We recommend that you do not configure this parameter.</para>
        /// <list type="bullet">
        /// <item><description>You must configure one of PartitionNum and TopicQuota. We recommend that you configure only ParittionNum.</description></item>
        /// <item><description>If you configure PartitionNum and TopicQuota at the same time, the system verifies whether the price of the partitions equals the price of the topics based on the previous topic-based selling mode. If the price of the partitions does not equal the price of the topics, an error is returned. If the price of the partitions equals the price of the topics, the instance is purchased based on the partition number.</description></item>
        /// <item><description>The default value of TopicQuota varies based on the value of IoMaxSpec. If the number of topics that you consume exceeds the default value, you are charged additional fees.</description></item>
        /// <item><description>For information about the valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When you create an ApsaraMQ for Kafka V3 serverless instance, you do not need to configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
