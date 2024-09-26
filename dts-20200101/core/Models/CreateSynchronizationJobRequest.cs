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
            /// <para>The instance type of the destination database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database</description></item>
            /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster or PolarDB O Edition cluster</description></item>
            /// <item><description><b>Redis</b>: Redis database</description></item>
            /// <item><description><b>MaxCompute</b>: MaxCompute project</description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Default value: <b>MySQL</b>.</description></item>
            /// <item><description>For more information about the supported source and destination databases, see <a href="https://help.aliyun.com/document_detail/130744.html">Database types, initial synchronization types, and synchronization topologies</a>.</description></item>
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
            /// <para>The instance type of the source database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>MySQL</b>: ApsaraDB RDS for MySQL instance or self-managed MySQL database</description></item>
            /// <item><description><b>PolarDB</b>: PolarDB for MySQL cluster or PolarDB O Edition cluster</description></item>
            /// <item><description><b>Redis</b>: Redis database</description></item>
            /// <item><description><b>DRDS</b>: PolarDB-X instance V1.0</description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Default value: <b>MySQL</b>.</description></item>
            /// <item><description>For more information about the supported source and destination databases, see <a href="https://help.aliyun.com/document_detail/130744.html">Database types, initial synchronization types, and synchronization topologies</a>.</description></item>
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
        /// <para>The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The <b>ClientToken</b> parameter can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>If you set the <b>SourceEndpoint.InstanceType</b> parameter to <b>DRDS</b>, you must specify the DBInstanceCount parameter. This parameter specifies the number of private RDS instances attached to the source PolarDB-X instance. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DBInstanceCount")]
        [Validation(Required=false)]
        public int? DBInstanceCount { get; set; }

        /// <summary>
        /// <para>The ID of the region where the destination database resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para> If the <b>SourceRegion</b> parameter is set to the China (Hong Kong) region or a region outside the Chinese mainland, you must set the DestRegion parameter to the same region ID.</para>
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
        /// <para>The billing method of the data synchronization instance.</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b> (default value): pay-as-you-go</description></item>
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
        /// <para>The billing cycle of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify this parameter only if you set the PayType parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the source database resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceRegion")]
        [Validation(Required=false)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// <para>The specification of the data synchronization instance. Valid values: <b>micro</b>, <b>small</b>, <b>medium</b>, and <b>large</b>.</para>
        /// <remarks>
        /// <para> For more information about the test performance of each specification, see <a href="https://help.aliyun.com/document_detail/26605.html">Specifications of data synchronization instances</a>.</para>
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
        /// <item><description><b>oneway</b>: one-way synchronization</description></item>
        /// <item><description><b>bidirectional</b>: two-way synchronization</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The default value is <b>oneway</b>.</description></item>
        /// <item><description>This parameter can be set to <b>bidirectional</b> only when the <b>SourceEndpoint.InstanceType</b> and <b>DestinationEndpoint.InstanceType</b> parameters are set to <b>MySQL</b>, <b>PolarDB</b>, or <b>Redis</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oneway</para>
        /// </summary>
        [NameInMap("Topology")]
        [Validation(Required=false)]
        public string Topology { get; set; }

        /// <summary>
        /// <para>The subscription length.</para>
        /// <list type="bullet">
        /// <item><description>If the billing cycle is <b>Year</b>, the value range is <b>1 to 5</b>.</description></item>
        /// <item><description>If the billing cycle is <b>Month</b>, the value range is <b>1 to 60</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify this parameter only if you set the PayType parameter to <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

        /// <summary>
        /// <para>The network type. Valid value: <b>Intranet</b>, which indicates virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

    }

}
