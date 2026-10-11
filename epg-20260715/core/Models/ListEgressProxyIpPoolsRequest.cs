// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class ListEgressProxyIpPoolsRequest : TeaModel {
        [NameInMap("EgressProxyGatewayIds")]
        [Validation(Required=false)]
        public List<string> EgressProxyGatewayIds { get; set; }

        [NameInMap("EgressProxyIpPoolIds")]
        [Validation(Required=false)]
        public List<string> EgressProxyIpPoolIds { get; set; }

        [NameInMap("EgressProxyIpPoolNames")]
        [Validation(Required=false)]
        public List<string> EgressProxyIpPoolNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a8cfe419acc68a35e0b5e8707e68181f</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Skip")]
        [Validation(Required=false)]
        public int? Skip { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListEgressProxyIpPoolsRequestTag> Tag { get; set; }
        public class ListEgressProxyIpPoolsRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>apitest_msgkey_20260529101130_key_1780020691018</para>
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

}
