// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregatorsResponseBody : TeaModel {
        /// <summary>
        /// The account groups.
        /// </summary>
        [NameInMap("AggregatorsResult")]
        [Validation(Required=false)]
        public ListAggregatorsResponseBodyAggregatorsResult AggregatorsResult { get; set; }
        public class ListAggregatorsResponseBodyAggregatorsResult : TeaModel {
            /// <summary>
            /// The information about the account groups.
            /// </summary>
            [NameInMap("Aggregators")]
            [Validation(Required=false)]
            public List<ListAggregatorsResponseBodyAggregatorsResultAggregators> Aggregators { get; set; }
            public class ListAggregatorsResponseBodyAggregatorsResultAggregators : TeaModel {
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
                /// The timestamp generated when the account group was created.
                /// </summary>
                [NameInMap("AggregatorCreateTimestamp")]
                [Validation(Required=false)]
                public long? AggregatorCreateTimestamp { get; set; }

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
                /// *   RD: global account group.
                /// *   FOLDER: account group of the folder.
                /// *   CUSTOM: custom account group.
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
                /// The information about the member accounts in the account group.
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

            }

            /// <summary>
            /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of `NextToken`.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
