// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ListGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListGroupsForUserResponseBodyData> Data { get; set; }
        public class ListGroupsForUserResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The source ID of the group membership.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("groupMemberRelationSourceId")]
            [Validation(Required=false)]
            public string GroupMemberRelationSourceId { get; set; }

            /// <summary>
            /// <para>The source type of the group membership.</para>
            /// 
            /// <b>Example:</b>
            /// <para>build_in</para>
            /// </summary>
            [NameInMap("groupMemberRelationSourceType")]
            [Validation(Required=false)]
            public string GroupMemberRelationSourceType { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. If this parameter is not returned, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
