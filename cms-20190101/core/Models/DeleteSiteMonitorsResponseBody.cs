// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteSiteMonitorsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the site monitoring tasks that were deleted.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSiteMonitorsResponseBodyData Data { get; set; }
        public class DeleteSiteMonitorsResponseBodyData : TeaModel {
            /// <summary>
            /// The number of the site monitoring tasks that were deleted.
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// The returned message. If the call was successful, the value success is returned. If the call failed, an error message such as `TaskId not found` is returned.
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
        /// Indicates whether the call was successful. The value true indicates success. The value false indicates failure.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
