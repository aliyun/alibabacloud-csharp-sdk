// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class DescribeStatisticalDataResponseBody : TeaModel {
        [NameInMap("ConversationTotalNum")]
        [Validation(Required=false)]
        public long? ConversationTotalNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResolvedQuestionTotalNum")]
        [Validation(Required=false)]
        public long? ResolvedQuestionTotalNum { get; set; }

        [NameInMap("StatisticalDataReports")]
        [Validation(Required=false)]
        public List<DescribeStatisticalDataResponseBodyStatisticalDataReports> StatisticalDataReports { get; set; }
        public class DescribeStatisticalDataResponseBodyStatisticalDataReports : TeaModel {
            [NameInMap("DialoguePassRate")]
            [Validation(Required=false)]
            public string DialoguePassRate { get; set; }

            [NameInMap("KnowledgeHitRate")]
            [Validation(Required=false)]
            public string KnowledgeHitRate { get; set; }

            [NameInMap("ResolutionRate")]
            [Validation(Required=false)]
            public string ResolutionRate { get; set; }

            [NameInMap("ResolvedQuestionNum")]
            [Validation(Required=false)]
            public int? ResolvedQuestionNum { get; set; }

            [NameInMap("StatisticalDate")]
            [Validation(Required=false)]
            public string StatisticalDate { get; set; }

            [NameInMap("TotalConversationNum")]
            [Validation(Required=false)]
            public int? TotalConversationNum { get; set; }

            [NameInMap("ValidAnswerRate")]
            [Validation(Required=false)]
            public string ValidAnswerRate { get; set; }

        }

        [NameInMap("TotalDialoguePassRate")]
        [Validation(Required=false)]
        public string TotalDialoguePassRate { get; set; }

        [NameInMap("TotalKnowledgeHitRate")]
        [Validation(Required=false)]
        public string TotalKnowledgeHitRate { get; set; }

        [NameInMap("TotalResolutionRate")]
        [Validation(Required=false)]
        public string TotalResolutionRate { get; set; }

        [NameInMap("TotalValidAnswerRate")]
        [Validation(Required=false)]
        public string TotalValidAnswerRate { get; set; }

    }

}
