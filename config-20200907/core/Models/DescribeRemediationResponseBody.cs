// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DescribeRemediationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the remediation configuration.</para>
        /// </summary>
        [NameInMap("Remediation")]
        [Validation(Required=false)]
        public DescribeRemediationResponseBodyRemediation Remediation { get; set; }
        public class DescribeRemediationResponseBodyRemediation : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100931896542****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// <para>The rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cr-3184626622af003****</para>
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// <para>The execution mode of the remediation template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NON_EXECUTION: The remediation template was not executed.</description></item>
            /// <item><description>AUTO_EXECUTION: The remediation template was automatically executed.</description></item>
            /// <item><description>MANUAL_EXECUTION: The remediation template was manually executed.</description></item>
            /// <item><description>NOT_CONFIG: The execution mode was not specified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO_EXECUTION</para>
            /// </summary>
            [NameInMap("InvokeType")]
            [Validation(Required=false)]
            public string InvokeType { get; set; }

            /// <summary>
            /// <para>The record ID of the last successful execution of the remediation template.</para>
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
            /// <item><description>NON_EXECUTION: The remediation template was not executed.</description></item>
            /// <item><description>AUTO_EXECUTION: The remediation template was automatically executed.</description></item>
            /// <item><description>MANUAL_EXECUTION: The remediation template was manually executed.</description></item>
            /// <item><description>NOT_CONFIG: The execution mode was not specified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AUTO_EXECUTION</para>
            /// </summary>
            [NameInMap("LastSuccessfulInvocationType")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationType { get; set; }

            /// <summary>
            /// <para>The ID of the remediation configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crr-f381cf0c1c2f004e****</para>
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// <para>The converted configuration of the remediation template. This parameter is returned only for an OOS remediation template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;bucketName&quot;: &quot;{resourceId}&quot;, &quot;regionId&quot;: &quot;{regionId}&quot;, &quot;permissionName&quot;: &quot;private&quot;}</para>
            /// </summary>
            [NameInMap("RemediationOriginParams")]
            [Validation(Required=false)]
            public string RemediationOriginParams { get; set; }

            /// <summary>
            /// <para>The source of the remediation template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALIYUN: official template</description></item>
            /// <item><description>CUSTOM: custom template</description></item>
            /// <item><description>NONE: none</description></item>
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
            /// <item><description>OOS: Operation Orchestration Service (official remediation)</description></item>
            /// <item><description>FC: Function Compute (custom remediation)</description></item>
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
        /// <para>79BE07A7-46A5-5D3C-B378-0ACDA979****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
