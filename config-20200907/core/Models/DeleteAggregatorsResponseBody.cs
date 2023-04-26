// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregatorsResponseBody : TeaModel {
        /// <summary>
        /// The result for the account group.
        /// </summary>
        [NameInMap("OperateAggregatorsResult")]
        [Validation(Required=false)]
        public DeleteAggregatorsResponseBodyOperateAggregatorsResult OperateAggregatorsResult { get; set; }
        public class DeleteAggregatorsResponseBodyOperateAggregatorsResult : TeaModel {
            /// <summary>
            /// The error code.
            /// 
            /// >  No error code is returned for the account group if the account group is deleted.
            /// </summary>
            [NameInMap("OperateAggregators")]
            [Validation(Required=false)]
            public List<DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators> OperateAggregators { get; set; }
            public class DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators : TeaModel {
                [NameInMap("AggregatorId")]
                [Validation(Required=false)]
                public string AggregatorId { get; set; }

                /// <summary>
                /// Indicates whether the delete operation is successful. Valid values:
                /// 
                /// *   true: The account group is deleted.
                /// *   false: The account group fails to be deleted.
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// The ID of the account group.
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

        }

        /// <summary>
        /// The results of the delete operations.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
