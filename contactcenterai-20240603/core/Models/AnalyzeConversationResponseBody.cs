// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class AnalyzeConversationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidUser.NotFound</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorInfo")]
        [Validation(Required=false)]
        public string ErrorInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>stop</para>
        /// </summary>
        [NameInMap("finishReason")]
        [Validation(Required=false)]
        public string FinishReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>968A8634-FA2C-5381-9B3E-C552DED7E8BF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
