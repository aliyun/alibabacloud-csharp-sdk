// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifySiteMonitorResponseBody : TeaModel {
        /// <summary>
        /// The URL or IP address that is monitored by the task.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifySiteMonitorResponseBodyData Data { get; set; }
        public class ModifySiteMonitorResponseBodyData : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// The monitoring frequency. Valid values: 1, 5, 15, and 15000. Unit: milliseconds. Default value: 1.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The result of modifying the task.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
