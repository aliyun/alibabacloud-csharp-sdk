// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class UpdateAgentStorageRequest : TeaModel {
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
        /// <para>agent-test</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

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
        /// <para>(Deprecated) The network type of the agent storage. Valid values: NORMAL and VPC_CONSOLE. Default value: NORMAL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The list of network sources allowed for the agent storage. All sources are allowed by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>TRUST_PROXY: console.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        /// <summary>
        /// <para>The list of network types allowed for the agent storage. All types are allowed by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CLASSIC: classic network.</description></item>
        /// <item><description>INTERNET: public network.</description></item>
        /// <item><description>VPC: VPC network.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

    }

}
