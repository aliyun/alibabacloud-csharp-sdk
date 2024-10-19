// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteVpcIpBlock")]
        [Validation(Required=false)]
        public string DeleteVpcIpBlock { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EgressIpv6Enable")]
        [Validation(Required=false)]
        public string EgressIpv6Enable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTPS2_TLS1_0</para>
        /// </summary>
        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IPV6Enabled")]
        [Validation(Required=false)]
        public string IPV6Enabled { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apigateway-ht-8xxxxxxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>apigatewayInstance</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>172.0.0.1/24</para>
        /// </summary>
        [NameInMap("IntranetSegments")]
        [Validation(Required=false)]
        public string IntranetSegments { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>23:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The information about the CIDR block that API Gateway can use to access the virtual private cloud (VPC) of the backend service.</para>
        /// </summary>
        [NameInMap("ToConnectVpcIpBlock")]
        [Validation(Required=false)]
        public ModifyInstanceAttributeRequestToConnectVpcIpBlock ToConnectVpcIpBlock { get; set; }
        public class ModifyInstanceAttributeRequestToConnectVpcIpBlock : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the VSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/16</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>Specifies whether the CIDR block is a custom CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Customized")]
            [Validation(Required=false)]
            public bool? Customized { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-wz94cqvaoe1ipxxxxxx</para>
            /// </summary>
            [NameInMap("VswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c20d86c4-1eb3-4d0b-afe9-c586df1e2136</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("VpcSlbIntranetEnable")]
        [Validation(Required=false)]
        public string VpcSlbIntranetEnable { get; set; }

    }

}
