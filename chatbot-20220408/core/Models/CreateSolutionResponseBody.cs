// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateSolutionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>F55D90C1-31BE-4B2A-AA3F-25EFC36F9419</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100001089003</para>
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public long? SolutionId { get; set; }

    }

}
