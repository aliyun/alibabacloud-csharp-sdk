// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPostPayModuleSwitchRequest : TeaModel {
        /// <summary>
        /// <para>Automatic binding switch for new assets in host and container protection. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Off</description></item>
        /// <item><description><b>1</b>: On</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBind")]
        [Validation(Required=false)]
        public int? PostPaidHostAutoBind { get; set; }

        /// <summary>
        /// <para>Version for automatic binding of new assets in host and container protection. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Free Edition </description></item>
        /// <item><description><b>3</b>: Enterprise Edition</description></item>
        /// <item><description><b>5</b>: Advanced Edition</description></item>
        /// <item><description><b>6</b>: Antivirus Edition    </description></item>
        /// <item><description><b>7</b>: Flagship Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("PostPaidHostAutoBindVersion")]
        [Validation(Required=false)]
        public int? PostPaidHostAutoBindVersion { get; set; }

        /// <summary>
        /// <para>Pay-as-you-go instance ID, which must be filled in.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeVersionConfig~~">DescribeVersionConfig</a> interface to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>postpay-sas-**</para>
        /// </summary>
        [NameInMap("PostPayInstanceId")]
        [Validation(Required=false)]
        public string PostPayInstanceId { get; set; }

        /// <summary>
        /// <para>Status of the pay-as-you-go module switch, in JsonString format. Values:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: Vulnerability Repair Module</description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management Module</description></item>
        /// <item><description><b>AGENTLESS</b>: Agentless Detection Module</description></item>
        /// <item><description><b>SERVERLESS</b>: Serverless Security Module</description></item>
        /// <item><description><b>CTDR</b>: Threat Analysis and Response Module</description></item>
        /// <item><description><b>POST_HOST</b>: Host and Container Security Module</description></item>
        /// <item><description><b>SDK</b>: Malicious File Detection SDK Module</description></item>
        /// <item><description><b>RASP</b>: Application Protection Module</description></item>
        /// <item><description><b>CTDR_STORAGE</b>: Log Management Module</description></item>
        /// <item><description><b>ANTI_RANSOMWARE</b>: Anti-Ransomware Management</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Value: 0 means off, 1 means on</description></item>
        /// </list>
        /// <remarks>
        /// <para>The values of modules not passed will not change.</para>
        /// </remarks>
        /// <para><notice>The meaning is the same as the PostPayModuleSwitchObj field. When both exist, the value of PostPayModuleSwitch takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VUL&quot;:1,&quot;CSPM&quot;:0}</para>
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

        /// <summary>
        /// <para>Pay-as-you-go module switch.</para>
        /// <remarks>
        /// <para>Notice:  The meaning is the same as the PostPayModuleSwitch field. When both exist, the value of PostPayModuleSwitch takes precedence.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("PostPayModuleSwitchObj")]
        [Validation(Required=false)]
        public ModifyPostPayModuleSwitchRequestPostPayModuleSwitchObj PostPayModuleSwitchObj { get; set; }
        public class ModifyPostPayModuleSwitchRequestPostPayModuleSwitchObj : TeaModel {
            /// <summary>
            /// <para>Agentless Detection Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Agentless")]
            [Validation(Required=false)]
            public int? Agentless { get; set; }

            /// <summary>
            /// <para>Anti-Ransomware Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AntiRansomware")]
            [Validation(Required=false)]
            public int? AntiRansomware { get; set; }

            /// <summary>
            /// <para>Basic service module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// <remarks>
            /// <para>Notice: The basic service module switch does not support active modification. When other modules are on, this module is also on. If all other modules are off, then this module is off.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BasicService")]
            [Validation(Required=false)]
            public int? BasicService { get; set; }

            /// <summary>
            /// <para>Cloud Security Configuration Check Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Cspm")]
            [Validation(Required=false)]
            public int? Cspm { get; set; }

            /// <summary>
            /// <para>Threat Analysis and Response Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Ctdr")]
            [Validation(Required=false)]
            public int? Ctdr { get; set; }

            /// <summary>
            /// <para>Log Management Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CtdrStorage")]
            [Validation(Required=false)]
            public int? CtdrStorage { get; set; }

            /// <summary>
            /// <para>Host and Container Security Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PostHost")]
            [Validation(Required=false)]
            public int? PostHost { get; set; }

            /// <summary>
            /// <para>Application Protection Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rasp")]
            [Validation(Required=false)]
            public int? Rasp { get; set; }

            /// <summary>
            /// <para>Malicious File Detection SDK Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Sdk")]
            [Validation(Required=false)]
            public int? Sdk { get; set; }

            /// <summary>
            /// <para>Serverless Security Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Serverless")]
            [Validation(Required=false)]
            public int? Serverless { get; set; }

            /// <summary>
            /// <para>Vulnerability Repair Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vul")]
            [Validation(Required=false)]
            public int? Vul { get; set; }

            /// <summary>
            /// <para>File Tamper Protection Module. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Off</description></item>
            /// <item><description><b>1</b>: On</description></item>
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
