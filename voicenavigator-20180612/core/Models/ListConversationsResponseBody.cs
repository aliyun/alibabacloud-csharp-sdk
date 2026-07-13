// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListConversationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of sessions.</para>
        /// </summary>
        [NameInMap("Conversations")]
        [Validation(Required=false)]
        public List<ListConversationsResponseBodyConversations> Conversations { get; set; }
        public class ListConversationsResponseBodyConversations : TeaModel {
            [NameInMap("AbTestName")]
            [Validation(Required=false)]
            public string AbTestName { get; set; }

            /// <summary>
            /// <para>The called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12356</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135815884***</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <para>The session ID.</para>
            /// 
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
            /// <para>The reason for hanging up. Valid values:
            ///      1: Normal completion.
            ///      2: Bot hung up after unrecognized input.
            ///      3: Hung up due to silence timeout.
            ///      4: User hung up after unrecognized input.
            ///      5: User hung up without reason.
            ///      6: Transferred to human agent due to intent match.
            ///      7: Transferred to human agent due to unrecognized input.
            ///      8: No interaction from the user side.
            ///      9: System exception interruption.
            ///      10: Transferred to IVR due to intent match.
            ///      11: Transferred to IVR due to unrecognized input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582266750353</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the last playback was completed when the session ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            /// <summary>
            /// <para>Indicates whether the session was transferred to a human agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasToAgent")]
            [Validation(Required=false)]
            public bool? HasToAgent { get; set; }

            /// <summary>
            /// <para>The number of conversation rounds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Rounds")]
            [Validation(Required=false)]
            public int? Rounds { get; set; }

            /// <summary>
            /// <para>Indicates whether the session is in a sandbox environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SandBox")]
            [Validation(Required=false)]
            public bool? SandBox { get; set; }

            /// <summary>
            /// <para>The skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skg-123</para>
            /// </summary>
            [NameInMap("SkillGroup")]
            [Validation(Required=false)]
            public string SkillGroup { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1641625694286</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2c26e67-5984-4935-984e-bcee52971993</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
