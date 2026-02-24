// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateRemediationRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. Generate a token that is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014295338-e7361358-5822-4276-8d30-b5183fac****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The execution mode of the remediation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>NON_EXECUTION: The remediation is not executed.</para>
        /// </description></item>
        /// <item><description><para>AUTO_EXECUTION: The remediation is automatically executed.</para>
        /// </description></item>
        /// <item><description><para>MANUAL_EXECUTION: The remediation is manually executed.</para>
        /// </description></item>
        /// <item><description><para>NOT_CONFIG: The execution mode is not specified.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO_EXECUTION</para>
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// <para>The parameters of the remediation setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;properties&quot;:[{&quot;name&quot;:&quot;regionId&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;{regionId}&quot;,&quot;allowedValues&quot;:[]},{&quot;name&quot;:&quot;bucketName&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;{resourceId}&quot;,&quot;allowedValues&quot;:[],&quot;description&quot;:&quot;OSS Bucket名称。&quot;},{&quot;name&quot;:&quot;permissionName&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;private&quot;,&quot;allowedValues&quot;:[&quot;public-read-write&quot;,&quot;public-read&quot;,&quot;private&quot;],&quot;description&quot;:&quot;ACL权限名称。&quot;}]}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the remediation setting.</para>
        /// <para>For more information about how to obtain the ID of a remediation setting, see <a href="https://help.aliyun.com/document_detail/270772.html">ListRemediations</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crr-909ba2d4716700eb****</para>
        /// </summary>
        [NameInMap("RemediationId")]
        [Validation(Required=false)]
        public string RemediationId { get; set; }

        /// <summary>
        /// <para>The ID of the remediation template.</para>
        /// <para>For more information about how to obtain the ID of a remediation template, see <a href="https://help.aliyun.com/document_detail/270066.html">ListRemediationTemplates</a>.</para>
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
        /// <item><description><para>OOS: Operation Orchestration Service (template-based remediation).</para>
        /// </description></item>
        /// <item><description><para>FC: Function Compute (custom remediation).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OOS</para>
        /// </summary>
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

        /// <summary>
        /// <para>The source of the remediation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ALIYUN: official remediation.</para>
        /// </description></item>
        /// <item><description><para>CUSTOM: custom remediation.</para>
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
