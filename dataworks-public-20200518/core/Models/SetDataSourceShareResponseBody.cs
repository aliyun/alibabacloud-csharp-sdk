// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SetDataSourceShareResponseBody : TeaModel {
        /// <summary>
        /// The information about the sharing operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SetDataSourceShareResponseBodyData Data { get; set; }
        public class SetDataSourceShareResponseBodyData : TeaModel {
            /// <summary>
            /// The reason why the data source failed to be shared. If the data source is successfully shared, the value of this parameter is an empty string.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the data source was shared. Valid values:
            /// 
            /// *   success.
            /// *   fail. You can view the value of the Message parameter to identify the cause of the failure.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
