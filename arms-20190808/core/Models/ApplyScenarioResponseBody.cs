// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ApplyScenarioResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The code of the business monitoring job, which is the coloring sign.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
