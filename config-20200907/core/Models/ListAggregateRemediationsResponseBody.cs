// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateRemediationsResponseBody : TeaModel {
        /// <summary>
        /// The remediation settings returned.
        /// </summary>
        [NameInMap("Remediations")]
        [Validation(Required=false)]
        public List<ListAggregateRemediationsResponseBodyRemediations> Remediations { get; set; }
        public class ListAggregateRemediationsResponseBodyRemediations : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account involved.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The ID of the account group.
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// The ID of the rule.
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
            /// The ID of the last successful execution of the remediation template.
            /// </summary>
            [NameInMap("LastSuccessfulInvocationId")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationId { get; set; }

            /// <summary>
            /// The timestamp of the last successful execution of the remediation template Unit: milliseconds.
            /// </summary>
            [NameInMap("LastSuccessfulInvocationTime")]
            [Validation(Required=false)]
            public long? LastSuccessfulInvocationTime { get; set; }

            /// <summary>
            /// The mode of the last successful execution of the remediation template. Valid values:
            /// 
            /// *   NON_EXECUTION: no execution.
            /// *   AUTO_EXECUTION: automatic execution.
            /// *   MANUAL_EXECUTION: manual execution.
            /// *   NOT_CONFIG: not specified.
            /// </summary>
            [NameInMap("LastSuccessfulInvocationType")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationType { get; set; }

            /// <summary>
            /// The converted configuration of the remediation template. This parameter is returned only for an OOS remediation template.
            /// </summary>
            [NameInMap("RemediaitonOriginParams")]
            [Validation(Required=false)]
            public string RemediaitonOriginParams { get; set; }

            /// <summary>
            /// The ID of the remediation setting.
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// The source of remediation. Valid values:
            /// 
            /// *   ALIYUN: official template.
            /// *   CUSTOM: custom template.
            /// *   NONE: none.
            /// </summary>
            [NameInMap("RemediationSourceType")]
            [Validation(Required=false)]
            public string RemediationSourceType { get; set; }

            /// <summary>
            /// The identifier of the remediation template.
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

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
