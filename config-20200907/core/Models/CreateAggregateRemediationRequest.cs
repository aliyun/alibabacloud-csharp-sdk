// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class CreateAggregateRemediationRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// You can call the [ListAggregators](~~255797~~) operation to obtain the account group ID.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The `ClientToken` value can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// You can call the [ListAggregateConfigRules](~~264148~~) operation to obtain the rule ID.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The execution mode of the remediation template. Valid values:
        /// 
        /// *   NON_EXECUTION: no execution.
        /// *   AUTO_EXECUTION: automatic execution.
        /// *   MANUAL_EXECUTION: manual execution.
        /// *   NOT_CONFIG: not specified.
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// The configuration of the remediation template.
        /// 
        /// You can call the [ListRemediationTemplates](~~416781~~) operation to obtain the remediation template configuration from the `TemplateDefinition` response parameter.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// The identifier of the remediation template.
        /// 
        /// *   If you set the `RemediationType` parameter to `OOS`, set this parameter to the identifier of the relevant official remediation template, such as `ACS-OSS-PutBucketAcl`. You can call the [ListRemediationTemplates](~~416781~~) operation to obtain the remediation template identifier.
        /// *   If you set the `RemediationType` parameter to `FC`, set this parameter to the Alibaba Cloud Resource Name (ARN) of the relevant Function Compute resource, such as `acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/test-php`.
        /// </summary>
        [NameInMap("RemediationTemplateId")]
        [Validation(Required=false)]
        public string RemediationTemplateId { get; set; }

        /// <summary>
        /// The type of remediation to perform. Valid values:
        /// 
        /// *   OOS: stands for Operation Orchestration Service and indicates official remediation.
        /// *   FC: stands for Function Compute and indicates custom remediation.
        /// </summary>
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

        /// <summary>
        /// The source of remediation. Valid values:
        /// 
        /// *   ALIYUN: official template. This is the default value.
        /// *   CUSTOM: custom template.
        /// *   NONE: none.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
