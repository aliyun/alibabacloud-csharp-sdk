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
        /// For more information about how to obtain the ID of the account group, see [ListAggregators](https://help.aliyun.com/document_detail/255797.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The `token` can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The rule ID.
        /// 
        /// For more information about how to obtain the ID of a rule, see [ListAggregateConfigRules](https://help.aliyun.com/document_detail/264148.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// The execution mode of the remediation template. Valid values:
        /// 
        /// *   NON_EXECUTION: The remediation template is not executed.
        /// *   AUTO_EXECUTION: The remediation template is automatically executed.
        /// *   MANUAL_EXECUTION: The remediation template is manually executed.
        /// *   NOT_CONFIG: The execution mode is not specified.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// The configuration of the remediation template.
        /// 
        /// For more information about how to obtain the configuration of the remediation template, see [ListRemediationTemplates](https://help.aliyun.com/document_detail/416781.html). You can view the `TemplateDefinition` response parameter to obtain the configuration of the remediation template.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// The ID of the remediation template.
        /// 
        /// *   If you set the `RemediationType` parameter to `OOS`, set this parameter to the identifier of the relevant official remediation template, such as `ACS-OSS-PutBucketAcl`. For more information about how to obtain the remediation template identifier, see [ListRemediationTemplates](https://help.aliyun.com/document_detail/416781.html).
        /// *   If you set the `RemediationType` parameter to `FC`, set this parameter to the Alibaba Cloud Resource Name (ARN) of the relevant Function Compute resource, such as `acs:fc:cn-hangzhou:100931896542****:services/ConfigService.LATEST/functions/test-php`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RemediationTemplateId")]
        [Validation(Required=false)]
        public string RemediationTemplateId { get; set; }

        /// <summary>
        /// The type of the remediation template. Valid values:
        /// 
        /// *   OOS: stands for Operation Orchestration Service and indicates official remediation.
        /// *   FC: stands for Function Compute and indicates custom remediation.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

        /// <summary>
        /// The source of remediation template. Valid values:
        /// 
        /// *   ALIYUN (default): official template.
        /// *   CUSTOM: custom template.
        /// *   NONE: none.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
