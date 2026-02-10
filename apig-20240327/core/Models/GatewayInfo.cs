// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayInfo : TeaModel {
        /// <summary>
        /// <para>The instance engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.7</para>
        /// </summary>
        [NameInMap("engineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7og15lhtgi6qasrj60</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apitest-gw</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The virtual private cloud (VPC) information.</para>
        /// </summary>
        [NameInMap("vpcInfo")]
        [Validation(Required=false)]
        public GatewayInfoVpcInfo VpcInfo { get; set; }
        public class GatewayInfoVpcInfo : TeaModel {
            /// <summary>
            /// <para>The VPC name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-vpc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-uf664nyle5kh***</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
