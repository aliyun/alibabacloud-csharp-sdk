// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregatorResponseBody : TeaModel {
        /// <summary>
        /// The details of the account group.
        /// </summary>
        [NameInMap("Aggregator")]
        [Validation(Required=false)]
        public GetAggregatorResponseBodyAggregator Aggregator { get; set; }
        public class GetAggregatorResponseBodyAggregator : TeaModel {
            /// <summary>
            /// The ID of the management account that is used to create the account group.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// The number of member accounts in the account group.
            /// </summary>
            [NameInMap("AggregatorAccountCount")]
            [Validation(Required=false)]
            public long? AggregatorAccountCount { get; set; }

            /// <summary>
            /// The information about the member accounts in the account group.
            /// </summary>
            [NameInMap("AggregatorAccounts")]
            [Validation(Required=false)]
            public List<GetAggregatorResponseBodyAggregatorAggregatorAccounts> AggregatorAccounts { get; set; }
            public class GetAggregatorResponseBodyAggregatorAggregatorAccounts : TeaModel {
                /// <summary>
                /// The ID of the member account.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The name of the member account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// The type of the member account. Only ResourceDirectory is returned, which indicates that the account is a resource directory account.
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

                /// <summary>
                /// The status of the configuration recorder for the member account. Valid values:
                /// 
                /// *   REGISTRABLE: The configuration recorder is not registered.
                /// *   BUILDING: The configuration recorder is being deployed.
                /// *   REGISTERED: The configuration recorder is registered.
                /// *   REBUILDING: The configuration recorder is being redeployed.
                /// </summary>
                [NameInMap("RecorderStatus")]
                [Validation(Required=false)]
                public string RecorderStatus { get; set; }

            }

            /// <summary>
            /// The timestamp generated when the account group was created.
            /// </summary>
            [NameInMap("AggregatorCreateTimestamp")]
            [Validation(Required=false)]
            public string AggregatorCreateTimestamp { get; set; }

            /// <summary>
            /// The ID of the account group.
            /// </summary>
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            /// <summary>
            /// The name of the account group.
            /// </summary>
            [NameInMap("AggregatorName")]
            [Validation(Required=false)]
            public string AggregatorName { get; set; }

            /// <summary>
            /// The status of the account group. Valid values:
            /// 
            /// *   0: The account group is being created.
            /// *   1: The account group was created.
            /// </summary>
            [NameInMap("AggregatorStatus")]
            [Validation(Required=false)]
            public int? AggregatorStatus { get; set; }

            /// <summary>
            /// The type of the account group. Valid values:
            /// 
            /// *   RD: a global account group.
            /// *   FOLDER: an account group for a folder.
            /// *   CUSTOM: a custom account group.
            /// </summary>
            [NameInMap("AggregatorType")]
            [Validation(Required=false)]
            public string AggregatorType { get; set; }

            /// <summary>
            /// The description of the account group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the attached folder of the account group.
            /// </summary>
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
