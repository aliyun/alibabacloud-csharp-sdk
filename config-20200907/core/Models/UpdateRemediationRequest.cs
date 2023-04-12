// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class UpdateRemediationRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotency of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// You can call the [ListRemediations](~~270772~~) operation to obtain the ID of the remediation setting.
        /// </summary>
        [NameInMap("RemediationId")]
        [Validation(Required=false)]
        public string RemediationId { get; set; }

        /// <summary>
        /// The ID of the remediation template.
        /// 
        /// You can call the [ListRemediationTemplates](~~270066~~) operation to obtain the ID of the remediation template.
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
        /// The source of the remediation setting. Valid values:
        /// 
        /// *   ALIYUN: the default remediation setting of Alibaba Cloud.
        /// *   CUSTOM: a custom remediation setting.
        /// *   NONE: The source is not specified.
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
