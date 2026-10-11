// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class ListEgressProxyIpPoolsResponseBody : TeaModel {
        [NameInMap("EgressProxyIpPools")]
        [Validation(Required=false)]
        public List<ListEgressProxyIpPoolsResponseBodyEgressProxyIpPools> EgressProxyIpPools { get; set; }
        public class ListEgressProxyIpPoolsResponseBodyEgressProxyIpPools : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Intranet</para>
            /// </summary>
            [NameInMap("AddressType")]
            [Validation(Required=false)]
            public string AddressType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-03-11T11:18:35</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Type\&quot;: \&quot;text\&quot;, \&quot;Value\&quot;: \&quot;Ensures that assets are protected by Cloud Firewall. Requirement: Enable the Internet Firewall feature.\&quot;}</para>
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
            public List<ListEgressProxyIpPoolsResponseBodyEgressProxyIpPoolsTags> Tags { get; set; }
            public class ListEgressProxyIpPoolsResponseBodyEgressProxyIpPoolsTags : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Physical_QPS,Thread_Detail,Logic_RT,Physical_RT,Slow_RequestCount</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1770104466</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FFydY8mmse+9oiDWdR7XiKw/GLUmEZbYNsGL0evBky1i+FT5KS4q2RSGRQDNmuSWlq6KV1PiloZen3lB3ZXwB0vA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C79118A9-CA6D-5359-B53E-111BE8A03DCF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
