// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateAScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the AScript rules.</para>
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<CreateAScriptsRequestAScripts> AScripts { get; set; }
        public class CreateAScriptsRequestAScripts : TeaModel {
            /// <summary>
            /// <para>The name of the AScript rule.</para>
            /// <para>The name must be 2 to 128 character in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the extended attributes of the AScript rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false (default)</description></item>
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
            public List<CreateAScriptsRequestAScriptsExtAttributes> ExtAttributes { get; set; }
            public class CreateAScriptsRequestAScriptsExtAttributes : TeaModel {
                /// <summary>
                /// <para>The attribute name.</para>
                /// <para>Set the value to <b>EsDebug</b>, which specifies that if requests carry the _es_dbg parameter and the value is the specified key, the debugging header is enabled to output the execution result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EsDebug</para>
                /// </summary>
                [NameInMap("AttributeKey")]
                [Validation(Required=false)]
                public string AttributeKey { get; set; }

                /// <summary>
                /// <para>The attribute value, which must be 1 to 128 characters in length, and can contain letters or digits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public string AttributeValue { get; set; }

            }

            /// <summary>
            /// <para>可编程脚本执行位置</para>
            /// <list type="bullet">
            /// <item><description><para>RequestHead（默认值）：请求方向规则执行前</para>
            /// </description></item>
            /// <item><description><para>RequestFoot：请求方向规则执行后</para>
            /// </description></item>
            /// <item><description><para>ResponseHead：响应方向规则执行前</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RequestFoot</para>
            /// </summary>
            [NameInMap("Position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// <para>The content of the AScript rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>if and(match_re($uri, \&quot;^/1.txt$\&quot;), $arg_type) {   rewrite(concat(\&quot;/1.\&quot;, $arg_type), \&quot;break\&quot;) }</para>
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

        }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
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

        /// <summary>
        /// <para>The listener ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-6hfq3zs0x04ibn****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
