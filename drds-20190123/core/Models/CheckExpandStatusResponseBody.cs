// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CheckExpandStatusResponseBody : TeaModel {
        /// <summary>
        /// The result of the verification.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CheckExpandStatusResponseBodyData Data { get; set; }
        public class CheckExpandStatusResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether scale-out operations can be performed on the database.
            /// </summary>
            [NameInMap("IsActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("Msg")]
            [Validation(Required=false)]
            public string Msg { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result of the request.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
