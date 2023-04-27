// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportDownloadURLResponseBody : TeaModel {
        /// <summary>
        /// The ID of the ticket. You can call the [ListOrders](~~144643~~) operation to obtain the ticket ID.
        /// </summary>
        [NameInMap("DownloadURLResult")]
        [Validation(Required=false)]
        public GetDataExportDownloadURLResponseBodyDownloadURLResult DownloadURLResult { get; set; }
        public class GetDataExportDownloadURLResponseBodyDownloadURLResult : TeaModel {
            /// <summary>
            /// Indicates whether export results are available for download. Valid values:
            /// 
            /// *   **true**: Export results are available for download.
            /// *   **false**: No export results are available for download.
            /// </summary>
            [NameInMap("HasResult")]
            [Validation(Required=false)]
            public bool? HasResult { get; set; }

            /// <summary>
            /// The error code.
            /// </summary>
            [NameInMap("TipMessage")]
            [Validation(Required=false)]
            public string TipMessage { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("URL")]
            [Validation(Required=false)]
            public string URL { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **GetDataExportDownloadURL**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
