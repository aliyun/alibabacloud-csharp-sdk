// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRemediationsResponseBody : TeaModel {
        /// <summary>
        /// The page number. Pages start from page 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 50.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The converted configuration of the remediation template. This parameter is returned only for an OOS remediation template.
        /// </summary>
        [NameInMap("Remediations")]
        [Validation(Required=false)]
        public List<ListRemediationsResponseBodyRemediations> Remediations { get; set; }
        public class ListRemediationsResponseBodyRemediations : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource belongs.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The rule ID.
            /// </summary>
            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            /// <summary>
            /// The execution mode of the remediation template. Valid values:
            /// 
            /// *   NON_EXECUTION: The remediation template was not executed.
            /// *   AUTO_EXECUTION: The remediation template was automatically executed.
            /// *   MANUAL_EXECUTION: The remediation template was manually executed.
            /// *   NOT_CONFIG: The execution mode was not specified.
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
            /// *   NON_EXECUTION: The remediation template was not executed.
            /// *   AUTO_EXECUTION: The remediation template was automatically executed.
            /// *   MANUAL_EXECUTION: The remediation template was manually executed.
            /// *   NOT_CONFIG: The execution mode was not specified.
            /// </summary>
            [NameInMap("LastSuccessfulInvocationType")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationType { get; set; }

            /// <summary>
            /// The ID of the remediation template.
            /// </summary>
            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            /// <summary>
            /// The converted configuration of the remediation template. This parameter is available only for an OOS remediation template.
            /// </summary>
            [NameInMap("RemediationOriginParams")]
            [Validation(Required=false)]
            public string RemediationOriginParams { get; set; }

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
            /// The ID of the remediation template.
            /// </summary>
            [NameInMap("RemediationTemplateId")]
            [Validation(Required=false)]
            public string RemediationTemplateId { get; set; }

            /// <summary>
            /// The type of the remediation template. Valid values:
            /// 
            /// *   OOS: Operation Orchestration Service (official remediation)
            /// *   FC: Function Compute (custom remediation)
            /// </summary>
            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of remediation settings.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
