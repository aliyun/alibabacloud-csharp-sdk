// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeConnectionStatusResponseBody : TeaModel {
        /// <summary>
        /// The connectivity of DTS servers to the destination database.
        /// </summary>
        [NameInMap("DestinationConnectionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> DestinationConnectionStatus { get; set; }

        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The connectivity of DTS servers to the source database.
        /// </summary>
        [NameInMap("SourceConnectionStatus")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceConnectionStatus { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
