// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class QueryConferenceMembersResponseBody : TeaModel {
        [NameInMap("memberModels")]
        [Validation(Required=false)]
        public List<QueryConferenceMembersResponseBodyMemberModels> MemberModels { get; set; }
        public class QueryConferenceMembersResponseBodyMemberModels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("AttendStatus")]
            [Validation(Required=false)]
            public int? AttendStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CoHost")]
            [Validation(Required=false)]
            public bool? CoHost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6323dxxxxx</para>
            /// </summary>
            [NameInMap("ConferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public bool? Host { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1663293270000</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1663293280000</para>
            /// </summary>
            [NameInMap("LeaveTime")]
            [Validation(Required=false)]
            public long? LeaveTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OuterOrgMember")]
            [Validation(Required=false)]
            public bool? OuterOrgMember { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("PstnJoin")]
            [Validation(Required=false)]
            public bool? PstnJoin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>-12345</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>小钉</para>
            /// </summary>
            [NameInMap("UserNick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123000000</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
