// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpgradePostPayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The disk capacity. Unit: GB.</para>
        /// <list type="bullet">
        /// <item><description><para>The disk capacity that you specify must be greater than or equal to the current disk capacity of the instance.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the instance is a serverless instance, you do not need to specify this parameter. This parameter is required for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The Internet traffic.</para>
        /// <list type="bullet">
        /// <item><description>The Internet traffic that you specify must be greater than or equal to the current Internet traffic of the instance.</description></item>
        /// <item><description>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If EipModel is set to true, the value of EipMax must be greater than 0.</description></item>
        /// <item><description>If EipModel is set to false, the value of EipMax must be 0.</description></item>
        /// <item><description>If the instance is a serverless instance, you do not need to specify this parameter.</description></item>
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
        /// <para>Specifies whether the instance requires Internet access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Internet access is required.</para>
        /// </description></item>
        /// <item><description><para>false: Internet access is not required.</para>
        /// <remarks>
        /// <para>This parameter is optional for pay-as-you-go instances. This parameter is required for serverless instances.</para>
        /// </remarks>
        /// </description></item>
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
        /// <para>The peak traffic (not recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>The peak traffic that you specify must be greater than or equal to the current peak traffic of the instance.</para>
        /// </description></item>
        /// <item><description><para>You must specify either the peak traffic or the traffic specification. If you specify both, the traffic specification takes precedence. Specify only the traffic specification.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If the instance is a serverless instance, you do not need to specify this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// <para>The traffic specification (recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>The traffic specification that you specify must be greater than or equal to the current traffic specification of the instance.</para>
        /// </description></item>
        /// <item><description><para>You must specify either the peak traffic or the traffic specification. If you specify both, the traffic specification takes precedence. Specify only the traffic specification.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If the instance is a serverless instance, you do not need to specify this parameter. This parameter is required for pay-as-you-go instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka.hw.6xlarge</para>
        /// </summary>
        [NameInMap("IoMaxSpec")]
        [Validation(Required=false)]
        public string IoMaxSpec { get; set; }

        /// <summary>
        /// <para>The number of partitions (recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify either the number of partitions or the topic specification. Specify only the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>If you specify both the number of partitions and the topic specification, the system validates whether the number of partitions and the topic specification are equivalent based on the legacy topic sales model. If they are not equivalent, an error is returned. If they are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If the instance is a serverless instance, you do not need to specify this parameter. This parameter is required for pay-as-you-go instances.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <para>The settings of the serverless instance. This parameter is required when you change the specifications of a serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// <para>The specification type.</para>
        /// <para>If the PaidType of the instance is 1 (pay-as-you-go), valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: Standard Edition (shared throughput)</description></item>
        /// <item><description>professional: Professional Edition (shared throughput)</description></item>
        /// <item><description>professionalForHighRead: Professional Edition (shared read throughput)</description></item>
        /// </list>
        /// <para>If the PaidType of the instance is 3 (reserved specification pay-as-you-go + serverless elastic scaling pay-as-you-go), valid values:</para>
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
        /// <para>The number of topics (not recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify either the number of partitions or the topic specification. Specify only the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>If you specify both the number of partitions and the topic specification, the system validates whether the number of partitions and the topic specification are equivalent based on the legacy topic sales model. If they are not equivalent, an error is returned. If they are equivalent, the purchase is made based on the number of partitions.</para>
        /// </description></item>
        /// <item><description><para>The default value varies based on the traffic specification. Additional fees are charged if the value exceeds the default value.</para>
        /// </description></item>
        /// <item><description><para>For the value range, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// <remarks>
        /// <para>If the instance is a serverless instance, you do not need to specify this parameter.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("TopicQuota")]
        [Validation(Required=false)]
        public int? TopicQuota { get; set; }

    }

}
