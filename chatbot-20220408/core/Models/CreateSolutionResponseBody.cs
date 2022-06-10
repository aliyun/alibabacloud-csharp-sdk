// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateSolutionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 答案ID
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public long? SolutionId { get; set; }

    }

}
