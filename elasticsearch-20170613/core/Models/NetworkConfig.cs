// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NetworkConfig : TeaModel {
        [NameInMap("lbReplica")]
        [Validation(Required=false)]
        public int? LbReplica { get; set; }

        [NameInMap("loadBalanceConfig")]
        [Validation(Required=false)]
        public List<NetworkConfigLoadBalanceConfig> LoadBalanceConfig { get; set; }
        public class NetworkConfigLoadBalanceConfig : TeaModel {
            /// <summary>
            /// <para>可用区信息，如: cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }

            /// <summary>
            /// <para>vswitchId</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxxx</para>
            /// </summary>
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The load balancing type. Default value: DEFAULT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT</para>
        /// </summary>
        [NameInMap("loadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        /// <summary>
        /// <para>The network type. Only Virtual Private Cloud (VPC) is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1xk0naij7jx4ph1****</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-e</para>
        /// </summary>
        [NameInMap("vsArea")]
        [Validation(Required=false)]
        public string VsArea { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1ogpdintii5qvyx****</para>
        /// </summary>
        [NameInMap("vswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>The IP whitelist group configuration. You do not need to set this parameter when you call the createInstance operation to create an instance because the setting does not take effect during instance creation. Use a separate API operation to configure whitelists for different roles.</para>
        /// </summary>
        [NameInMap("whiteIpGroupList")]
        [Validation(Required=false)]
        public List<WhiteIpGroup> WhiteIpGroupList { get; set; }

    }

}
