// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The CloudSSO directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>The format is <c>&lt;Attribute&gt; &lt;Operator&gt; &lt;Value&gt;</c>. The filter is not case-sensitive. The <c>&lt;Attribute&gt;</c> only supports <c>UserName</c>. The <c>&lt;Operator&gt;</c> only supports <c>eq</c> (equal to) and <c>sw</c> (starts with).</para>
        /// <para>Examples:</para>
        /// <para>If you configure this parameter to <c>UserName sw test</c>, the system queries all users whose usernames start with <c>test</c>. If you configure this parameter to <c>UserName eq testuser</c>, the system queries the user whose username is <c>testuser</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserName sw test</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.</para>
        /// <para>If the total number of entries exceeds the value of <c>MaxResults</c>, the entries are truncated. The system returns the value of <c>MaxResults</c> and a <c>NextToken</c>. The <c>IsTruncated</c> parameter is set to <c>true</c>. You can use the returned <c>NextToken</c> in the next call to query the remaining entries. Keep the other request parameters unchanged. Repeat this process until the <c>IsTruncated</c> parameter is <c>false</c>. This indicates that all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The user type. This parameter is used as a filter condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Manual: The user was manually created.</para>
        /// </description></item>
        /// <item><description><para>Synchronized: The user was synchronized from an external IdP.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manual</para>
        /// </summary>
        [NameInMap("ProvisionType")]
        [Validation(Required=false)]
        public string ProvisionType { get; set; }

        /// <summary>
        /// <para>The user status. This parameter is used as a filter condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Enabled</para>
        /// </description></item>
        /// <item><description><para>Disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags attached to the user.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListUsersRequestTags> Tags { get; set; }
        public class ListUsersRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
