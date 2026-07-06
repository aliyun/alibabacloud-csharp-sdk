// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class CreateAgentStorageRequest : TeaModel {
        /// <summary>
        /// <para>The description of the agent storage. The description must be 3 to 256 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description for agent storage</para>
        /// </summary>
        [NameInMap("AgentStorageDescription")]
        [Validation(Required=false)]
        public string AgentStorageDescription { get; set; }

        /// <summary>
        /// <para>The name of the agent storage. The naming conventions are as follows:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only letters, digits, and hyphens (-).</description></item>
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name cannot end with a hyphen (-).</description></item>
        /// <item><description>The name is case-insensitive.</description></item>
        /// <item><description>The name must be 3 to 16 characters in length.</description></item>
        /// <item><description>The name cannot contain the following words: ali, ay, ots, taobao, or admin.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>first-agent</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>(Deprecated) The network type of the agent storage. Valid values: NORMAL and VPC_CONSOLE. Default value: NORMAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The list of allowed network sources for the agent storage. All sources are allowed by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRUST_PROXY: console.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        /// <summary>
        /// <para>The list of allowed network types for the agent storage. All types are allowed by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLASSIC: classic network.</description></item>
        /// <item><description>INTERNET: public network.</description></item>
        /// <item><description>VPC: VPC network.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

        /// <summary>
        /// <para>The access control policy for the agent storage in JSON format. For the syntax, see <a href="https://www.alibabacloud.com/help/en/ram/user-guide/policy-structure-and-syntax">https://www.alibabacloud.com/help/en/ram/user-guide/policy-structure-and-syntax</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Version&quot;: &quot;1&quot;,
        ///     &quot;Statement&quot;: [
        ///         {
        ///             &quot;Action&quot;: [
        ///                 &quot;ots:<em>&quot;
        ///             ],
        ///             &quot;Resource&quot;: [
        ///                 &quot;acs:ots:</em>:13791xxxxxxxxxxx:agentstorage/myagentstorage*&quot;
        ///             ],
        ///             &quot;Principal&quot;: [
        ///                 &quot;*&quot;
        ///             ],
        ///             &quot;Effect&quot;: &quot;Allow&quot;,
        ///             &quot;Condition&quot;: {
        ///                 &quot;StringEquals&quot;: {
        ///                     &quot;ots:TLSVersion&quot;: [
        ///                         &quot;1.2&quot;
        ///                     ]
        ///                 },
        ///                 &quot;IpAddress&quot;: {
        ///                     &quot;acs:SourceIp&quot;: [
        ///                         &quot;192.168.0.1&quot;,
        ///                         &quot;198.51.100.1&quot;
        ///                     ]
        ///                 }
        ///             }
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxh4em5jnbcd</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateAgentStorageRequestTags> Tags { get; set; }
        public class CreateAgentStorageRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag. The key can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. The value can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0woauavextilfqr61</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
