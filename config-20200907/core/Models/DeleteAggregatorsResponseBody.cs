// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregatorsResponseBody : TeaModel {
        /// <summary>
        /// The returned result.
        /// </summary>
        [NameInMap("OperateAggregatorsResult")]
        [Validation(Required=false)]
        public DeleteAggregatorsResponseBodyOperateAggregatorsResult OperateAggregatorsResult { get; set; }
        public class DeleteAggregatorsResponseBodyOperateAggregatorsResult : TeaModel {
            /// <summary>
            /// The details of the account group.
            /// </summary>
            [NameInMap("OperateAggregators")]
            [Validation(Required=false)]
            public List<DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators> OperateAggregators { get; set; }
            public class DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators : TeaModel {
                /// <summary>
                /// The ID of the account group.
                /// </summary>
                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

                /// <summary>
                /// The error code returned.
                /// 
                /// > No error code is returned for the account group if the account group is deleted.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// Indicates whether the request was successful. Valid values:
                /// 
                /// *   true: The request was successful.
                /// *   false: The request failed.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
