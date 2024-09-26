// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateConnQuestionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000002123</para>
        /// </summary>
        [NameInMap("OutlineId")]
        [Validation(Required=false)]
        public long? OutlineId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C191B48B-9268-4FB1-A3C2-5143B4A91D0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
