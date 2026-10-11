// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class GetEgressProxyIpPoolAttributeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-07-02T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>epg-gw80bb6a94f835db****</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayId")]
        [Validation(Required=false)]
        public string EgressProxyGatewayId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eppool-gw80d96a96ca0b00****</para>
        /// </summary>
        [NameInMap("EgressProxyIpPoolId")]
        [Validation(Required=false)]
        public string EgressProxyIpPoolId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testEpg</para>
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
        /// <para>01A05AB8-D4FC-5B68-B645-5BA513A94F36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Random</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetEgressProxyIpPoolAttributeResponseBodyTags> Tags { get; set; }
        public class GetEgressProxyIpPoolAttributeResponseBodyTags : TeaModel {
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

        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetEgressProxyIpPoolAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetEgressProxyIpPoolAttributeResponseBodyZoneMappings : TeaModel {
            [NameInMap("IpAddresses")]
            [Validation(Required=false)]
            public List<GetEgressProxyIpPoolAttributeResponseBodyZoneMappingsIpAddresses> IpAddresses { get; set; }
            public class GetEgressProxyIpPoolAttributeResponseBodyZoneMappingsIpAddresses : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>eip-2zep1zbmxnvoyt1vsj****</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>48.101.2.1</para>
                /// </summary>
                [NameInMap("PublicIpv4Address")]
                [Validation(Required=false)]
                public string PublicIpv4Address { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-uf64h3tjn2xsd94mb****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-guangzhou-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
