// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AllocateCostUnitResourceResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AllocateCostUnitResourceResponseBodyData Data { get; set; }
        public class AllocateCostUnitResourceResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether resources are allocated to the specified cost center. Valid values:
            /// 
            /// *   true: The resources are allocated to the specified cost center.
            /// *   false: The resources fail to be allocated to the specified cost center.
            /// </summary>
            [NameInMap("IsSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

            /// <summary>
            /// The ID of the destination cost center.
            /// </summary>
            [NameInMap("ToUnitId")]
            [Validation(Required=false)]
            public long? ToUnitId { get; set; }

            /// <summary>
            /// The user ID of the owner of the destination cost center.
            /// </summary>
            [NameInMap("ToUnitUserId")]
            [Validation(Required=false)]
            public long? ToUnitUserId { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
