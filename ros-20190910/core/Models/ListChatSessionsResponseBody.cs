// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListChatSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A compatibility field. This field is not returned in the current V2 response. Use the MaxResults request parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next page. This field may not be returned or may be null on the last page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CAES...</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C68F7A5-2D16-5C8F-A4B1-01E9C6A9B0D2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session list of the current user, sorted by update time in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<ListChatSessionsResponseBodySessions> Sessions { get; set; }
        public class ListChatSessionsResponseBodySessions : TeaModel {
            /// <summary>
            /// <para>The session mode. Valid values: IaCCodeNormal and IaCCodePipeline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IaCCodePipeline</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The session ID. You can use this ID to re-enter a session in StartChat, stop a session in StopChat, or query messages in ListChatMessages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7f4e2a8c6d9b4a1f8e3c5b7d2a6f9012</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

            /// <summary>
            /// <para>The session summary. This field currently shares the same source as Title and may be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create a VPC template</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The session title. This field may be empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Create a VPC template</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>A compatibility field. This field is not returned in the current V2 response. Use UpdatedAt instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-26T10:00:00Z</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

        }

    }

}
