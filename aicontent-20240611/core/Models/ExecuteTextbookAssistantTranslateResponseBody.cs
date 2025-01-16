// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteTextbookAssistantTranslateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteTextbookAssistantTranslateResponseBodyData Data { get; set; }
        public class ExecuteTextbookAssistantTranslateResponseBodyData : TeaModel {
            [NameInMap("result")]
            [Validation(Required=false)]
            public ExecuteTextbookAssistantTranslateResponseBodyDataResult Result { get; set; }
            public class ExecuteTextbookAssistantTranslateResponseBodyDataResult : TeaModel {
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
        /// <para>&quot;&quot;</para>
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
        /// <para>9EB79C1E-36C2-5777-BED6-C23A98DF0637</para>
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
