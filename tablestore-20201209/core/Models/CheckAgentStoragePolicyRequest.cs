// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class CheckAgentStoragePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The agent storage name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-test</para>
        /// </summary>
        [NameInMap("AgentStorageName")]
        [Validation(Required=false)]
        public string AgentStorageName { get; set; }

        /// <summary>
        /// <para>The agent storage access control policy in JSON format.</para>
        /// <para>This parameter is required.</para>
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
        ///                         &quot;172.16.0.1&quot;
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

    }

}
