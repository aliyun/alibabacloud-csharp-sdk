// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class GenerateProductContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter is not returned for normal calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The processing result. If the call is successful, this parameter contains the copy data. If the business processing fails, an empty value is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GenerateProductContentResponseBodyData Data { get; set; }
        public class GenerateProductContentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The actual copy type that is processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>title</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The total number of characters in Data.Text, including formatting characters such as spaces, punctuation marks, and line breaks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54</para>
            /// </summary>
            [NameInMap("Length")]
            [Validation(Required=false)]
            public int? Length { get; set; }

            /// <summary>
            /// <para>The code of the actual output language.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ru</para>
            /// </summary>
            [NameInMap("OutputLanguage")]
            [Validation(Required=false)]
            public string OutputLanguage { get; set; }

            /// <summary>
            /// <para>Returned only when bullet points are successfully processed. The number of characters for each bullet point, which corresponds to Data.Points one by one.</para>
            /// </summary>
            [NameInMap("PointLengths")]
            [Validation(Required=false)]
            public List<int?> PointLengths { get; set; }

            /// <summary>
            /// <para>Returned only when bullet points are successfully processed. The text of the bullet points arranged in the output order.</para>
            /// </summary>
            [NameInMap("Points")]
            [Validation(Required=false)]
            public List<string> Points { get; set; }

            /// <summary>
            /// <para>The final copy. Generated keywords are separated by commas and spaces. Rewritten keywords are separated by spaces. Bullet points are separated by line breaks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Чашка Для Мороженого Из Нержавеющей Стали 14,5x10,8 см</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The usage information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;OutputCharacterCount&quot;:53,&quot;InputCharacterCount&quot;:8408}</para>
            /// </summary>
            [NameInMap("UsageMap")]
            [Validation(Required=false)]
            public Dictionary<string, int?> UsageMap { get; set; }

        }

        /// <summary>
        /// <para>The error message. This parameter is not returned for normal calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used for troubleshooting. This parameter may be empty in extreme exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the business processing is successful. Valid values: true (the output passes the verification) and false (the business processing fails).</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
