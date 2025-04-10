// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachCheatDetectionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cheatId")]
        [Validation(Required=false)]
        public string CheatId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-02-24 12:00:00</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("imageCheat")]
        [Validation(Required=false)]
        public GetAICoachCheatDetectionResponseBodyImageCheat ImageCheat { get; set; }
        public class GetAICoachCheatDetectionResponseBodyImageCheat : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GetAICoachCheatDetectionResponseBodyImageCheatList> List { get; set; }
            public class GetAICoachCheatDetectionResponseBodyImageCheatList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-03-22 10:05:07</para>
                /// </summary>
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://demo.com">https://demo.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E8B1746-AE35-5C4B-A3A8-345B274AE32C</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>true</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("voiceCheat")]
        [Validation(Required=false)]
        public GetAICoachCheatDetectionResponseBodyVoiceCheat VoiceCheat { get; set; }
        public class GetAICoachCheatDetectionResponseBodyVoiceCheat : TeaModel {
            [NameInMap("comparisonList")]
            [Validation(Required=false)]
            public List<GetAICoachCheatDetectionResponseBodyVoiceCheatComparisonList> ComparisonList { get; set; }
            public class GetAICoachCheatDetectionResponseBodyVoiceCheatComparisonList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-12-11 10:07:23</para>
                /// </summary>
                [NameInMap("time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://demo.com">https://demo.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("originalList")]
            [Validation(Required=false)]
            public List<GetAICoachCheatDetectionResponseBodyVoiceCheatOriginalList> OriginalList { get; set; }
            public class GetAICoachCheatDetectionResponseBodyVoiceCheatOriginalList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://demo.com">https://demo.com</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
