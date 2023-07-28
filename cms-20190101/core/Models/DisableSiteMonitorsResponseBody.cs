// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DisableSiteMonitorsResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// >  The status code 200 indicates a success.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of detection points that were monitored by the site monitoring tasks.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DisableSiteMonitorsResponseBodyData Data { get; set; }
        public class DisableSiteMonitorsResponseBodyData : TeaModel {
            /// <summary>
            /// The number of detection points.
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// The returned message.
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
        /// Indicates whether the operation was successful. Valid values:
        /// 
        /// *   true: successful.
        /// *   false: failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
