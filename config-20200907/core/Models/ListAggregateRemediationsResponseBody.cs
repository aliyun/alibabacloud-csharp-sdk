// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateRemediationsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that contains remediation templates.</para>
        /// </summary>
        [NameInMap("Remediations")]
        [Validation(Required=false)]
        public List<ListAggregateRemediationsResponseBodyRemediations> Remediations { get; set; }
        public class ListAggregateRemediationsResponseBodyRemediations : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The ID of the account group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca-6b4a626622af0012****</para>
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-6b7c626622af00b4****</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>AUTO_EXECUTION</para>
            /// </summary>
            [NameInMap("InvokeType")]
            [Validation(Required=false)]
            public string InvokeType { get; set; }

            /// <summary>
            /// <para>The ID of the last successful execution of the remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bd7629fb-cac8-42fe-bcb1-e362c5a6****</para>
            /// </summary>
            [NameInMap("LastSuccessfulInvocationId")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationId { get; set; }

            /// <summary>
            /// <para>The timestamp of the last successful execution of the remediation template. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1625451393589</para>
            /// </summary>
            [NameInMap("LastSuccessfulInvocationTime")]
            [Validation(Required=false)]
            public long? LastSuccessfulInvocationTime { get; set; }

            /// <summary>
            /// <para>The mode of the last successful execution of the remediation template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NON_EXECUTION: The remediation template is not executed.</description></item>
            /// <item><description>AUTO_EXECUTION: The remediation template is automatically executed.</description></item>
            /// <item><description>MANUAL_EXECUTION: The remediation template is manually executed.</description></item>
            /// <item><description>NOT_CONFIG: The execution mode is not specified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO_EXECUTION</para>
            /// </summary>
            [NameInMap("LastSuccessfulInvocationType")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationType { get; set; }

            /// <summary>
            /// <para>The converted configuration of the remediation template. This parameter is returned only for an OOS remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;bucketName&quot;: &quot;{resourceId}&quot;, &quot;regionId&quot;: &quot;{regionId}&quot;, &quot;permissionName&quot;: &quot;private&quot;}</para>
            /// </summary>
            [NameInMap("RemediaitonOriginParams")]
            [Validation(Required=false)]
            public string RemediaitonOriginParams { get; set; }

            /// <summary>
            /// <para>The ID of the remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-6b7c626622af0026****</para>
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// <para>The source of remediation template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN: official template.</description></item>
            /// <item><description>CUSTOM: custom template.</description></item>
            /// <item><description>NONE: none.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALIYUN</para>
            /// </summary>
            [NameInMap("RemediationSourceType")]
            [Validation(Required=false)]
            public string RemediationSourceType { get; set; }

            /// <summary>
            /// <para>The ID of the remediation template.</para>
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
            /// <item><description>OOS: Operation Orchestration Service (official remediation).</description></item>
            /// <item><description>FC: Function Compute (custom remediation).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OOS</para>
            /// </summary>
            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0146963A-20C0-4E75-B93A-7D622B5FD7C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
