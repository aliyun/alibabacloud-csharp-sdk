// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregateRemediationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the account group.</para>
        /// <para>You can the <a href="https://help.aliyun.com/document_detail/255797.html">ListAggregators</a> operation to obtain the ID of the account group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-6b4a626622af0012****</para>
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// <para>The execution mode of the remediation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NON_EXECUTION: The remediation is not executed.</description></item>
        /// <item><description>AUTO_EXECUTION: The remediation is automatically executed.</description></item>
        /// <item><description>MANUAL_EXECUTION: The remediation is manually executed.</description></item>
        /// <item><description>NOT_CONFIG: The execution mode is not specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO_EXECUTION</para>
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// <para>The desired parameter values of the remediation setting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;properties&quot;:[{&quot;name&quot;:&quot;regionId&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;{regionId}&quot;,&quot;allowedValues&quot;:[]},{&quot;name&quot;:&quot;bucketName&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;{resourceId}&quot;,&quot;allowedValues&quot;:[],&quot;description&quot;:&quot;OSS Bucket Name.&quot;},{&quot;name&quot;:&quot;permissionName&quot;,&quot;type&quot;:&quot;STRING&quot;,&quot;value&quot;:&quot;private&quot;,&quot;allowedValues&quot;:[&quot;public-read-write&quot;,&quot;public-read&quot;,&quot;private&quot;],&quot;description&quot;:&quot;ACL Permission Name.&quot;}]}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The ID of the remediation setting.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/270036.html">ListAggregateRemediations</a> operation to obtain the ID of the remediation setting.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/270066.html">ListRemediationTemplates</a> operation to obtain the ID of the remediation template.</para>
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
        /// <item><description>OOS: Operation Orchestration Service (OOS)</description></item>
        /// <item><description>FC: Function Compute. You can use Function Compute to configure custom remediation settings.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OOS</para>
        /// </summary>
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

        /// <summary>
        /// <para>The type of the rule for which the remediation template is configured. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALIYUN: managed rule.</description></item>
        /// <item><description>CUSTOM: custom rule.</description></item>
        /// <item><description>NONE: The rule is not specified.</description></item>
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
