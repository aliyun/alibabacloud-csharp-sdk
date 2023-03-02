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
            /// The reason why the data source failed to be shared. If the data source was shared, this parameter is left empty.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the data source was shared. Valid values:
            /// 
            /// *   success: The data source was shared.
            /// *   fail: The data source failed to be shared. You can troubleshoot issues based on the Message parameter.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
