// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateAScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The list of programmable scripts.</para>
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<UpdateAScriptsRequestAScripts> AScripts { get; set; }
        public class UpdateAScriptsRequestAScripts : TeaModel {
            /// <summary>
            /// <para>The ID of the programmable script.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>as-mhqxcanmivn4g5****</para>
            /// </summary>
            [NameInMap("AScriptId")]
            [Validation(Required=false)]
            public string AScriptId { get; set; }

            /// <summary>
            /// <para>The name of the programmable script.</para>
            /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. The name must start with a letter, a Chinese character, or a digit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group1</para>
            /// </summary>
            [NameInMap("AScriptName")]
            [Validation(Required=false)]
            public string AScriptName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the programmable script. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables the programmable script.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): does not enable the programmable script.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable extended attributes for the programmable script. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enables extended attributes.</para>
            /// </description></item>
            /// <item><description><para>false (default): does not enable extended attributes.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExtAttributeEnabled")]
            [Validation(Required=false)]
            public bool? ExtAttributeEnabled { get; set; }

            /// <summary>
            /// <para>The extended attributes.</para>
            /// </summary>
            [NameInMap("ExtAttributes")]
            [Validation(Required=false)]
            public List<UpdateAScriptsRequestAScriptsExtAttributes> ExtAttributes { get; set; }
            public class UpdateAScriptsRequestAScriptsExtAttributes : TeaModel {
                /// <summary>
                /// <para>The attribute name of the AScript script.</para>
                /// <para>The only valid value is <b>EsDebug</b>: when a request carries the _es_dbg parameter and the value matches the key configured here, the corresponding debug response headers are enabled to output rule execution records.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EsDebug</para>
                /// </summary>
                [NameInMap("AttributeKey")]
                [Validation(Required=false)]
                public string AttributeKey { get; set; }

                /// <summary>
                /// <para>The attribute value. The value can contain uppercase and lowercase letters or digits and must be 1 to 128 characters in length.</para>
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
            /// <para>The content of the programmable script.</para>
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
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>b1f642ac-5558-4a36-b7d9-cf53******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</description></item>
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
