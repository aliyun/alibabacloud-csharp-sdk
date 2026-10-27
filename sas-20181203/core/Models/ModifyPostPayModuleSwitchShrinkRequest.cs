// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyPostPayModuleSwitchShrinkRequest : TeaModel {
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
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Only prechecks the request and does not perform the actual operation.</description></item>
        /// <item><description>false: Performs the actual operation.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The switch configuration for the EDR module.</para>
        /// </summary>
        [NameInMap("EdrModuleSwitch")]
        [Validation(Required=false)]
        public string EdrModuleSwitchShrink { get; set; }

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
        /// <para>The switch status of the pay-as-you-go modules. The value is a JSON string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Key:<list type="bullet">
        /// <item><description><b>VUL</b>: Vulnerability fixing module</description></item>
        /// <item><description><b>CSPM</b>: Cloud Security Posture Management module</description></item>
        /// <item><description><b>AGENTLESS</b>: Agentless detection module</description></item>
        /// <item><description><b>SERVERLESS</b>: Serverless security module</description></item>
        /// <item><description><b>CTDR</b>: Cloud Threat Detection and Response module</description></item>
        /// <item><description><b>POST_HOST</b>: Host and container security module</description></item>
        /// <item><description><b>SDK</b>: Malicious file detection SDK module</description></item>
        /// <item><description><b>RASP</b>: Application protection module</description></item>
        /// <item><description><b>CTDR_STORAGE</b>: Log management module</description></item>
        /// <item><description><b>ANTI_RANSOMWARE</b>: Anti-ransomware management</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Value: 0 indicates disabled, and 1 indicates enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The values of modules that are not specified remain unchanged.</para>
        /// </remarks>
        /// <para><notice>This parameter has the same meaning as the PostPayModuleSwitchObj parameter. If both parameters are specified, the value of PostPayModuleSwitch takes precedence.</notice></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VUL&quot;:1,&quot;CSPM&quot;:0}</para>
        /// </summary>
        [NameInMap("PostPayModuleSwitch")]
        [Validation(Required=false)]
        public string PostPayModuleSwitch { get; set; }

        /// <summary>
        /// <para>The switch status of the pay-as-you-go modules.</para>
        /// <remarks>
        /// <para>Notice: This parameter has the same meaning as the PostPayModuleSwitch parameter. If both parameters are specified, the value of PostPayModuleSwitch takes precedence.</notice></para>
        /// </remarks>
        /// </summary>
        [NameInMap("PostPayModuleSwitchObj")]
        [Validation(Required=false)]
        public string PostPayModuleSwitchObjShrink { get; set; }

    }

}
