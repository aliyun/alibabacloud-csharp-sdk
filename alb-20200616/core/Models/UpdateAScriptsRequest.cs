// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateAScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the AScript rule.</para>
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<UpdateAScriptsRequestAScripts> AScripts { get; set; }
        public class UpdateAScriptsRequestAScripts : TeaModel {
            /// <summary>
            /// <para>The rule ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>as-mhqxcanmivn4g5****</para>
            /// </summary>
            [NameInMap("AScriptId")]
            [Validation(Required=false)]
            public string AScriptId { get; set; }

            /// <summary>
            /// <para>The name of the AScript rule.</para>
            /// <para>The name must be 2 to 128 character in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group1</para>
            /// </summary>
            [NameInMap("AScriptName")]
            [Validation(Required=false)]
            public string AScriptName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the AScript rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the extended attributes of the Ascript rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false (false)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExtAttributeEnabled")]
            [Validation(Required=false)]
            public bool? ExtAttributeEnabled { get; set; }

            /// <summary>
            /// <para>The extended attribute.</para>
            /// </summary>
            [NameInMap("ExtAttributes")]
            [Validation(Required=false)]
            public List<UpdateAScriptsRequestAScriptsExtAttributes> ExtAttributes { get; set; }
            public class UpdateAScriptsRequestAScriptsExtAttributes : TeaModel {
                /// <summary>
                /// <para>The attribute name.</para>
                /// <para>Set the value to <b>EsDebug</b>, which specifies that when requests carry the _es_dbg parameter whose value is the specified key, the debugging header is enabled to output the execution result.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EsDebug</para>
                /// </summary>
                [NameInMap("AttributeKey")]
                [Validation(Required=false)]
                public string AttributeKey { get; set; }

                /// <summary>
                /// <para>The attribute value, which must be 1 to 128 characters in length, and can contain letters and digits.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public string AttributeValue { get; set; }

            }

            /// <summary>
            /// <para>The content of the AScript rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>if and(match_re($uri, \&quot;^/1.txt$\&quot;), $arg_type) { rewrite(concat(\&quot;/1.\&quot;, $arg_type), \&quot;break\&quot;) }</para>
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b1f642ac-5558-4a36-b7d9-cf53f40ea5c8</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
