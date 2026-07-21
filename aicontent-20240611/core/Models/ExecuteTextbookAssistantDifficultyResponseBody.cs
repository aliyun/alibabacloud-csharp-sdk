// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantDifficultyResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned on a successful request.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantDifficultyResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantDifficultyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A container for the result data.</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantDifficultyResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantDifficultyResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The dialogue content after the difficulty adjustment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Let\&quot;s look at the text again. Mike says, \&quot;I\&quot;m Mike Black.\&quot; Can you try saying it like Mike?</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D7D382F-9475-572E-BE83-DDFBF5C5EB24</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
