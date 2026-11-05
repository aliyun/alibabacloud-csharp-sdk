// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPostPayModuleSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use different tokens for different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-0016e04115b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Performs a dry run only and does not perform the actual operation.</description></item>
        /// <item><description><b>false</b>: Performs the actual operation.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The switch configuration of the EDR module.</para>
        /// </summary>
        [NameInMap("EdrModuleSwitch")]
        [Validation(Required=false)]
        public ModifyPostPayModuleSwitchRequestEdrModuleSwitch EdrModuleSwitch { get; set; }
        public class ModifyPostPayModuleSwitchRequestEdrModuleSwitch : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable automatic binding of new assets to EDR. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AutoBind")]
            [Validation(Required=false)]
            public int? AutoBind { get; set; }

            /// <summary>
            /// <para>The authorized quota for EDR hosts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EDR_HOST_USAGE")]
            [Validation(Required=false)]
            public long? EDR_HOST_USAGE { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the free trial. Default value: false. You cannot modify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("FreeTrial")]
        [Validation(Required=false)]
        public bool? FreeTrial { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically bind new assets to the host and container protection feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>1</b>: enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBind")]
        [Validation(Required=false)]
        public int? PostPaidHostAutoBind { get; set; }

        /// <summary>
        /// <para>The edition to which new assets are automatically bound for host and container protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Premium Edition</description></item>
        /// <item><description><b>6</b>: Anti-virus Edition    </description></item>
        /// <item><description><b>7</b>: Ultimate Edition</description></item>
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
        /// <para>The switch status of pay-as-you-go modules. The value is a JSON string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: Vulnerability remediation module</description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management (CSPM) module</description></item>
        /// <item><description><b>AGENTLESS</b>: Agentless detection module</description></item>
        /// <item><description><b>SERVERLESS</b>: Serverless security module</description></item>
        /// <item><description><b>CTDR</b>: Cloud Threat Detection and Response (CTDR) module</description></item>
        /// <item><description><b>POST_HOST</b>: Host and container security module</description></item>
        /// <item><description><b>SDK</b>: Malicious file detection SDK module</description></item>
        /// <item><description><b>RASP</b>: Application protection module</description></item>
        /// <item><description><b>CTDR_STORAGE</b>: Log management module</description></item>
        /// <item><description><b>ANTI_RANSOMWARE</b>: Anti-ransomware module</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Value: 0 indicates disabled, and 1 indicates enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The values of modules that are not specified remain unchanged.</para>
        /// </remarks>
        /// <para><notice>This parameter has the same meaning as the PostPayModuleSwitchObj parameter. If both parameters are specified, the value of PostPayModuleSwitch takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VUL&quot;:1,&quot;CSPM&quot;:0}</para>
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

        /// <summary>
        /// <para>The switch status of pay-as-you-go modules.</para>
        /// <remarks>
        /// <para>Notice: This parameter has the same meaning as the PostPayModuleSwitch parameter. If both parameters are specified, the value of PostPayModuleSwitch takes precedence.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PostPayModuleSwitchObj")]
        [Validation(Required=false)]
        public ModifyPostPayModuleSwitchRequestPostPayModuleSwitchObj PostPayModuleSwitchObj { get; set; }
        public class ModifyPostPayModuleSwitchRequestPostPayModuleSwitchObj : TeaModel {
            /// <summary>
            /// <para>The Agentless detection module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Agentless")]
            [Validation(Required=false)]
            public int? Agentless { get; set; }

            /// <summary>
            /// <para>The AI digitalization feature.</para>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: You cannot manually modify the switch of the basic service module. If any other module is in the enabling status, this module is in the enabling status. If all other modules are in shutdown, this module is in shutdown.</para>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cspm")]
            [Validation(Required=false)]
            public int? Cspm { get; set; }

            /// <summary>
            /// <para>The Cloud Threat Detection and Response (CTDR) module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
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
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sdk")]
            [Validation(Required=false)]
            public int? Sdk { get; set; }

            /// <summary>
            /// <para>The Serverless security module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Serverless")]
            [Validation(Required=false)]
            public int? Serverless { get; set; }

            /// <summary>
            /// <para>The vulnerability remediation module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vul")]
            [Validation(Required=false)]
            public int? Vul { get; set; }

            /// <summary>
            /// <para>The file tamper-proofing module. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled</description></item>
            /// <item><description><b>1</b>: enabled</description></item>
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
