// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateWhiteIpsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the whitelist. This parameter is required if you configure the whiteIpGroup parameter.</para>
        /// </summary>
        [NameInMap("esIPWhitelist")]
        [Validation(Required=false)]
        public List<string> EsIPWhitelist { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist. This parameter is required if you configure the whiteIpGroup parameter.</para>
        /// </summary>
        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public UpdateWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class UpdateWhiteIpsRequestWhiteIpGroup : TeaModel {
            /// <summary>
            /// <para>The type of the whitelist. Set the value to <b>PRIVATE_ES</b>. This value indicates a private IP address whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_group</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The returned result.</para>
            /// </summary>
            [NameInMap("ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// <para>The returned result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE_ES</para>
            /// </summary>
            [NameInMap("whiteIpType")]
            [Validation(Required=false)]
            public string WhiteIpType { get; set; }

        }

        /// <summary>
        /// <para>The IP addresses in the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.</para>
        /// <remarks>
        /// <para> You cannot configure both the esIPWhitelist and whiteIpGroup parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

    }

}
