// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPostPayModuleSwitchShrinkRequest : TeaModel {
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
        public string PostPayModuleSwitchObjShrink { get; set; }

    }

}
