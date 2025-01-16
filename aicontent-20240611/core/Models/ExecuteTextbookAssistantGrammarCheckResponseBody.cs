// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantGrammarCheckResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantGrammarCheckResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantGrammarCheckResponseBodyData : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantGrammarCheckResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantGrammarCheckResponseBodyDataResult : TeaModel {
                [NameInMap("analysis")]
                [Validation(Required=false)]
                public string Analysis { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>I am you.</para>
                /// </summary>
                [NameInMap("correction")]
                [Validation(Required=false)]
                public string Correction { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Has_Error</para>
                /// </summary>
                [NameInMap("correctionStatus")]
                [Validation(Required=false)]
                public string CorrectionStatus { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1e96d17091734639835114e12c8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
