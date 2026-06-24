// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class EnableKibanaPvlNetworkRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>es-cn-27a3mul6l000xxx-kibana-endpoint</para>
        /// </summary>
        [NameInMap("endpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The security groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("securityGroups")]
        [Validation(Required=false)]
        public List<string> SecurityGroups { get; set; }

        /// <summary>
        /// <para>The vSwitch and zone information.</para>
        /// </summary>
        [NameInMap("vSwitchIdsZone")]
        [Validation(Required=false)]
        public List<EnableKibanaPvlNetworkRequestVSwitchIdsZone> VSwitchIdsZone { get; set; }
        public class EnableKibanaPvlNetworkRequestVSwitchIdsZone : TeaModel {
            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp194pz9iezj6h1n5****</para>
            /// </summary>
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The VPC-connected instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp19ip2ocyv24w0e2****</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
