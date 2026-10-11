// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class AddIpAddressesToEgressProxyIpPoolRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42661417****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
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
        public List<AddIpAddressesToEgressProxyIpPoolRequestZoneMappings> ZoneMappings { get; set; }
        public class AddIpAddressesToEgressProxyIpPoolRequestZoneMappings : TeaModel {
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<AddIpAddressesToEgressProxyIpPoolRequestZoneMappingsIpAddresses> IpAddresses { get; set; }
            public class AddIpAddressesToEgressProxyIpPoolRequestZoneMappingsIpAddresses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>eip-2zep1zbmxnvoyt1vsj****</para>
                /// </summary>
                [NameInMap("EipAllocationId")]
                [Validation(Required=false)]
                public string EipAllocationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>172.16.1.1</para>
                /// </summary>
                [NameInMap("PrivateIpv4Address")]
                [Validation(Required=false)]
                public string PrivateIpv4Address { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public int? IpCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
