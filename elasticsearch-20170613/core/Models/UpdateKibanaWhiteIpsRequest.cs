// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateKibanaWhiteIpsRequest : TeaModel {
        /// <summary>
        /// <para>The IP address whitelists. This parameter is available if the whiteIpGroup parameter is left empty. The default IP address whitelist is updated based on the value of this parameter.</para>
        /// <para>You cannot configure both the kibanaIPWhitelist and whiteIpGroup parameters.</para>
        /// </summary>
        [NameInMap("kibanaIPWhitelist")]
        [Validation(Required=false)]
        public List<string> KibanaIPWhitelist { get; set; }

        /// <summary>
        /// <para>The name of the whitelist. This parameter is required if you configure the whiteIpGroup parameter.</para>
        /// </summary>
        [NameInMap("whiteIpGroup")]
        [Validation(Required=false)]
        public UpdateKibanaWhiteIpsRequestWhiteIpGroup WhiteIpGroup { get; set; }
        public class UpdateKibanaWhiteIpsRequestWhiteIpGroup : TeaModel {
            /// <summary>
            /// <para>The type of the whitelist. Set the value to PUBLIC_KIBANA. This value indicates a public IP address whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_group_name</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist. This parameter is required if you configure the whiteIpGroup parameter.</para>
            /// </summary>
            [NameInMap("ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC_KIBANA</para>
            /// </summary>
            [NameInMap("whiteIpType")]
            [Validation(Required=false)]
            public string WhiteIpType { get; set; }

        }

        /// <summary>
        /// <para>The update mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Cover: overwrites the IP addresses in the specified IP address whitelist with the IP addresses specified by using the ips parameter. This is the default value.</description></item>
        /// <item><description>Append: adds the IP addresses specified by using the ips parameter to the specified IP address whitelist.</description></item>
        /// <item><description>Delete: deletes the IP addresses specified by using the ips parameter from the specified IP address whitelist. At least one IP address must be retained for the whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The body of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

    }

}
