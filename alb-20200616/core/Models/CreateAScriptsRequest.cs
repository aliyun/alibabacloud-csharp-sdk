// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateAScriptsRequest : TeaModel {
        /// <summary>
        /// <para>The list of programmable script information.</para>
        /// </summary>
        [NameInMap("AScripts")]
        [Validation(Required=false)]
        public List<CreateAScriptsRequestAScripts> AScripts { get; set; }
        public class CreateAScriptsRequestAScripts : TeaModel {
            /// <summary>
            /// <para>The name of the programmable script.</para>
            /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. It must start with a letter, Chinese character, or digit.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AScriptName")]
            [Validation(Required=false)]
            public string AScriptName { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the programmable script. Valid values:</para>
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
            /// <para>Specifies whether to enable the extended attributes of the programmable script. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false (default): Disabled.</para>
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
                /// <para>The attribute key of the AScript script.</para>
                /// <para>Valid values: <b>EsDebug</b> only. When a request carries the _es_dbg parameter and its value matches the key configured here, the corresponding debug response headers are enabled to output rule execution records.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EsDebug</para>
                /// </summary>
                [NameInMap("AttributeKey")]
                [Validation(Required=false)]
                public string AttributeKey { get; set; }

                /// <summary>
                /// <para>The attribute value. The value can contain uppercase and lowercase letters and digits, and must be 1 to 128 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("AttributeValue")]
                [Validation(Required=false)]
                public string AttributeValue { get; set; }

            }

            /// <summary>
            /// <para>The execution position of the programmable script. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>RequestHead (default): before request-direction rules are executed.</para>
            /// </description></item>
            /// <item><description><para>RequestFoot: after request-direction rules are executed.</para>
            /// </description></item>
            /// <item><description><para>ResponseHead: before response-direction rules are executed.</para>
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
            /// <para>The content of the programmable script.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>if and(match_re($uri, &quot;^/1.txt$&quot;), $arg_type) {   rewrite(concat(&quot;/1.&quot;, $arg_type), &quot;break&quot;) }</para>
            /// </summary>
            [NameInMap("ScriptContent")]
            [Validation(Required=false)]
            public string ScriptContent { get; set; }

        }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>Generate a unique value from your client for each request. ClientToken supports only ASCII characters.</para>
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
        /// <item><description><b>true</b>: Sends a dry run request. No programmable script is created. The system checks whether the required parameters are specified, the request format is valid, and business limits are met. If the check fails, the corresponding error is returned. If the check passes, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): Sends a regular request. If the check passes, an HTTP 2xx status code is returned and the operation is performed.</description></item>
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
