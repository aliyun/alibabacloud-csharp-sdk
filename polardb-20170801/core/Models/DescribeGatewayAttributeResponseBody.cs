// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The specification code for the gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polar.app.g2.medium</para>
        /// </summary>
        [NameInMap("ClassCode")]
        [Validation(Required=false)]
        public string ClassCode { get; set; }

        /// <summary>
        /// <para>The time when the gateway instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-24T11:57:54Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <para>The database type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>A list of endpoints for the gateway instance.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<DescribeGatewayAttributeResponseBodyEndpoints> Endpoints { get; set; }
        public class DescribeGatewayAttributeResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The endpoint address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxxx.polardbaigateway.pre.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("EndpointId")]
            [Validation(Required=false)]
            public string EndpointId { get; set; }

            /// <summary>
            /// <para>The ID of the gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pg-xxxxxxx</para>
            /// </summary>
            [NameInMap("GwClusterId")]
            [Validation(Required=false)]
            public string GwClusterId { get; set; }

            /// <summary>
            /// <para>The network type of the endpoint. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Private</b>: VPC endpoint.</para>
            /// </description></item>
            /// <item><description><para><b>Public</b>: public endpoint.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Public</para>
            /// </summary>
            [NameInMap("NetType")]
            [Validation(Required=false)]
            public string NetType { get; set; }

            /// <summary>
            /// <para>The port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The tunnel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1874631</para>
            /// </summary>
            [NameInMap("TunnelId")]
            [Validation(Required=false)]
            public string TunnelId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the endpoint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-*************</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The time when the subscription for the gateway instance expires.</para>
        /// <para>This parameter is empty for pay-as-you-go instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-04-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the subscription for the gateway instance has expired. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>The ID of the gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The description of the gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("GwDescription")]
        [Validation(Required=false)]
        public string GwDescription { get; set; }

        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <para>The time when the gateway instance was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-07T02:19:55Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The billing method of the gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RunningVersion")]
        [Validation(Required=false)]
        public string RunningVersion { get; set; }

        /// <summary>
        /// <para>A list of IP whitelists for the gateway instance.</para>
        /// </summary>
        [NameInMap("SecurityIPArrays")]
        [Validation(Required=false)]
        public List<DescribeGatewayAttributeResponseBodySecurityIPArrays> SecurityIPArrays { get; set; }
        public class DescribeGatewayAttributeResponseBodySecurityIPArrays : TeaModel {
            /// <summary>
            /// <para>The name of the IP whitelist. The default value is <c>default</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("SecurityIPArrayName")]
            [Validation(Required=false)]
            public string SecurityIPArrayName { get; set; }

            /// <summary>
            /// <para>The tag of the IP whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mytag</para>
            /// </summary>
            [NameInMap("SecurityIPArrayTag")]
            [Validation(Required=false)]
            public string SecurityIPArrayTag { get; set; }

            /// <summary>
            /// <para>A comma-separated list of IP addresses in the IP whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127.0.0.1</para>
            /// </summary>
            [NameInMap("SecurityIPList")]
            [Validation(Required=false)]
            public string SecurityIPList { get; set; }

        }

        /// <summary>
        /// <para>The status of the gateway instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CREATE</b>: The gateway instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>ACTIVATION</b>: The gateway instance is running.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the VSwitch where the gateway instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*********************</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where the gateway instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*************</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
