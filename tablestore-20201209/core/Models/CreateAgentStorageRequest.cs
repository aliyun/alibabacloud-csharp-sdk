// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class CreateAgentStorageRequest : TeaModel {
        /// <summary>
        /// <para>agent storage description</para>
        /// 
        /// <b>Example:</b>
        /// <para>description for agent storage</para>
        /// </summary>
        [NameInMap("AgentStorageDescription")]
        [Validation(Required=false)]
        public string AgentStorageDescription { get; set; }

        /// <summary>
        /// <para>agent storage name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>first-ins</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>（已弃用）智能体存储网络类型。NORMAL, VPC_CONSOLE。默认为NORMAL。</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The list of network sources allowed for the agent storage instance. By default, all network sources are allowed. Valid values: TRUST_PROXY: console.</para>
        /// </summary>
        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        /// <summary>
        /// <para>The list of network types allowed for the agent storage instance. By default, all network types are allowed. Valid values: CLASSIC: classic network. INTERNET: Internet. VPC: VPC.</para>
        /// </summary>
        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

        /// <summary>
        /// <para>The access control policy of the agent storage instance in JSON format. For the policy syntax, see <a href="https://www.alibabacloud.com/help/en/ram/user-guide/policy-structure-and-syntax">https://www.alibabacloud.com/help/en/ram/user-guide/policy-structure-and-syntax</a>.</para>
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
        /// <para>resource group id</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxh4em5jnbcd</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>tag</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateAgentStorageRequestTags> Tags { get; set; }
        public class CreateAgentStorageRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.
            /// The key can be up to 64 characters in length.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>created</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.
            /// The value can be up to 64 characters in length.</para>
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
