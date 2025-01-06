// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeStatisticalDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ConversationTotalNum")]
        [Validation(Required=false)]
        public long? ConversationTotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>14C39896-AE6D-4643-9C9A-E0566B2C2DDD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ResolvedQuestionTotalNum")]
        [Validation(Required=false)]
        public long? ResolvedQuestionTotalNum { get; set; }

        [NameInMap("StatisticalDataReports")]
        [Validation(Required=false)]
        public List<DescribeStatisticalDataResponseBodyStatisticalDataReports> StatisticalDataReports { get; set; }
        public class DescribeStatisticalDataResponseBodyStatisticalDataReports : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>80.00%</para>
            /// </summary>
            [NameInMap("DialoguePassRate")]
            [Validation(Required=false)]
            public string DialoguePassRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80.00%</para>
            /// </summary>
            [NameInMap("KnowledgeHitRate")]
            [Validation(Required=false)]
            public string KnowledgeHitRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80.00%</para>
            /// </summary>
            [NameInMap("ResolutionRate")]
            [Validation(Required=false)]
            public string ResolutionRate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ResolvedQuestionNum")]
            [Validation(Required=false)]
            public int? ResolvedQuestionNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>19:00:00</para>
            /// </summary>
            [NameInMap("StatisticalDate")]
            [Validation(Required=false)]
            public string StatisticalDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalConversationNum")]
            [Validation(Required=false)]
            public int? TotalConversationNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>80.0</para>
            /// </summary>
            [NameInMap("ValidAnswerRate")]
            [Validation(Required=false)]
            public string ValidAnswerRate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80.00%</para>
        /// </summary>
        [NameInMap("TotalDialoguePassRate")]
        [Validation(Required=false)]
        public string TotalDialoguePassRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80.00%</para>
        /// </summary>
        [NameInMap("TotalKnowledgeHitRate")]
        [Validation(Required=false)]
        public string TotalKnowledgeHitRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80.00%</para>
        /// </summary>
        [NameInMap("TotalResolutionRate")]
        [Validation(Required=false)]
        public string TotalResolutionRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80.00%</para>
        /// </summary>
        [NameInMap("TotalValidAnswerRate")]
        [Validation(Required=false)]
        public string TotalValidAnswerRate { get; set; }

    }

}
