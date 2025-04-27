// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyWhiteIpsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the IP address whitelist that you want to update. You can specify only one whitelist.</para>
        /// <remarks>
        /// <para>You cannot configure both the whiteIpList and whiteIpGroup parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.</para>
        /// <remarks>
        /// <para>You cannot configure both the whiteIpList and whiteIpGroup parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WORKER</para>
        /// </summary>
        [NameInMap("nodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist. This parameter is required if you configure the whiteIpGroup parameter.</para>
        /// </summary>
        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public ModifyWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class ModifyWhiteIpsRequestWhiteIpGroup : TeaModel {
            /// <summary>
            /// <para>The type of the IP address whitelist. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PRIVATE_KIBANA</description></item>
            /// <item><description>PRIVATE_ES</description></item>
            /// <item><description>PUBLIC_ES</description></item>
            /// <item><description>PUBLIC_KIBANA</description></item>
            /// </list>
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
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PRIVATE_ES</para>
            /// </summary>
            [NameInMap("whiteIpType")]
            [Validation(Required=false)]
            public string WhiteIpType { get; set; }

        }

        /// <summary>
        /// <para>The name of the whitelist. This parameter is required if you configure the whiteIpGroup parameter.</para>
        /// </summary>
        [NameInMap("whiteIpList")]
        [Validation(Required=false)]
        public List<string> WhiteIpList { get; set; }

        /// <summary>
        /// <para>The network type. This parameter is required if you configure the whiteIpList parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE</description></item>
        /// <item><description>PUBLIC</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
