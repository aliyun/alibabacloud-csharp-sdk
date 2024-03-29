// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ConfigAppResponseBody : TeaModel {
        /// <summary>
        /// The result of turning on or off the main switch of the ARMS agent or the main switch status of the ARMS agent. Indicates whether the request was successful. Valid values: success failed The main switch status of the ARMS agent. Valid values: true false
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
