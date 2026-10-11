// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class ListEgressProxyGatewaysResponseBody : TeaModel {
        [NameInMap("EgressProxyGateways")]
        [Validation(Required=false)]
        public List<ListEgressProxyGatewaysResponseBodyEgressProxyGateways> EgressProxyGateways { get; set; }
        public class ListEgressProxyGatewaysResponseBodyEgressProxyGateways : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>eppool-gw80d96a96ca0b00****</para>
            /// </summary>
            [NameInMap("DefaultEgressProxyIpPoolId")]
            [Validation(Required=false)]
            public string DefaultEgressProxyIpPoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>created by epg</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>epc-uf609a6a8fdf9f4****</para>
            /// </summary>
            [NameInMap("EgressProxyConfigurationId")]
            [Validation(Required=false)]
            public string EgressProxyConfigurationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>epg-gw80bb6a94f835db****</para>
            /// </summary>
            [NameInMap("EgressProxyGatewayId")]
            [Validation(Required=false)]
            public string EgressProxyGatewayId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testEpg</para>
            /// </summary>
            [NameInMap("EgressProxyGatewayName")]
            [Validation(Required=false)]
            public string EgressProxyGatewayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-acfmypqurk****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Provisioning</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListEgressProxyGatewaysResponseBodyEgressProxyGatewaysTags> Tags { get; set; }
            public class ListEgressProxyGatewaysResponseBodyEgressProxyGatewaysTags : TeaModel {
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
            /// <b>Example:</b>
            /// <para>vpc-m5e03az9xwn6siqft****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

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
        /// <para>FFmyTO70tTpLG6I4FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>01A05AB6-3B8A-561C-8CC6-D061498BDEBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
