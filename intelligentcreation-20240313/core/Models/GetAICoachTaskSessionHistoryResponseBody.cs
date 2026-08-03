// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class GetAICoachTaskSessionHistoryResponseBody : TeaModel {
        [NameInMap("conversationList")]
        [Validation(Required=false)]
        public List<GetAICoachTaskSessionHistoryResponseBodyConversationList> ConversationList { get; set; }
        public class GetAICoachTaskSessionHistoryResponseBodyConversationList : TeaModel {
            [NameInMap("audioUrl")]
            [Validation(Required=false)]
            public string AudioUrl { get; set; }

            [NameInMap("dateLabel")]
            [Validation(Required=false)]
            public string DateLabel { get; set; }

            [NameInMap("evaluationFeedback")]
            [Validation(Required=false)]
            public string EvaluationFeedback { get; set; }

            [NameInMap("evaluationResult")]
            [Validation(Required=false)]
            public string EvaluationResult { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("pauseDuration")]
        [Validation(Required=false)]
        public long? PauseDuration { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scriptName")]
        [Validation(Required=false)]
        public string ScriptName { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
