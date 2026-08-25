// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The directory ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>Format: <c>&lt;Attribute&gt; &lt;Operator&gt; &lt;Value&gt;</c>. This value is case-insensitive. Currently, <c>&lt;Attribute&gt;</c> supports only <c>UserName</c>, and <c>Operator</c> supports only <c>eq</c> (Equals) and <c>sw</c> (Start With).</para>
        /// <para>Example: Filter = &quot;UserName sw test&quot; queries all users whose usernames start with test. Filter = &quot;UserName eq testuser&quot; queries the user whose username is <c>testuser</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserName sw test</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
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
        /// <para>The token for the next page of results. You do not need to specify <c>NextToken</c> for the first API call.</para>
        /// <para>When you call the API for the first time, if the total number of entries exceeds the <c>MaxResults</c> limit, the data is truncated and only <c>MaxResults</c> entries are returned. In this case, the response parameter <c>IsTruncated</c> is <c>true</c> and a <c>NextToken</c> is returned. You can use the <c>NextToken</c> returned from the previous call to continue calling the API while keeping other request parameters unchanged to query the truncated data. You can repeat this process until <c>IsTruncated</c> is <c>false</c>, which indicates that all data has been retrieved.</para>
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
        /// <item><description>Manual: The user is manually created.</description></item>
        /// <item><description>Synchronized: The user is synchronized from an external identity provider.</description></item>
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
        /// <item><description>Enabled: The user is enabled.</description></item>
        /// <item><description>Disabled: The user is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
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
