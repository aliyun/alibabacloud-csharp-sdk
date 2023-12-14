// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ShowQuickAnalysisResponseBody : TeaModel {
        /// <summary>
        /// The index fields.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ShowQuickAnalysisResponseBodyData Data { get; set; }
        public class ShowQuickAnalysisResponseBodyData : TeaModel {
            /// <summary>
            /// The index fields of the logs.
            /// </summary>
            [NameInMap("IndexList")]
            [Validation(Required=false)]
            public List<string> IndexList { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
