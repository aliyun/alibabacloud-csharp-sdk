// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleDiagnoseResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTitleDiagnoseResponseBodyData Data { get; set; }
        public class GetTitleDiagnoseResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Boy</para>
            /// </summary>
            [NameInMap("AllUppercaseWords")]
            [Validation(Required=false)]
            public string AllUppercaseWords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContainCoreClasses")]
            [Validation(Required=false)]
            public string ContainCoreClasses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>baba</para>
            /// </summary>
            [NameInMap("DisableWords")]
            [Validation(Required=false)]
            public string DisableWords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>hi</para>
            /// </summary>
            [NameInMap("DuplicateWords")]
            [Validation(Required=false)]
            public string DuplicateWords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("LanguageQualityScore")]
            [Validation(Required=false)]
            public string LanguageQualityScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("NoFirstUppercaseList")]
            [Validation(Required=false)]
            public string NoFirstUppercaseList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OverLengthLimit")]
            [Validation(Required=false)]
            public string OverLengthLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalScore")]
            [Validation(Required=false)]
            public string TotalScore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public string WordCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ahk</para>
            /// </summary>
            [NameInMap("WordSpelledCorrectError")]
            [Validation(Required=false)]
            public string WordSpelledCorrectError { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DC2DCCC9-C3DF-4F59-8D8E-78185729F16D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
