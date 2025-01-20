// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class BatchCreateAICoachTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>10923AA3-F7A1-5EA0-ACCA-D704269EAA78</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

    }

}
