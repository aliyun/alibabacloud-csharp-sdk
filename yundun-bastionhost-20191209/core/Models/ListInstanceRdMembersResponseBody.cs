// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListInstanceRdMembersResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per request. If a valid MaxResults value is specified in the request parameter, the specified value is returned. Otherwise, the default value is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of member accounts.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<ListInstanceRdMembersResponseBodyMembers> Members { get; set; }
        public class ListInstanceRdMembersResponseBodyMembers : TeaModel {
            /// <summary>
            /// <para>The UID of the member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1197234496852779</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

        }

        /// <summary>
        /// <para>The token for the next request, which is used for paging. Specify this value in the NextToken request parameter for the next paged query. If this field is empty in the response, no more data is available.</para>
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
