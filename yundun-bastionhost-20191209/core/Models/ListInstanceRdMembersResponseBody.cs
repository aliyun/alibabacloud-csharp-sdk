// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListInstanceRdMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The value of MaxResults in the request. If you did not specify MaxResults, the default value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A list of member accounts.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<ListInstanceRdMembersResponseBodyMembers> Members { get; set; }
        public class ListInstanceRdMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <para>The UID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1197234496852779</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

        }

        /// <summary>
        /// <para>The token for the next page of results. If the response is truncated, this parameter is returned. Use this token in your next request to retrieve the next page. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ieSWJCwxvW3dk3wF.BqkrZmP72nWu5zJ5NWydMqyEs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
