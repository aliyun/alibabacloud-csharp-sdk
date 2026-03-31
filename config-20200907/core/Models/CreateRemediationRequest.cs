// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateRemediationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <c>token</c> can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information about how to obtain the ID of a rule, see <a href="https://help.aliyun.com/document_detail/169607.html">ListConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-8a973ac2e2be00a2****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <para>The execution mode of the remediation template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NON_EXECUTION: The remediation template is not executed.</description></item>
        /// <item><description>AUTO_EXECUTION: The remediation template is automatically executed.</description></item>
        /// <item><description>MANUAL_EXECUTION: The remediation template is manually executed.</description></item>
        /// <item><description>NOT_CONFIG: The execution mode is not specified.</description></item>
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
        /// <para>The configuration of the remediation template.</para>
        /// <para>For more information about how to obtain the remediation template configuration, see the <c>TemplateDefinition</c> response parameter provided in <a href="https://help.aliyun.com/document_detail/416781.html">ListRemediationTemplates</a>.</para>
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
        /// <item><description>If you set the <c>RemediationType</c> parameter to <c>OOS</c>, set this parameter to the identifier of the relevant official remediation template, such as <c>ACS-OSS-PutBucketAcl</c>. For more information about how to obtain the remediation template identifier, see <a href="https://help.aliyun.com/document_detail/416781.html">ListRemediationTemplates</a>.</description></item>
        /// <item><description>If you set the <c>RemediationType</c> parameter to <c>FC</c>, set this parameter to the Alibaba Cloud Resource Name (ARN) of the relevant Function Compute resource, such as <c>acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/test-php</c>.</description></item>
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
        /// <para>The type of the remediation template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OOS: Operation Orchestration Service (official remediation)</description></item>
        /// <item><description>FC: Function Compute (custom remediation)</description></item>
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
        /// <para>The source of remediation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALIYUN (default): official template.</description></item>
        /// <item><description>CUSTOM: custom template.</description></item>
        /// <item><description>NONE: none.</description></item>
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
