// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class RemoveIpAddressesFromEgressProxyIpPoolRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eppool-gw80606a59ecc10****</para>
        /// </summary>
        [NameInMap("EgressProxyIpPoolId")]
        [Validation(Required=false)]
        public string EgressProxyIpPoolId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<RemoveIpAddressesFromEgressProxyIpPoolRequestZoneMappings> ZoneMappings { get; set; }
        public class RemoveIpAddressesFromEgressProxyIpPoolRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<RemoveIpAddressesFromEgressProxyIpPoolRequestZoneMappingsIpAddresses> IpAddresses { get; set; }
            public class RemoveIpAddressesFromEgressProxyIpPoolRequestZoneMappingsIpAddresses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>eip-2zep1zbmxnvoyt1vs****</para>
                /// </summary>
                [NameInMap("EipAllocationId")]
                [Validation(Required=false)]
                public string EipAllocationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.10.1</para>
                /// </summary>
                [NameInMap("PrivateIpv4Address")]
                [Validation(Required=false)]
                public string PrivateIpv4Address { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
