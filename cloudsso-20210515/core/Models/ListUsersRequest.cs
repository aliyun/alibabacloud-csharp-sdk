// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The filter condition.</para>
        /// <para>You must specify the value in the <c>&lt;Attribute&gt; &lt;Operator&gt; &lt;Value&gt;</c> format. The value is not case-sensitive. You can set <c>&lt;Attribute&gt;</c> only to <c>UserName</c> and <c>Operator</c> only to <c>eq</c> or <c>sw</c>. The value eq indicates Equals, and the value sw indicates Start With.</para>
        /// <para>For example, if you set the Filter parameter to UserName sw test, the operation queries the users whose names start with test. If you set the Filter parameter to UserName eq testuser, the operation queries the user whose name is <c>testuser</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserName sw test</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of the <c>NextToken</c> parameter.</para>
        /// <para>When you call this operation for the first time, if the total number of entries to return is larger than the value of the <c>MaxResults</c> parameter, the entries are truncated. The system returns entries based on the value of the <c>MaxResults</c> parameter, and does not return the excess entries. In this case, the value of the response parameter <c>IsTruncated</c> is <c>true</c>, and the <c>NextToken</c> parameter is returned. In the next call, you can use the value of the <c>NextToken</c> parameter and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of the <c>IsTruncated</c> parameter becomes <c>false</c>. This way, all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the user. The parameter can be used to filter users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manual: The user is manually created.</description></item>
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
        /// <para>The status of the user. The parameter can be used to filter users. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: The logon of the user is enabled.</description></item>
        /// <item><description>Disabled: The logon of the user is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListUsersRequestTags> Tags { get; set; }
        public class ListUsersRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
