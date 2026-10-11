// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class ListEgressProxyGatewaysRequest : TeaModel {
        [NameInMap("EgressProxyConfigurationIds")]
        [Validation(Required=false)]
        public List<string> EgressProxyConfigurationIds { get; set; }

        [NameInMap("EgressProxyGatewayIds")]
        [Validation(Required=false)]
        public List<string> EgressProxyGatewayIds { get; set; }

        [NameInMap("EgressProxyGatewayNames")]
        [Validation(Required=false)]
        public List<string> EgressProxyGatewayNames { get; set; }

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
        /// <para>rg-acfm4jcyx5e****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
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
        public List<ListEgressProxyGatewaysRequestTag> Tag { get; set; }
        public class ListEgressProxyGatewaysRequestTag : TeaModel {
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

        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

    }

}
