// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class GetLatestDataDiagnoseTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8B90B646-1678-41A3-B23F-EAC6587B0E48</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
