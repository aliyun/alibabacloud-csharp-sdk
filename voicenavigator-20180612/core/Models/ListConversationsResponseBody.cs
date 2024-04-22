// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListConversationsResponseBody : TeaModel {
        [NameInMap("Conversations")]
        [Validation(Required=false)]
        public List<ListConversationsResponseBodyConversations> Conversations { get; set; }
        public class ListConversationsResponseBodyConversations : TeaModel {
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            [NameInMap("DsReport")]
            [Validation(Required=false)]
            public string DsReport { get; set; }

            [NameInMap("DsReportTitles")]
            [Validation(Required=false)]
            public List<string> DsReportTitles { get; set; }

            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            [NameInMap("HasToAgent")]
            [Validation(Required=false)]
            public bool? HasToAgent { get; set; }

            [NameInMap("Rounds")]
            [Validation(Required=false)]
            public int? Rounds { get; set; }

            [NameInMap("SandBox")]
            [Validation(Required=false)]
            public bool? SandBox { get; set; }

            [NameInMap("SkillGroup")]
            [Validation(Required=false)]
            public string SkillGroup { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
