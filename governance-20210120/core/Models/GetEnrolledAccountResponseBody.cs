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
        /// The ID of the baseline that was applied to the account.
        /// </summary>
        [NameInMap("BaselineId")]
        [Validation(Required=false)]
        public string BaselineId { get; set; }

        [NameInMap("BaselineItems")]
        [Validation(Required=false)]
        public List<GetEnrolledAccountResponseBodyBaselineItems> BaselineItems { get; set; }
        public class GetEnrolledAccountResponseBodyBaselineItems : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The time at which the account was created.
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
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorInfo")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyErrorInfo ErrorInfo { get; set; }
        public class GetEnrolledAccountResponseBodyErrorInfo : TeaModel {
            /// <summary>
            /// The error code returned.
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The suggestions that are used to resolve the issue.
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
        /// Indicates whether the account was initialized.
        /// </summary>
        [NameInMap("Initialized")]
        [Validation(Required=false)]
        public bool? Initialized { get; set; }

        /// <summary>
        /// The input parameters that are used when you enrolled the account.
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public GetEnrolledAccountResponseBodyInputs Inputs { get; set; }
        public class GetEnrolledAccountResponseBodyInputs : TeaModel {
            /// <summary>
            /// The prefix for the account name of the member.
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
            /// An array that contains baseline items.
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
                /// Indicates whether to skip the baseline item.
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
            /// The ID of the billing account.
            /// </summary>
            [NameInMap("PayerAccountUid")]
            [Validation(Required=false)]
            public long? PayerAccountUid { get; set; }

        }

        /// <summary>
        /// The ID of the master account to which the account belongs.
        /// </summary>
        [NameInMap("MasterAccountUid")]
        [Validation(Required=false)]
        public long? MasterAccountUid { get; set; }

        /// <summary>
        /// The ID of the billing account.
        /// </summary>
        [NameInMap("PayerAccountUid")]
        [Validation(Required=false)]
        public long? PayerAccountUid { get; set; }

        /// <summary>
        /// The progress of applying the account baseline to the account.
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
            /// The status of applying the account baseline to the account. Valid values:
            /// 
            /// *   Pending: The account is waiting to be created.
            /// *   Running: The account baseline is being applied to the account.
            /// *   Finished: The account baseline is applied to the account.
            /// *   Failed: The account baseline failed to be applied to the account.
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
        /// The creation status of the account. Valid values:
        /// 
        /// *   Pending: The account is waiting to be created.
        /// *   Running: The account is being created.
        /// *   Finished: The account is created.
        /// *   Failed: The account failed to be created.
        /// *   Scheduling: The account is being scheduled.
        /// *   ScheduleFailed: The account failed to be scheduled.
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
