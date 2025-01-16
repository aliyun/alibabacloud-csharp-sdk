// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantRefineByContextResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantRefineByContextResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantRefineByContextResponseBodyData : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantRefineByContextResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantRefineByContextResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Good evening! From the book, how does Mike Black introduce himself?</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

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
        public int? ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F73C114-A76E-51AD-99E3-BC7B941B69E0</para>
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
