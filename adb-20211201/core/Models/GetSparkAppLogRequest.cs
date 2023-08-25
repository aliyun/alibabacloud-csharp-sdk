// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetSparkAppLogRequest : TeaModel {
        /// <summary>
        /// The number of log entries to return. Valid values: 1 to 500. Default value: 300.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("LogLength")]
        [Validation(Required=false)]
        public long? LogLength { get; set; }

    }

}
