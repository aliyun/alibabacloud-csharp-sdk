// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdatePublicWhiteIpsRequest : TeaModel {
        /// <summary>
        /// <para>The public network access whitelist or whitelist group configuration of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;publicIpWhitelist&quot;:[&quot;0.0.0.0/0&quot;,&quot;0.0.0.0/1&quot;]}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The modification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Cover: overwrites the original IP address whitelist with the value of the ips parameter. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>Append: adds the IP addresses specified by the ips parameter to the original IP address whitelist.</para>
        /// </description></item>
        /// <item><description><para>Delete: deletes the IP addresses specified by the ips parameter from the original IP address whitelist. At least one IP address must be retained.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("modifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

    }

}
