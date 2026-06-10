// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateSimQuestionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16AC1B3C-66E0-438B-BB7C-71B692407B67</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The similar question ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000002788</para>
        /// </summary>
        [NameInMap("SimQuestionId")]
        [Validation(Required=false)]
        public long? SimQuestionId { get; set; }

    }

}
