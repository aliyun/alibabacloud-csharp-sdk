// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class SwitchoverInstanceResponseBody : TeaModel {
        /// <summary>
        /// The list of data for the switchover.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SwitchoverInstanceResponseBodyData Data { get; set; }
        public class SwitchoverInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The message of the switchover.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Whether the switchover is successful.
            /// - true: the switchover succeeded.
            /// - false: the switchover failed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
