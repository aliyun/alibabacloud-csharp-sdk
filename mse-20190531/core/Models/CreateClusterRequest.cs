// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The language type of the returned information:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>Billing method, including PREPAY (Subscription) and POSTPAY (Pay-As-You-Go).</para>
        /// <para>This parameter is ignored for the Serverless edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>Engine specifications, with the following values:</para>
        /// <para>[Professional Edition] </para>
        /// <list type="bullet">
        /// <item><description><c>MSE_SC_2_4_60_c</c>: 2 cores, 4GB</description></item>
        /// <item><description><c>MSE_SC_1_2_60_c</c>: 1 core, 2GB</description></item>
        /// <item><description><c>MSE_SC_4_8_60_c</c>: 4 cores, 8GB</description></item>
        /// <item><description><c>MSE_SC_8_16_60_c</c>: 8 cores, 16GB</description></item>
        /// <item><description><c>MSE_SC_16_32_60_c</c>: 16 cores, 32GB</description></item>
        /// </list>
        /// <para>[Developer Edition] </para>
        /// <list type="bullet">
        /// <item><description><c>MSE_SC_1_2_60_c</c>: 1 core, 2GB</description></item>
        /// <item><description><c>MSE_SC_2_4_60_c</c>: 2 cores, 4GB</description></item>
        /// </list>
        /// <para>[Serverless Edition]</para>
        /// <para>Ignore this parameter, or you can fill in <c>MSE_SC_SERVERLESS</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_SC_2_4_60_c</para>
        /// </summary>
        [NameInMap("ClusterSpecification")]
        [Validation(Required=false)]
        public string ClusterSpecification { get; set; }

        /// <summary>
        /// <para>Cluster type, including ZooKeeper, Nacos-Ans.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nacos-Ans</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Cluster version, with the following values:</para>
        /// <para>[Professional Edition] </para>
        /// <list type="bullet">
        /// <item><description><c>NACOS_2_0_0</c>: indicates Nacos 2.x.x version.</description></item>
        /// <item><description><c>ZooKeeper_3_8_0</c>: indicates ZooKeeper 3.8.x version.</description></item>
        /// </list>
        /// <para>[Developer Edition] </para>
        /// <list type="bullet">
        /// <item><description><c>NACOS_2_0_0</c>: indicates Nacos 2.x version.</description></item>
        /// <item><description><c>ZooKeeper_3_8_0</c>: indicates ZooKeeper 3.8.x version.</description></item>
        /// </list>
        /// <para>[Serverless Edition]</para>
        /// <list type="bullet">
        /// <item><description><c>NACOS_2_0_0</c>: indicates Nacos 2.x version.</description></item>
        /// <item><description><c>ZooKeeper_3_8_0</c>: indicates ZooKeeper 3.8.x version.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NACOS_2_0_0</para>
        /// </summary>
        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// <para>Network access type, <c>slb</c> or <c>single_eni</c>; some regions\&quot; Developer Edition only support the <c>single_eni</c> type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>No longer in use</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud-disk-ssd</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        [Obsolete]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>Valid when <c>ConnectionType</c> is <c>single_eni</c>, indicating whether to enable public network access (Elastic IP).</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("EipEnabled")]
        [Validation(Required=false)]
        public bool? EipEnabled { get; set; }

        /// <summary>
        /// <para>Number of instance nodes, with a range limit of 1 to 9.</para>
        /// <para>[Professional Edition] </para>
        /// <list type="bullet">
        /// <item><description>The number of instances must be 3 or more and must be an odd number.</description></item>
        /// </list>
        /// <para>[Developer Edition] </para>
        /// <list type="bullet">
        /// <item><description>The number of instances can only be 1.</description></item>
        /// </list>
        /// <para>[Serverless Edition]</para>
        /// <para>Ignore this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// <para>Custom instance name</para>
        /// 
        /// <b>Example:</b>
        /// <para>tanshuyingtest001</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Required unless under special circumstances, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><c>mse_pro</c>: indicates Professional Edition.</description></item>
        /// <item><description><c>mse_dev</c>: indicates Developer Edition.</description></item>
        /// <item><description><c>mse_serverless</c>: indicates Serverless Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse_pro</para>
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

        /// <summary>
        /// <para>Network type, with the following values:</para>
        /// <list type="bullet">
        /// <item><description><c>privatenet</c>: indicates a private network.</description></item>
        /// <item><description><c>pubnet</c>: indicates a public network.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>privatenet</para>
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>No longer in use</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("PrivateSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PrivateSlbSpecification { get; set; }

        /// <summary>
        /// <para>Valid when <c>ConnectionType</c> is <c>slb</c>. 0 indicates no public network access SLB creation, and values above 1 indicate a fixed bandwidth for public network access SLB; unit: Mbps.</para>
        /// <para>Value range: 0~5000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PubNetworkFlow")]
        [Validation(Required=false)]
        public string PubNetworkFlow { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>No longer in use</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("PubSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PubSlbSpecification { get; set; }

        /// <summary>
        /// <para>The region where the cluster is located, including but not limited to the following regions:</para>
        /// <list type="bullet">
        /// <item><description><c>cn-hangzhou</c>: Hangzhou</description></item>
        /// <item><description><c>cn-beijing</c>: Beijing</description></item>
        /// <item><description><c>cn-shanghai</c>: Shanghai</description></item>
        /// <item><description><c>cn-zhangjiakou</c>: Zhangjiakou</description></item>
        /// <item><description><c>cn-shenzhen</c>: Shenzhen</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Extended request parameters, in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>Resource group ID. For more details about the resource group, see <a href="https://help.aliyun.com/document_detail/457230.html">Basic Information of Resource Group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzcqmoay3dlyq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Valid when <c>ConnectionType</c> is <c>single_eni</c>, indicating the security group type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("SecurityGroupType")]
        [Validation(Required=false)]
        public string SecurityGroupType { get; set; }

        /// <summary>
        /// <para>List of tags to be added. Contains up to 20 items.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>Tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prd</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Switch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp17opt4v18sto39k****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1t50e045b5g7i3p****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
