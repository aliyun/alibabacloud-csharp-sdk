// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class BindZoneVpcRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. You can use the client to generate a unique token for the request. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6447728c8578e66aacf062d2df4446dc</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>zh</c>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><c>en</c>: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>en</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.XX.XX</para>
        /// </summary>
        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        /// <summary>
        /// <para>The VPCs.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, all VPCs bound to the zone are unbound.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public List<BindZoneVpcRequestVpcs> Vpcs { get; set; }
        public class BindZoneVpcRequestVpcs : TeaModel {
            /// <summary>
            /// <para>The ID of the region where the VPC is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-f8zvrvr1payllgz38****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The type of the VPC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>STANDARD</b>: a standard VPC.</para>
            /// </description></item>
            /// <item><description><para><b>EDS</b>: an Elastic Desktop Service VPC.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34d4031b63c527358b710a61346a****</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
