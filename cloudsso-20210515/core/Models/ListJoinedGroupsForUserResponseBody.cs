// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListJoinedGroupsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the queried entries are truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The queried entries are truncated.</description></item>
        /// <item><description>false: The queried entries are not truncated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The groups to which the user is added.</para>
        /// </summary>
        [NameInMap("JoinedGroups")]
        [Validation(Required=false)]
        public List<ListJoinedGroupsForUserResponseBodyJoinedGroups> JoinedGroups { get; set; }
        public class ListJoinedGroupsForUserResponseBodyJoinedGroups : TeaModel {
            /// <summary>
            /// <para>The description of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a group.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g-00jqzghi2n3o5hkh****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The name of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestGroup</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The time when the user was added to the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01T06:58:18Z</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }

            /// <summary>
            /// <para>The type of the group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Manual: The group is manually created.</description></item>
            /// <item><description>Synchronized: The user is synchronized from an external identity provider (IdP).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("ProvisionType")]
            [Validation(Required=false)]
            public string ProvisionType { get; set; }

            /// <summary>
            /// <para>The ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>u-00q8wbq42wiltcrk****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is returned for the next page.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of <c>IsTruncated</c> is <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9BBB45F-7877-5DE9-96A5-20E6CFA48929</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
