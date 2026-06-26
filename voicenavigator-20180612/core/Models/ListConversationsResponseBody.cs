// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ListConversationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of conversation objects.</para>
        /// </summary>
        [NameInMap("Conversations")]
        [Validation(Required=false)]
        public List<ListConversationsResponseBodyConversations> Conversations { get; set; }
        public class ListConversationsResponseBodyConversations : TeaModel {
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
            /// <para>The unique ID of the conversation.</para>
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
            /// <para>The reason that the conversation ended. Valid values:<br>1: The conversation completed normally.<br>2: The bot hung up after a recognition failure.<br>3: The call was disconnected due to a silence timeout.<br>4: The user hung up after a recognition failure.<br>5: The user hung up for an unknown reason.<br>6: The call was transferred to an agent because an intent was matched.<br>7: The call was transferred to an agent due to a recognition failure.<br>8: No interaction from the user.<br>9: The call was interrupted by a system error.<br>10: The call was transferred to an IVR system because an intent was matched.<br>11: The call was transferred to an IVR system due to a recognition failure.<br><br><br><br><br><br><br><br><br><br><br></para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EndReason")]
            [Validation(Required=false)]
            public int? EndReason { get; set; }

            /// <summary>
            /// <para>The end time of the conversation, represented as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1582266750353</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the final audio playback was completed before the call was disconnected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            /// <summary>
            /// <para>Indicates whether the conversation was transferred to an agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasToAgent")]
            [Validation(Required=false)]
            public bool? HasToAgent { get; set; }

            /// <summary>
            /// <para>The number of rounds in the conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Rounds")]
            [Validation(Required=false)]
            public int? Rounds { get; set; }

            /// <summary>
            /// <para>Indicates whether the conversation was run in a sandbox environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SandBox")]
            [Validation(Required=false)]
            public bool? SandBox { get; set; }

            /// <summary>
            /// <para>The ID of the skill group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skg-123</para>
            /// </summary>
            [NameInMap("SkillGroup")]
            [Validation(Required=false)]
            public string SkillGroup { get; set; }

            /// <summary>
            /// <para>The start time of the conversation, represented as a Unix timestamp in milliseconds.</para>
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
        /// <para>The total number of conversations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
