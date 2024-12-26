// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
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
        /// <para>The billing method. Valid values: PREPAY and POSTPAY.</para>
        /// <para>Ignore this parameter for serverless instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The engine specifications. Valid values:</para>
        /// <para>[Professional Edition]</para>
        /// <list type="bullet">
        /// <item><description><c>MSE_SC_2_4_60_c</c>: 2 vCPUs and 4 GB of memory</description></item>
        /// <item><description><c>MSE_SC_1_2_60_c</c>: 1 vCPU and 2 GB of memory</description></item>
        /// <item><description><c>MSE_SC_4_8_60_c</c>: 4 vCPUs and 8 GB of memory</description></item>
        /// <item><description><c>MSE_SC_8_16_60_c</c>: 8 vCPUs and 16 GB of memory</description></item>
        /// <item><description><c>MSE_SC_16_32_60_c</c>: 16 vCPUs and 32 GB of memory</description></item>
        /// </list>
        /// <para>[Developer Edition]</para>
        /// <list type="bullet">
        /// <item><description><c>MSE_SC_1_2_60_c</c>: 1 vCPU and 2 GB of memory</description></item>
        /// <item><description><c>MSE_SC_2_4_60_c</c>: 2 vCPUs and 4 GB of memory</description></item>
        /// </list>
        /// <para>[Serverless Edition]</para>
        /// <para>Ignore this parameter or set this parameter to <c>MSE_SC_SERVERLESS</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_SC_2_4_60_c</para>
        /// </summary>
        [NameInMap("ClusterSpecification")]
        [Validation(Required=false)]
        public string ClusterSpecification { get; set; }

        /// <summary>
        /// <para>The type of the instance. Valid values: ZooKeeper and Nacos-Ans.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nacos-Ans</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The engine version of the instance. Valid values:</para>
        /// <para>[Professional Edition]</para>
        /// <list type="bullet">
        /// <item><description><c>NACOS_2_0_0</c></description></item>
        /// <item><description><c>ZooKeeper_3_8_0</c></description></item>
        /// </list>
        /// <para>[Developer Edition]</para>
        /// <list type="bullet">
        /// <item><description><c>NACOS_2_0_0</c></description></item>
        /// <item><description><c>ZooKeeper_3_8_0</c></description></item>
        /// </list>
        /// <para>[Serverless Edition]</para>
        /// <list type="bullet">
        /// <item><description><c>NACOS_2_0_0</c></description></item>
        /// <item><description><c>ZooKeeper_3_8_0</c></description></item>
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
        /// <para>The network connection type. Valid values: <c>slb</c> or <c>single_eni</c>. For instances of the Developer Edition in some regions, only the value <c>single_eni</c> is supported.</para>
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
        /// <para>This parameter is obsolete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud-disk-ssd</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        [Obsolete]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable elastic IP addresses. This parameter is valid only if the ConnectionType parameter is set to <c>single_eni</c>.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("EipEnabled")]
        [Validation(Required=false)]
        public bool? EipEnabled { get; set; }

        /// <summary>
        /// <para>The number of nodes in the instance. Valid values: 1 to 9.</para>
        /// <para>[Professional Edition]</para>
        /// <list type="bullet">
        /// <item><description>The value must be greater than or equal to 3 and must be an odd number.</description></item>
        /// </list>
        /// <para>[Developer Edition]</para>
        /// <list type="bullet">
        /// <item><description>The value must be 1.</description></item>
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
        /// <para>The custom name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tanshuyingtest001</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Configure this parameter unless otherwise specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>mse_pro</c>: Professional Edition</description></item>
        /// <item><description><c>mse_dev</c>: Developer Edition</description></item>
        /// <item><description><c>mse_dev</c>: Serverless Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse_pro</para>
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

        /// <summary>
        /// <para>The network type of the MSE instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>privatenet</c>: VPC</description></item>
        /// <item><description><c>pubnet</c>: Internet</description></item>
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
        /// <para>This parameter is obsolete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("PrivateSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PrivateSlbSpecification { get; set; }

        /// <summary>
        /// <para>This parameter is valid only if the ConnectionType parameter is set to <c>slb</c>. The value 0 indicates that the Server Load Balancer (SLB) instance is not connected over the Internet. A value greater than 1 indicates the fixed bandwidth that is used to access the SLB instance over the Internet. Unit: Mbit/s.</para>
        /// <para>Valid values: 0 to 5000.</para>
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
        /// <para>This parameter is obsolete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("PubSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PubSlbSpecification { get; set; }

        /// <summary>
        /// <para>The region where the instance resides. Examples:</para>
        /// <list type="bullet">
        /// <item><description><c>cn-hangzhou</c>: China (Hangzhou)</description></item>
        /// <item><description><c>cn-beijing</c>: China (Beijing)</description></item>
        /// <item><description><c>cn-shanghai</c>: China (Shanghai)</description></item>
        /// <item><description><c>cn-zhangjiakou</c>: China (Zhangjiakou)</description></item>
        /// <item><description><c>cn-shenzhen</c>: China (Shenzhen)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The extended request parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For the details of resource groups, see <a href="https://help.aliyun.com/document_detail/457230.html">View basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzcqmoay3dlyq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the security group to which the instance belongs. This parameter is valid only if the ConnectionType parameter is set to <c>single_eni</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("SecurityGroupType")]
        [Validation(Required=false)]
        public string SecurityGroupType { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prd</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp17opt4v18sto39k****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1t50e045b5g7i3p****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
