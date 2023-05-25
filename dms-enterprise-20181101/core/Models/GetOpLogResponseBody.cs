// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetOpLogResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of the operation log.
        /// </summary>
        [NameInMap("OpLogDetails")]
        [Validation(Required=false)]
        public GetOpLogResponseBodyOpLogDetails OpLogDetails { get; set; }
        public class GetOpLogResponseBodyOpLogDetails : TeaModel {
            [NameInMap("OpLogDetail")]
            [Validation(Required=false)]
            public List<GetOpLogResponseBodyOpLogDetailsOpLogDetail> OpLogDetail { get; set; }
            public class GetOpLogResponseBodyOpLogDetailsOpLogDetail : TeaModel {
                /// <summary>
                /// The endpoint of the database instance.
                /// 
                /// > 
                /// 
                /// *   This parameter is valid only for database instances of the LocalInstance type.
                /// 
                /// *   This parameter is valid only for operations on the functional modules related to tasks.
                /// </summary>
                [NameInMap("Database")]
                [Validation(Required=false)]
                public string Database { get; set; }

                /// <summary>
                /// The functional module for which the operation log is queried.
                /// </summary>
                [NameInMap("Module")]
                [Validation(Required=false)]
                public string Module { get; set; }

                /// <summary>
                /// The details of the operation.
                /// </summary>
                [NameInMap("OpContent")]
                [Validation(Required=false)]
                public string OpContent { get; set; }

                /// <summary>
                /// The time when the operation was performed.
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                /// <summary>
                /// The ID of the user who performed the operation.
                /// </summary>
                [NameInMap("OpUserId")]
                [Validation(Required=false)]
                public long? OpUserId { get; set; }

                /// <summary>
                /// The ID of the ticket or task.
                /// 
                /// >  This parameter is valid only for operations on the functional modules related to tasks and the task management module in system management.
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The display name of the user.
                /// </summary>
                [NameInMap("UserNick")]
                [Validation(Required=false)]
                public string UserNick { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of operation logs that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
