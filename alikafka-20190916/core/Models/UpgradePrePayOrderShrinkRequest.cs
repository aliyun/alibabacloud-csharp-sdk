// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpgradePrePayOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Configurations for the Confluent components.</para>
        /// </summary>
        [NameInMap("ConfluentConfig")]
        [Validation(Required=false)]
        public string ConfluentConfigShrink { get; set; }

        /// <summary>
        /// <para>The disk capacity.</para>
        /// <list type="bullet">
        /// <item><description><para>The specified disk capacity must be greater than or equal to the current disk capacity of the instance.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for subscription instances but not for Confluent-series instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("DiskSize")]
        [Validation(Required=false)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// <para>The maximum Internet traffic bandwidth.</para>
        /// <list type="bullet">
        /// <item><description><para>The specified Internet traffic bandwidth must be greater than or equal to the current Internet traffic bandwidth of the instance.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If <b>EipModel</b> is set to <b>true</b>, <b>EipMax</b> must be greater than 0.</para>
        /// </description></item>
        /// <item><description><para>If <b>EipModel</b> is set to <b>false</b>, <b>EipMax</b> must be set to <b>0</b>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EipMax")]
        [Validation(Required=false)]
        public int? EipMax { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: enables Internet access.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: disables Internet access.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for subscription instances but not for Confluent-series instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EipModel")]
        [Validation(Required=false)]
        public bool? EipModel { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-mp919o4v****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The traffic peak (not recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>The specified traffic peak must be greater than or equal to the current traffic peak of the instance.</para>
        /// </description></item>
        /// <item><description><para>You must specify either this parameter or <c>IoMaxSpec</c>. If you specify both, <c>IoMaxSpec</c> takes precedence. We recommend that you specify only <c>IoMaxSpec</c>.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("IoMax")]
        [Validation(Required=false)]
        public int? IoMax { get; set; }

        /// <summary>
        /// <para>The traffic specification (recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>The specified traffic specification must be greater than or equal to the current traffic specification of the instance.</para>
        /// </description></item>
        /// <item><description><para>You must specify either this parameter or <c>IoMax</c>. If you specify both, this parameter takes precedence. We recommend that you specify only this parameter.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for subscription instances but not for Confluent-series instances.</para>
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
        /// <para>4</para>
        /// </summary>
        [NameInMap("PaidType")]
        [Validation(Required=false)]
        public int? PaidType { get; set; }

        /// <summary>
        /// <para>The number of partitions (recommended).</para>
        /// <list type="bullet">
        /// <item><description><para>You must specify either this parameter or <c>TopicQuota</c>. We recommend that you specify only this parameter.</para>
        /// </description></item>
        /// <item><description><para>If you specify both <c>PartitionNum</c> and <c>TopicQuota</c>, the system checks if their values are equivalent under the previous topic pricing model. A mismatch causes the request to fail. If they match, the system uses <c>PartitionNum</c> to process the purchase.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for subscription instances but not for Confluent-series instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public int? PartitionNum { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The specification type.</para>
        /// <para>Valid values for ApsaraMQ for Kafka instances:</para>
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
        /// <para>You cannot downgrade an instance from Professional Edition to Standard Edition. For more information about these specification types, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
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
        /// <item><description><para>You must specify either this parameter or <c>PartitionNum</c>. We recommend that you specify only <c>PartitionNum</c>.</para>
        /// </description></item>
        /// <item><description><para>If you specify both <c>TopicQuota</c> and <c>PartitionNum</c>, the system checks if their values are equivalent under the previous topic pricing model. A mismatch causes the request to fail. If they match, the system uses <c>PartitionNum</c> to process the purchase.</para>
        /// </description></item>
        /// <item><description><para>The default value of this parameter varies based on the traffic specification. You are charged additional fees if the specified value exceeds the default value.</para>
        /// </description></item>
        /// <item><description><para>For the valid values, see <a href="https://help.aliyun.com/document_detail/84737.html">Billing</a>.</para>
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
