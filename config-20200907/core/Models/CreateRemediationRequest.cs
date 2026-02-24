// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateRemediationRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. The token must be unique for each request. The <c>ClientToken</c> parameter contains only ASCII characters and must not exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-8a973ac2e2be00a2****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>The execution mode of the remediation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NON_EXECUTION: The remediation is not executed.</para>
        /// </description></item>
        /// <item><description><para>AUTO_EXECUTION: The remediation is automatically executed.</para>
        /// </description></item>
        /// <item><description><para>MANUAL_EXECUTION: The remediation is manually executed.</para>
        /// </description></item>
        /// <item><description><para>NOT_CONFIG: The execution mode is not set.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MANUAL_EXECUTION</para>
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// <para>The remediation parameters.</para>
        /// <para>For more information, see the <c>TemplateDefinition</c> parameter in <a href="https://help.aliyun.com/document_detail/416781.html">ListRemediationTemplates</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bucketName&quot;: &quot;{resourceId}&quot;, &quot;regionId&quot;: &quot;{regionId}&quot;, &quot;permissionName&quot;: &quot;private&quot;}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the remediation template.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>RemediationType</c> is set to <c>OOS</c>, set this parameter to <c>ACS-OSS-PutBucketAcl</c>. For more information, see <a href="https://help.aliyun.com/document_detail/416781.html">ListRemediationTemplates</a>.</para>
        /// </description></item>
        /// <item><description><para>If <c>RemediationType</c> is set to <c>FC</c>, set this parameter to the Alibaba Cloud Resource Name (ARN) of the function in Function Compute. Example: <c>acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/test-php</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS-OSS-PutBucketAcl</para>
        /// </summary>
        [NameInMap("RemediationTemplateId")]
        [Validation(Required=false)]
        public string RemediationTemplateId { get; set; }

        /// <summary>
        /// <para>The type of the remediation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OOS: template-based remediation using OOS.</para>
        /// </description></item>
        /// <item><description><para>FC: custom remediation using FC.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OOS</para>
        /// </summary>
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

        /// <summary>
        /// <para>The source of the remediation template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALIYUN (default): an official template.</para>
        /// </description></item>
        /// <item><description><para>CUSTOM: a custom template. This value is required for custom FC remediations.</para>
        /// </description></item>
        /// <item><description><para>NONE: no source.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
