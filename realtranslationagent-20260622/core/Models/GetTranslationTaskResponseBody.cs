// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class GetTranslationTaskResponseBody : TeaModel {
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
        public GetTranslationTaskResponseBodyData Data { get; set; }
        public class GetTranslationTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The translation task ID of a previously submitted task. This parameter is passed in when resubmitting a translation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f9c35b0453b</para>
            /// </summary>
            [NameInMap("BaseTaskId")]
            [Validation(Required=false)]
            public string BaseTaskId { get; set; }

            /// <summary>
            /// <para>The translation configuration.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetTranslationTaskResponseBodyDataConfig Config { get; set; }
            public class GetTranslationTaskResponseBodyDataConfig : TeaModel {
                /// <summary>
                /// <para>The security level.</para>
                /// <list type="bullet">
                /// <item><description>public: Standard confidentiality.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>public</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>The source file language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("SourceLanguage")]
                [Validation(Required=false)]
                public string SourceLanguage { get; set; }

                /// <summary>
                /// <para>The translation style. This parameter takes effect only when the translation file is a PPT file.</para>
                /// <list type="bullet">
                /// <item><description>normal: Standard. The original information is fully preserved.</description></item>
                /// <item><description>minimal: More concise information with a more visually appealing layout.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>minimal</para>
                /// </summary>
                [NameInMap("Style")]
                [Validation(Required=false)]
                public string Style { get; set; }

                /// <summary>
                /// <para>The target language.</para>
                /// 
                /// <b>Example:</b>
                /// <para>en</para>
                /// </summary>
                [NameInMap("TargetLanguage")]
                [Validation(Required=false)]
                public string TargetLanguage { get; set; }

                /// <summary>
                /// <para>The translation template.</para>
                /// <list type="bullet">
                /// <item><description>common: General-purpose.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>common</para>
                /// </summary>
                [NameInMap("Template")]
                [Validation(Required=false)]
                public string Template { get; set; }

            }

            /// <summary>
            /// <para>The credits consumed by this task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.5510</para>
            /// </summary>
            [NameInMap("CostCredits")]
            [Validation(Required=false)]
            public double? CostCredits { get; set; }

            /// <summary>
            /// <para>The time consumed, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>43</para>
            /// </summary>
            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public long? CostTime { get; set; }

            /// <summary>
            /// <para>The error message when the task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The estimated credits to be consumed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.5510</para>
            /// </summary>
            [NameInMap("EstimatedCostCredits")]
            [Validation(Required=false)]
            public double? EstimatedCostCredits { get; set; }

            /// <summary>
            /// <para>The estimated translation time, in <b>seconds</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40000</para>
            /// </summary>
            [NameInMap("EstimatedTime")]
            [Validation(Required=false)]
            public long? EstimatedTime { get; set; }

            /// <summary>
            /// <para>The terms used in this task.</para>
            /// </summary>
            [NameInMap("ExtractedTerms")]
            [Validation(Required=false)]
            public List<GetTranslationTaskResponseBodyDataExtractedTerms> ExtractedTerms { get; set; }
            public class GetTranslationTaskResponseBodyDataExtractedTerms : TeaModel {
                /// <summary>
                /// <para>The source term.</para>
                /// 
                /// <b>Example:</b>
                /// <para>puppy</para>
                /// </summary>
                [NameInMap("SourceTerm")]
                [Validation(Required=false)]
                public string SourceTerm { get; set; }

                /// <summary>
                /// <para>The translated term.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dog</para>
                /// </summary>
                [NameInMap("TargetTerm")]
                [Validation(Required=false)]
                public string TargetTerm { get; set; }

            }

            /// <summary>
            /// <para>The parsed file format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PPTX</para>
            /// </summary>
            [NameInMap("FileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>translated_a_file.pptx</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The task completion time, expressed as a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1774147442</para>
            /// </summary>
            [NameInMap("FinishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The languages that support font modification and the corresponding font lists. The key of the map identifies the language type. Currently supported languages include English, French, Indonesian, and Japanese.</para>
            /// </summary>
            [NameInMap("Fonts")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Fonts { get; set; }

            /// <summary>
            /// <para>The organization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>org_e5b74*****9c94209</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The source file address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>translated_a_file.pptx</para>
            /// </summary>
            [NameInMap("OriginalFileName")]
            [Validation(Required=false)]
            public string OriginalFileName { get; set; }

            /// <summary>
            /// <para>The page count of the uploaded file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }

            /// <summary>
            /// <para>The progress, expressed as a percentage number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROCESSING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The translation task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f9c35b0453b</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// <list type="bullet">
            /// <item><description>DOCUMENT: Document type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DOCUMENT</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The word count of the uploaded document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600</para>
            /// </summary>
            [NameInMap("WordCount")]
            [Validation(Required=false)]
            public long? WordCount { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c2b898f******c985c</para>
            /// </summary>
            [NameInMap("WorkSpaceId")]
            [Validation(Required=false)]
            public string WorkSpaceId { get; set; }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDD51FD8-93E0-5161-BCA6-38A8393F26D9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
