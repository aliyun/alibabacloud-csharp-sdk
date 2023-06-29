// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ExecDatamaskResponseBody : TeaModel {
        /// <summary>
        /// The de-identified data, which is described in a JSON string. The JSON string contains the following parameters:
        /// 
        /// *   **dataHeaderList**: the names of columns that contain the de-identified data.
        /// *   **dataList**: the de-identified data. The column order of the de-identified data is the same as that indicated by the dataHeaderList parameter.
        /// *   **ruleList**: the IDs of sensitive data detection rules.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
