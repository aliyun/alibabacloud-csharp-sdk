// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class CreateEgressProxyIpPoolRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>created by epg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>epg-gw80bb6a94f835db****</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayId")]
        [Validation(Required=false)]
        public string EgressProxyGatewayId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testIpPool</para>
        /// </summary>
        [NameInMap("EgressProxyIpPoolName")]
        [Validation(Required=false)]
        public string EgressProxyIpPoolName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SourceIP</para>
        /// </summary>
        [NameInMap("HashFactor")]
        [Validation(Required=false)]
        public string HashFactor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>X-Forwarded-For</para>
        /// </summary>
        [NameInMap("HashHeaderName")]
        [Validation(Required=false)]
        public string HashHeaderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Random</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEgressProxyIpPoolRequestTag> Tag { get; set; }
        public class CreateEgressProxyIpPoolRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>epg</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateEgressProxyIpPoolRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateEgressProxyIpPoolRequestZoneMappings : TeaModel {
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<CreateEgressProxyIpPoolRequestZoneMappingsIpAddresses> IpAddresses { get; set; }
            public class CreateEgressProxyIpPoolRequestZoneMappingsIpAddresses : TeaModel {
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
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IpCount")]
            [Validation(Required=false)]
            public int? IpCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-0jl8x3ridfqbikax5o****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
