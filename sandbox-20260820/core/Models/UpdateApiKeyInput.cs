// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class UpdateApiKeyInput : TeaModel {
        /// <summary>
        /// <para>The new name of the API key. The name can be up to 128 characters in length and can contain only letters, digits, spaces, hyphens (-), underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ci-pipeline-key-v2</para>
        /// </summary>
        [NameInMap("apiKeyName")]
        [Validation(Required=false)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// <para>The expiration time of the API key in UTC. The time must be in RFC 3339 format. An empty value indicates that the API key never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2099-12-31T23:59:59Z</para>
        /// </summary>
        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The IP address blacklist. If you specify this parameter, the existing blacklist is completely overwritten. This parameter is mutually exclusive with ipWhitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ipAddress&quot;:&quot;192.0.2.1&quot;,&quot;description&quot;:&quot;example client&quot;}]</para>
        /// </summary>
        [NameInMap("ipBlacklist")]
        [Validation(Required=false)]
        public List<IPConfig> IpBlacklist { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. If you specify this parameter, the existing whitelist is completely overwritten. This parameter is mutually exclusive with ipBlacklist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ipAddress&quot;:&quot;192.0.2.1&quot;,&quot;description&quot;:&quot;example client&quot;}]</para>
        /// </summary>
        [NameInMap("ipWhitelist")]
        [Validation(Required=false)]
        public List<IPConfig> IpWhitelist { get; set; }

        /// <summary>
        /// <para>The new status of the API key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>active: Enabled.</description></item>
        /// <item><description>inactive: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>inactive</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The set of allowed source VPC IDs. This set is updated independently of the IP blacklists and whitelists. If you omit this parameter or set it to null, the original set is retained. A non-empty array completely replaces the original set. An explicit empty array [] purges the VPC restrictions. Updating only this parameter does not affect the IP address lists, and updating the IP address lists does not affect the VPC restrictions. An empty request body {} purges all IP address and VPC source restrictions. You can update this parameter along with other parameters such as the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vpc-examplea&quot;,&quot;vpc-exampleb&quot;]</para>
        /// </summary>
        [NameInMap("vpcBindings")]
        [Validation(Required=false)]
        public List<string> VpcBindings { get; set; }

    }

}
