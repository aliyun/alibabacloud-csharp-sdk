// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualAnswerResponseBody : TeaModel {
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public Answer Answer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22F081FB-90D7-525A-BFE4-D28DC906A28F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
