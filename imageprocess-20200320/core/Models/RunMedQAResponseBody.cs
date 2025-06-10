// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class RunMedQAResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RunMedQAResponseBodyData Data { get; set; }
        public class RunMedQAResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("AnswerType")]
            [Validation(Required=false)]
            public string AnswerType { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public List<string> Options { get; set; }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("QuestionType")]
            [Validation(Required=false)]
            public string QuestionType { get; set; }

            [NameInMap("Reports")]
            [Validation(Required=false)]
            public Dictionary<string, string> Reports { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d1f6a6c2444f4c01adfadd413938e5c7</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BFF7EEC3-F6B5-4387-AC1D-BB095A1A02E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
