// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class UploadTranslationFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadTranslationFileResponseBodyData Data { get; set; }
        public class UploadTranslationFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the estimated Credits billing and time consumption for the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>docx: 0.002 creadits/word × 1000 words (original 2 characters rounded up to nearest thousand) / 1000 = 0.002</para>
            /// </summary>
            [NameInMap("CreditBreakdown")]
            [Validation(Required=false)]
            public string CreditBreakdown { get; set; }

            /// <summary>
            /// <para>Indicates whether the available Credits are sufficient for this translation task.</para>
            /// <list type="bullet">
            /// <item><description>The estimate may be affected by various factors and may deviate. The actual result is based on the task submission operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("CreditsAvailable")]
            [Validation(Required=false)]
            public bool? CreditsAvailable { get; set; }

            /// <summary>
            /// <para>The detected language type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("DetectedLang")]
            [Validation(Required=false)]
            public string DetectedLang { get; set; }

            /// <summary>
            /// <para>The estimated Credits consumption.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.0021</para>
            /// </summary>
            [NameInMap("EstimatedCostCredits")]
            [Validation(Required=false)]
            public double? EstimatedCostCredits { get; set; }

            /// <summary>
            /// <para>The estimated translation time in <b>seconds</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60000</para>
            /// </summary>
            [NameInMap("EstimatedTime")]
            [Validation(Required=false)]
            public long? EstimatedTime { get; set; }

            /// <summary>
            /// <para>The languages that support font modification and the corresponding font lists. The key of the map identifies the language type.</para>
            /// <list type="bullet">
            /// <item><description>Currently supported fonts include: English, French, Indonesian, and Japanese.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Fonts")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Fonts { get; set; }

            /// <summary>
            /// <para>The page count of the uploaded file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }

            /// <summary>
            /// <para>Indicates whether sensitive information was detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("SensitiveDetected")]
            [Validation(Required=false)]
            public bool? SensitiveDetected { get; set; }

            /// <summary>
            /// <para>The keywords that matched sensitive information.</para>
            /// </summary>
            [NameInMap("SensitiveTags")]
            [Validation(Required=false)]
            public List<string> SensitiveTags { get; set; }

            /// <summary>
            /// <para>The translation task ID, used for subsequent task submission.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f9c35b0453b</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The word count of the uploaded file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public long? WordCount { get; set; }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F60AC23C-27A7-5376-9A68-0B6EF2D4F9E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
