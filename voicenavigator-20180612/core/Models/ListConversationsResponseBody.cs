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

            /// <summary>
            /// <b>Example:</b>
            /// <para>135815884***</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>82b2eaae-ce5c-45f8-8231-f15b6b27e55c</para>
            /// </summary>
            [NameInMap("ConversationId")]
            [Validation(Required=false)]
            public string ConversationId { get; set; }

            [NameInMap("DsReport")]
            [Validation(Required=false)]
            public string DsReport { get; set; }

            [NameInMap("DsReportTitles")]
            [Validation(Required=false)]
            public List<string> DsReportTitles { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1582266750353</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            [NameInMap("HasToAgent")]
            [Validation(Required=false)]
            public bool? HasToAgent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Rounds")]
            [Validation(Required=false)]
            public int? Rounds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SandBox")]
            [Validation(Required=false)]
            public bool? SandBox { get; set; }

            [NameInMap("SkillGroup")]
            [Validation(Required=false)]
            public string SkillGroup { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1641625694286</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a2c26e67-5984-4935-984e-bcee52971993</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
