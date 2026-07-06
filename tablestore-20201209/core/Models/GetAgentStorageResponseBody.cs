// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class GetAgentStorageResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the agent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description for agent storage</para>
        /// </summary>
        [NameInMap("AgentStorageDescription")]
        [Validation(Required=false)]
        public string AgentStorageDescription { get; set; }

        /// <summary>
        /// <para>The name of the agent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-test</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>The specifications of the agent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SSD</para>
        /// </summary>
        [NameInMap("AgentStorageSpecification")]
        [Validation(Required=false)]
        public string AgentStorageSpecification { get; set; }

        /// <summary>
        /// <para>The status of the agent storage. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>normal: Normal.</description></item>
        /// <item><description>forbidden: Disabled.</description></item>
        /// <item><description>deleting: Being released.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("AgentStorageStatus")]
        [Validation(Required=false)]
        public string AgentStorageStatus { get; set; }

        /// <summary>
        /// <para>The alias of the agent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-test</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The time when the agent storage was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-12-23T07:24:33Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The list of network sources allowed for the agent storage. TRUST_PROXY: console.</para>
        /// </summary>
        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        /// <summary>
        /// <para>The list of network types allowed for the agent storage. CLASSIC: classic network. INTERNET: public network. VPC: VPC network.</para>
        /// </summary>
        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

        /// <summary>
        /// <para>The access control policy of the agent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drop</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The version of the access control policy for the agent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public long? PolicyVersion { get; set; }

        /// <summary>
        /// <para>The region ID of the agent storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3104C83E-6E82-57FB-BB88-8C64CCFDEF89</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxh4em5jncda</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the agent storage.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetAgentStorageResponseBodyTags> Tags { get; set; }
        public class GetAgentStorageResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Owner</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>(Deprecated) The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>keyTestA</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>(Deprecated) The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00004a20240452b0</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tester</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16542312566</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
