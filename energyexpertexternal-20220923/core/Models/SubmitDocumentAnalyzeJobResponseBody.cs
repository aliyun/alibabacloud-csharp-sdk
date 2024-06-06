// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitDocumentAnalyzeJobResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public SubmitDocumentAnalyzeJobResponseBodyData Data { get; set; }
        public class SubmitDocumentAnalyzeJobResponseBodyData : TeaModel {
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
