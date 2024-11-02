// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAclEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The ACL entries.</para>
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<ListAclEntriesResponseBodyAclEntries> AclEntries { get; set; }
        public class ListAclEntriesResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// <para>The description of the ACL entry. The description must be 1 to 256 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-entry</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The CIDR block for the ACL entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.1.1/24</para>
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            /// <summary>
            /// <para>The status of the ACL entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Adding</b>: The ACL entry is being added.</description></item>
            /// <item><description><b>Available</b>: The ACL entry is added and available.</description></item>
            /// <item><description><b>Removing</b>: The ACL entry is being removed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
