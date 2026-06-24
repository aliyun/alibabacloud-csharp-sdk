// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateWhiteIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D58B014-BBD7-4D80-B219-00B9D5C6860C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateWhiteIpsResponseBodyResult Result { get; set; }
        public class UpdateWhiteIpsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The private network internal-facing access whitelist (deprecated).</para>
            /// </summary>
            [NameInMap("esIPWhitelist")]
            [Validation(Required=false)]
            public List<string> EsIPWhitelist { get; set; }

            /// <summary>
            /// <para>The network configuration.</para>
            /// </summary>
            [NameInMap("networkConfig")]
            [Validation(Required=false)]
            public UpdateWhiteIpsResponseBodyResultNetworkConfig NetworkConfig { get; set; }
            public class UpdateWhiteIpsResponseBodyResultNetworkConfig : TeaModel {
                /// <summary>
                /// <para>The list of whitelist groups.</para>
                /// </summary>
                [NameInMap("whiteIpGroupList")]
                [Validation(Required=false)]
                public List<UpdateWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList> WhiteIpGroupList { get; set; }
                public class UpdateWhiteIpsResponseBodyResultNetworkConfigWhiteIpGroupList : TeaModel {
                    /// <summary>
                    /// <para>The name of the whitelist group. The default group is included by default.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_group</para>
                    /// </summary>
                    [NameInMap("groupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// <para>The IP address information in the whitelist group.</para>
                    /// </summary>
                    [NameInMap("ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                    /// <summary>
                    /// <para>The whitelist type. The value is fixed as PRIVATE_ES, which indicates the private network internal-facing access whitelist.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PRIVATE_ES</para>
                    /// </summary>
                    [NameInMap("whiteIpType")]
                    [Validation(Required=false)]
                    public string WhiteIpType { get; set; }

                }

            }

        }

    }

}
