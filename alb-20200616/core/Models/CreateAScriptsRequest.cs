// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateAScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The AScripts to create.</para>
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<CreateAScriptsRequestAScripts> AScripts { get; set; }
        public class CreateAScriptsRequestAScripts : TeaModel {
            /// <summary>
            /// <para>The name of the AScript.</para>
            /// <para>The name must be 2 to 128 characters long, and must start with a letter, a digit, or a Chinese character. It can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AScriptName")]
            [Validation(Required=false)]
            public string AScriptName { get; set; }

            /// <summary>
            /// <para>Specifies whether the AScript is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable extended attributes for the AScript. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Disabled.</para>
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
            public List<CreateAScriptsRequestAScriptsExtAttributes> ExtAttributes { get; set; }
            public class CreateAScriptsRequestAScriptsExtAttributes : TeaModel {
                /// <summary>
                /// <para>The attribute key.</para>
                /// <para>The only valid value is <b>EsDebug</b>. If a request contains the _es_dbg parameter and its value matches the secret key specified in AttributeValue, the system adds a debug header to the response, which contains rule execution logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EsDebug</para>
                /// </summary>
                [NameInMap("AttributeKey")]
                [Validation(Required=false)]
                public string AttributeKey { get; set; }

                /// <summary>
                /// <para>The attribute value, which is used as the secret key for the EsDebug attribute. The value must be 1 to 128 characters long and can contain uppercase letters, lowercase letters, and digits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public string AttributeValue { get; set; }

            }

            /// <summary>
            /// <para>Specifies when the AScript is executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>RequestHead</b> (default): Executes before request rules.</para>
            /// </description></item>
            /// <item><description><para><b>RequestFoot</b>: Executes after request rules.</para>
            /// </description></item>
            /// <item><description><para><b>ResponseHead</b>: Executes before response rules.</para>
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
            /// <para>The content of the AScript.</para>
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
        /// <para>A client token used to ensure request idempotency.</para>
        /// <para>You can generate this value on your client. The value must be unique across requests and contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run without creating the AScript. The system checks the request for required parameters, format validity, and service limits. If the request fails the check, an error message is returned. If the request passes the check, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. After the request passes the check, the system returns an HTTP 2xx status code and performs the operation.</para>
        /// </description></item>
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
