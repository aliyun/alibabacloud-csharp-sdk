// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListOperationResponseBody : TeaModel {
        /// <summary>
        /// The response parameters.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListOperationResponseBodyData Data { get; set; }
        public class ListOperationResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the user is an administrator. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("AdminOrNot")]
            [Validation(Required=false)]
            public bool? AdminOrNot { get; set; }

            /// <summary>
            /// The resources on which the permissions are granted.
            /// </summary>
            [NameInMap("OperationList")]
            [Validation(Required=false)]
            public List<string> OperationList { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
