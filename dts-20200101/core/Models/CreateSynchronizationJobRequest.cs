// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateSynchronizationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public CreateSynchronizationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class CreateSynchronizationJobRequestDestinationEndpoint : TeaModel {
            /// <summary>
            /// <para>目标库的实例类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b>：MySQL数据库（包括RDS MySQL和自建MySQL）。</description></item>
            /// <item><description><b>PolarDB</b>：PolarDB集群（仅支持MySQL或兼容Oracle语法的引擎）。</description></item>
            /// <item><description><b>Redis</b>：Redis数据库。</description></item>
            /// <item><description><b>MaxCompute</b>：MaxCompute实例。</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>默认取值为<b>MySQL</b>。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>关于支持的源库和目标库对应情况，请参见支持的<a href="https://help.aliyun.com/document_detail/130744.html">数据库、同步初始化类型和同步拓扑</a>。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public CreateSynchronizationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class CreateSynchronizationJobRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>源库的实例类型，取值：</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b>：MySQL数据库（包括RDS MySQL和自建MySQL）。</description></item>
            /// <item><description><b>PolarDB</b>：PolarDB集群（仅支持MySQL或兼容Oracle语法的引擎）。</description></item>
            /// <item><description><b>Redis</b>：Redis数据库。</description></item>
            /// <item><description><b>DRDS</b>：云原生分布式数据库PolarDB-X 1.0。</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>默认取值为<b>MySQL</b>。</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>关于支持的源库和目标库对应情况，请参见支持的<a href="https://help.aliyun.com/document_detail/130744.html">数据库、同步初始化类型和同步拓扑</a>。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because it will be deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Generate a value from your client to ensure uniqueness across different requests. <b>ClientToken</b> supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of private custom ApsaraDB RDS instances attached to the source PolarDB-X instance. This parameter is required when <b>SourceEndpoint.InstanceType</b> is set to <b>DRDS</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DBInstanceCount")]
        [Validation(Required=false)]
        public int? DBInstanceCount { get; set; }

        /// <summary>
        /// <para>The region ID of the destination database for data synchronization. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <remarks>
        /// <para>If the region specified by the <b>SourceRegion</b> parameter is Hong Kong (China) or a region outside China, set this parameter to the same region ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestRegion")]
        [Validation(Required=false)]
        public string DestRegion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go. This is the default value.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing method of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: annual subscription.</description></item>
        /// <item><description><b>Month</b>: monthly subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when <b>PayType</b> is set to <b>PrePaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region ID of the data synchronization instance. Set this parameter to the same value as the <b>DestRegion</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The region ID of the source database for data synchronization. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The specification of the data synchronization link. Valid values: <b>micro</b>, <b>small</b>, <b>medium</b>, <b>large</b>.</para>
        /// <remarks>
        /// <para>For more information about the description and performance test results of each specification, see <a href="https://help.aliyun.com/document_detail/26605.html">Specifications of data synchronization links</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>small</para>
        /// </summary>
        [NameInMap("SynchronizationJobClass")]
        [Validation(Required=false)]
        public string SynchronizationJobClass { get; set; }

        /// <summary>
        /// <para>The synchronization topology. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oneway</b>: one-way synchronization.</description></item>
        /// <item><description><b>bidirectional</b>: two-way synchronization.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Default value: <b>oneway</b>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can set this parameter to <b>bidirectional</b> only when both <b>SourceEndpoint.InstanceType</b> and <b>DestinationEndpoint.InstanceType</b> are set to <b>MySQL</b>, <b>PolarDB</b>, or <b>Redis</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oneway</para>
        /// </summary>
        [NameInMap("Topology")]
        [Validation(Required=false)]
        public string Topology { get; set; }

        /// <summary>
        /// <para>The subscription duration of the subscription instance.</para>
        /// <list type="bullet">
        /// <item><description>If the billing method is set to <b>Year</b>, valid values are <b>1 to 5</b>.</description></item>
        /// <item><description>If the billing method is set to <b>Month</b>, valid values are <b>1 to 60</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when <b>PayType</b> is set to <b>PrePaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>The network type for Data Transmission Service. Set the value to <b>Intranet</b> (Express Connect).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

    }

}
