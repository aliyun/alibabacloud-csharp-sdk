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
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values: PREPAY (subscription) and POSTPAY (pay-as-you-go). This parameter is ignored for Serverless Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The engine specifications. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_SC_2_4_60_c</para>
        /// </summary>
        [NameInMap("ClusterSpecification")]
        [Validation(Required=false)]
        public string ClusterSpecification { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values: ZooKeeper and Nacos-Ans.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nacos-Ans</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The cluster version. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NACOS_2_0_0</para>
        /// </summary>
        [NameInMap("ClusterVersion")]
        [Validation(Required=false)]
        public string ClusterVersion { get; set; }

        /// <summary>
        /// <para>The network access type. Valid values: <c>slb</c> and <c>single_eni</c>. In some regions, Developer Edition supports only <c>single_eni</c>.</para>
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
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alicloud-disk-ssd</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        [Obsolete]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable public network access by using an elastic IP address (EIP). This parameter takes effect only when ConnectionType is set to <c>single_eni</c>.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("EipEnabled")]
        [Validation(Required=false)]
        public bool? EipEnabled { get; set; }

        /// <summary>
        /// <para>The number of nodes in the instance. Valid values: 1 to 9.
        /// [Professional Edition] </para>
        /// <list type="bullet">
        /// <item><description><para><c>NACOS_2_0_0</c>: Nacos 2.x.x.</para>
        /// </description></item>
        /// <item><description><para><c>ZooKeeper_3_8_0</c>: ZooKeeper 3.8.x.
        /// [Developer Edition] </para>
        /// </description></item>
        /// <item><description><para><c>NACOS_2_0_0</c>: Nacos 2.x.</para>
        /// </description></item>
        /// <item><description><para><c>ZooKeeper_3_8_0</c>: ZooKeeper 3.8.x.
        /// [Serverless Edition]</para>
        /// </description></item>
        /// <item><description><para><c>NACOS_2_0_0</c>: Nacos 2.x.</para>
        /// </description></item>
        /// <item><description><para><c>ZooKeeper_3_8_0</c>: ZooKeeper 3.8.x.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The instance edition. This parameter is required unless otherwise specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>mse_pro</c>: Professional Edition.</description></item>
        /// <item><description><c>mse_dev</c>: Developer Edition.</description></item>
        /// <item><description><c>mse_serverless</c>: Serverless Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse_pro</para>
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>privatenet</c>: virtual private cloud (VPC).</description></item>
        /// <item><description><c>pubnet</c>: Internet.</description></item>
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
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("PrivateSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PrivateSlbSpecification { get; set; }

        /// <summary>
        /// <para>The bandwidth of the Internet-facing Server Load Balancer (SLB) instance. This parameter takes effect only when ConnectionType is set to <c>slb</c>. A value of 0 indicates that no Internet-facing SLB instance is created. A value greater than 1 indicates the fixed bandwidth of the Internet-facing SLB instance. Unit: Mbit/s. Valid values: 0 to 5000.</para>
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
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("PubSlbSpecification")]
        [Validation(Required=false)]
        [Obsolete]
        public string PubSlbSpecification { get; set; }

        /// <summary>
        /// <para>The region where the cluster is deployed. Valid values include but are not limited to:</para>
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
        /// <para>The extended request parameters in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The resource group ID. For more information, see <a href="https://help.aliyun.com/document_detail/457230.html">View the basic information of a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzcqmoay3dlyq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the security group to which the instance belongs. This parameter takes effect only when ConnectionType is set to <c>single_eni</c>. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>enterprise</para>
        /// </summary>
        [NameInMap("SecurityGroupType")]
        [Validation(Required=false)]
        public string SecurityGroupType { get; set; }

        /// <summary>
        /// <para>The tags to be added. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateClusterRequestTag> Tag { get; set; }
        public class CreateClusterRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prd</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp17opt4v18sto39k****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1t50e045b5g7i3p****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
