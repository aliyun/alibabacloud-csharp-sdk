// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregateRemediationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>For more information about how to obtain the ID of an account group, see <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-6b4a626622af0012****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>A client token. It is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The <c>ClientToken</c> parameter can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>For more information about how to obtain the rule ID, see <a href="https://help.aliyun.com/document_detail/264148.html">ListAggregateConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-6b7c626622af00b4****</para>
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
        /// <para>The parameters of the remediation.</para>
        /// <para>For more information about how to obtain the parameters of the remediation, see the <c>TemplateDefinition</c> parameter in <a href="https://help.aliyun.com/document_detail/416781.html">ListRemediationTemplates</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bucketName&quot;: &quot;{resourceId}&quot;, &quot;regionId&quot;: &quot;{regionId}&quot;, &quot;permissionName&quot;: &quot;private&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The remediation template ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>RemediationType</c> to <c>OOS</c>, set this parameter to <c>ACS-OSS-PutBucketAcl</c>. For more information about how to obtain the remediation template ID, see <a href="https://help.aliyun.com/document_detail/416781.html">ListRemediationTemplates</a>.</para>
        /// </description></item>
        /// <item><description><para>If you set <c>RemediationType</c> to <c>FC</c>, set this parameter to the Alibaba Cloud Resource Name (ARN) of the function in Function Compute. Example: <c>acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/test-php</c>.</para>
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
        /// <para>The remediation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OOS: OOS (template-based remediation).</para>
        /// </description></item>
        /// <item><description><para>FC: FC (custom remediation).</para>
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
        /// <item><description><para>ALIYUN (default): official template.</para>
        /// </description></item>
        /// <item><description><para>CUSTOM: custom template. This value must be specified for custom FC remediations.</para>
        /// </description></item>
        /// <item><description><para>NONE: none.</para>
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
