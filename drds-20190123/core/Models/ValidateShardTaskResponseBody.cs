// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ValidateShardTaskResponseBody : TeaModel {
        /// <summary>
        /// Indicates the check results.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ValidateShardTaskResponseBodyList> List { get; set; }
        public class ValidateShardTaskResponseBodyList : TeaModel {
            /// <summary>
            /// Indicates the name of a check item.
            /// </summary>
            [NameInMap("Item")]
            [Validation(Required=false)]
            public string Item { get; set; }

            /// <summary>
            /// Indicates the result of the check item. Valid values:
            /// 
            /// *   **0**: indicates the task is valid.
            /// *   **1**: indicates the task is invalid.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

        }

        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
