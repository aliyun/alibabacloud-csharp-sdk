// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class GetEnrolledAccountResponseBody : TeaModel {
        /// <summary>
        /// The account ID.
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// The ID of the baseline that is implemented.
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        /// <summary>
        /// An array that contains baseline items.
        /// </summary>
        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<GetEnrolledAccountResponseBodyBaselineItems> BaselineItems { get; set; }
        public class GetEnrolledAccountResponseBodyBaselineItems : TeaModel {
            /// <summary>
            /// The configurations of the baseline item.
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// The name of the baseline item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether baseline item is skipped. Valid values:
            /// 
            /// *   false
            /// *   true
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// The version of the baseline item.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The time when the account was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The display name of the account.
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The error message.
        /// 
        /// >  This parameter is returned if the value of `Status` is `Failed` or `ScheduleFailed`.
        /// </summary>
        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyErrorInfo ErrorInfo { get; set; }
        public class GetEnrolledAccountResponseBodyErrorInfo : TeaModel {
            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The recommended solution.
            /// </summary>
            [NameInMap("Recommend")]
            [Validation(Required=false)]
            public string Recommend { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// The ID of the parent folder.
        /// </summary>
        [NameInMap("FolderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        /// <summary>
        /// Indicates whether the initialization is complete. Valid values:
        /// 
        /// *   false
        /// *   true
        /// </summary>
        [NameInMap("Initialized")]
        [Validation(Required=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// The input parameters that are used when the account was registered.
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyInputs Inputs { get; set; }
        public class GetEnrolledAccountResponseBodyInputs : TeaModel {
            /// <summary>
            /// The prefix of the account name.
            /// </summary>
            [NameInMap("AccountNamePrefix")]
            [Validation(Required=false)]
            public string AccountNamePrefix { get; set; }

            /// <summary>
            /// The account ID.
            /// </summary>
            [NameInMap("AccountUid")]
            [Validation(Required=false)]
            public long? AccountUid { get; set; }

            /// <summary>
            /// The baseline items.
            /// </summary>
            [NameInMap("BaselineItems")]
            [Validation(Required=false)]
            public List<GetEnrolledAccountResponseBodyInputsBaselineItems> BaselineItems { get; set; }
            public class GetEnrolledAccountResponseBodyInputsBaselineItems : TeaModel {
                /// <summary>
                /// The configurations of the baseline item.
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The name of the baseline item.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether baseline item is skipped. Valid values:
                /// 
                /// *   false
                /// *   true
                /// </summary>
                [NameInMap("Skip")]
                [Validation(Required=false)]
                public bool? Skip { get; set; }

                /// <summary>
                /// The version of the baseline item.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The display name of the account.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The ID of the parent folder.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            /// <summary>
            /// The ID of the settlement account.
            /// </summary>
            [NameInMap("PayerAccountUid")]
            [Validation(Required=false)]
            public long? PayerAccountUid { get; set; }

        }

        /// <summary>
        /// The ID of the management account of the resource directory to which the account belongs.
        /// </summary>
        [NameInMap("MasterAccountUid")]
        [Validation(Required=false)]
        public long? MasterAccountUid { get; set; }

        /// <summary>
        /// The ID of the settlement account.
        /// </summary>
        [NameInMap("PayerAccountUid")]
        [Validation(Required=false)]
        public long? PayerAccountUid { get; set; }

        /// <summary>
        /// The progress of the applying the baseline to the account.
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public List<GetEnrolledAccountResponseBodyProgress> Progress { get; set; }
        public class GetEnrolledAccountResponseBodyProgress : TeaModel {
            /// <summary>
            /// The name of the baseline item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of applying the baseline to the account. Valid values:
            /// 
            /// *   Pending: The baseline is pending to be applied to the account.
            /// *   Running: The baseline is being applied to the account.
            /// *   Finished: : The baseline is applied to the account.
            /// *   Failed: : The baseline fails to be applied to the account.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the account. Valid values:
        /// 
        /// *   Pending: The account is pending to be created.
        /// *   Running: The account is being created.
        /// *   Finished: The account is created.
        /// *   Failed: The account fails to be created.
        /// *   Scheduling: The account is being scheduled.
        /// *   ScheduleFailed: The account fails to be scheduled.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The time when the information about the account was updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
