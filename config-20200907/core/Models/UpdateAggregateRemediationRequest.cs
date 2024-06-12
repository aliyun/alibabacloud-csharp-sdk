// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateAggregateRemediationRequest : TeaModel {
        /// <summary>
        /// The ID of the account group.
        /// 
        /// You can the [ListAggregators](https://help.aliyun.com/document_detail/255797.html) operation to obtain the ID of the account group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AggregatorId")]
        [Validation(Required=false)]
        public string AggregatorId { get; set; }

        /// <summary>
        /// The execution mode of the remediation. Valid values:
        /// 
        /// *   NON_EXECUTION: The remediation is not executed.
        /// *   AUTO_EXECUTION: The remediation is automatically executed.
        /// *   MANUAL_EXECUTION: The remediation is manually executed.
        /// *   NOT_CONFIG: The execution mode is not specified.
        /// </summary>
        [NameInMap("InvokeType")]
        [Validation(Required=false)]
        public string InvokeType { get; set; }

        /// <summary>
        /// The desired parameter values of the remediation setting.
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// The ID of the remediation setting.
        /// 
        /// You can call the [ListAggregateRemediations](https://help.aliyun.com/document_detail/270036.html) operation to obtain the ID of the remediation setting.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RemediationId")]
        [Validation(Required=false)]
        public string RemediationId { get; set; }

        /// <summary>
        /// The ID of the remediation template.
        /// 
        /// You can call the [ListRemediationTemplates](https://help.aliyun.com/document_detail/270066.html) operation to obtain the ID of the remediation template.
        /// </summary>
        [NameInMap("RemediationTemplateId")]
        [Validation(Required=false)]
        public string RemediationTemplateId { get; set; }

        /// <summary>
        /// The type of the remediation template. Valid values:
        /// 
        /// *   OOS: Operation Orchestration Service (OOS)
        /// *   FC: Function Compute. You can use Function Compute to configure custom remediation settings.
        /// </summary>
        [NameInMap("RemediationType")]
        [Validation(Required=false)]
        public string RemediationType { get; set; }

        /// <summary>
        /// The type of the rule for which the remediation template is configured. Valid values:
        /// 
        /// *   ALIYUN: managed rule.
        /// *   CUSTOM: custom rule.
        /// *   NONE: The rule is not specified.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
