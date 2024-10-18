// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryConferenceInfoResponseBody : TeaModel {
        [NameInMap("confInfo")]
        [Validation(Required=false)]
        public QueryConferenceInfoResponseBodyConfInfo ConfInfo { get; set; }
        public class QueryConferenceInfoResponseBodyConfInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ActiveNum")]
            [Validation(Required=false)]
            public int? ActiveNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AttendNum")]
            [Validation(Required=false)]
            public int? AttendNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000000</para>
            /// </summary>
            [NameInMap("ConfDuration")]
            [Validation(Required=false)]
            public long? ConfDuration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>607452e01401526ee39609e1</para>
            /// </summary>
            [NameInMap("ConferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>208579</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("CreatorNick")]
            [Validation(Required=false)]
            public string CreatorNick { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1663294270000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://meeting.dingtalk.com/app?roomCode=42726xxx&token=1_7ac9xxx">https://meeting.dingtalk.com/app?roomCode=42726xxx&amp;token=1_7ac9xxx</a></para>
            /// </summary>
            [NameInMap("ExternalLinkUrl")]
            [Validation(Required=false)]
            public string ExternalLinkUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InvitedNum")]
            [Validation(Required=false)]
            public int? InvitedNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4272xxxxx</para>
            /// </summary>
            [NameInMap("RoomCode")]
            [Validation(Required=false)]
            public string RoomCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1663293270000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>4248DCC9-785F-5A14-8BE0-830FD52E1261</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
