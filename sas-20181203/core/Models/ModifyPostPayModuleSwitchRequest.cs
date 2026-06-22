// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPostPayModuleSwitchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically bind newly added assets for host and container protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Disabled.</description></item>
        /// <item><description><b>1</b>: Enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBind")]
        [Validation(Required=false)]
        public int? PostPaidHostAutoBind { get; set; }

        /// <summary>
        /// <para>The version to which newly added assets are automatically bound for host and container protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition. </description></item>
        /// <item><description><b>3</b>: Enterprise Edition.</description></item>
        /// <item><description><b>5</b>: Advanced Edition.</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition.    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBindVersion")]
        [Validation(Required=false)]
        public int? PostPaidHostAutoBindVersion { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go instance ID. This parameter is required.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeVersionConfig~~">DescribeVersionConfig</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>postpay-sas-**</para>
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// <para>The switch status of pay-as-you-go modules in JSON string format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: vulnerability fix module</description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module</description></item>
        /// <item><description><b>AGENTLESS</b>: agentless detection module</description></item>
        /// <item><description><b>SERVERLESS</b>: serverless security module</description></item>
        /// <item><description><b>CTDR</b>: threat detection and response module</description></item>
        /// <item><description><b>POST_HOST</b>: host and container security module</description></item>
        /// <item><description><b>SDK</b>: malicious file detection SDK module</description></item>
        /// <item><description><b>RASP</b>: application protection module</description></item>
        /// <item><description><b>CTDR_STORAGE</b>: log management module</description></item>
        /// <item><description><b>ANTI_RANSOMWARE</b>: anti-ransomware management</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Value: 0 indicates disabled. 1 indicates enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Modules for which no value is specified remain unchanged.</para>
        /// </remarks>
        /// <para><notice>This parameter has the same meaning as PostPayModuleSwitchObj. If both parameters are specified, the value of PostPayModuleSwitch takes precedence..</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VUL&quot;:1,&quot;CSPM&quot;:0}</para>
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

        /// <summary>
        /// <para>The pay-as-you-go module switch.</para>
        /// <remarks>
        /// <para>Notice: This parameter has the same meaning as PostPayModuleSwitch. If both parameters are specified, the value of PostPayModuleSwitch takes precedence..</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PostPayModuleSwitchObj")]
        [Validation(Required=false)]
        public ModifyPostPayModuleSwitchRequestPostPayModuleSwitchObj PostPayModuleSwitchObj { get; set; }
        public class ModifyPostPayModuleSwitchRequestPostPayModuleSwitchObj : TeaModel {
            /// <summary>
            /// <para>The agentless detection module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Agentless")]
            [Validation(Required=false)]
            public int? Agentless { get; set; }

            /// <summary>
            /// <para>The AI digitalization module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AiDigital")]
            [Validation(Required=false)]
            public int? AiDigital { get; set; }

            /// <summary>
            /// <para>The anti-ransomware module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AntiRansomware")]
            [Validation(Required=false)]
            public int? AntiRansomware { get; set; }

            /// <summary>
            /// <para>The basic service module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: shutdown.</description></item>
            /// <item><description><b>1</b>: enabling status.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: The basic service module switch cannot be manually modified. This module is in the enabling status when any other module is in the enabling status, and is in the shutdown state only when all other modules are in the shutdown state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BasicService")]
            [Validation(Required=false)]
            public int? BasicService { get; set; }

            /// <summary>
            /// <para>The cloud security configuration check module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cspm")]
            [Validation(Required=false)]
            public int? Cspm { get; set; }

            /// <summary>
            /// <para>The threat detection and response module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ctdr")]
            [Validation(Required=false)]
            public int? Ctdr { get; set; }

            /// <summary>
            /// <para>The log management module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CtdrStorage")]
            [Validation(Required=false)]
            public int? CtdrStorage { get; set; }

            /// <summary>
            /// <para>The host and container security module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostHost")]
            [Validation(Required=false)]
            public int? PostHost { get; set; }

            /// <summary>
            /// <para>The application protection module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rasp")]
            [Validation(Required=false)]
            public int? Rasp { get; set; }

            /// <summary>
            /// <para>The malicious file detection SDK module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sdk")]
            [Validation(Required=false)]
            public int? Sdk { get; set; }

            /// <summary>
            /// <para>The serverless security module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Serverless")]
            [Validation(Required=false)]
            public int? Serverless { get; set; }

            /// <summary>
            /// <para>The vulnerability fix module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vul")]
            [Validation(Required=false)]
            public int? Vul { get; set; }

            /// <summary>
            /// <para>The tamper-proofing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Disabled.</description></item>
            /// <item><description><b>1</b>: Enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WebLock")]
            [Validation(Required=false)]
            public int? WebLock { get; set; }

        }

    }

}
