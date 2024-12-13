// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUserProvisioningsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to initiate the next request. If this is your first time to call this operation, you do not need to specify the <c>NextToken</c> parameter.</para>
        /// <para>When you call this operation for the first time, if the total number of entries to return is larger than the value of <c>MaxResults</c>, the entries are truncated. The system returns entries based on the value of <c>MaxResults</c>, and does not return the excess entries. In this case, the value of the response parameter <c>IsTruncated</c> is <c>true</c>, and <c>NextToken</c> is returned. In the next call, you can use the value of <c>NextToken</c> and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of <c>IsTruncated</c> becomes <c>false</c>. This way, all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27EbL9j4ZgZjsMZFqbZFgbwQ1VXFU1Khcpx9e2vrW1zwzTBmTGWaM7ixHhRin8SCsxaJdazYVCzeKc2UF2QkyGb83cPhr8ZxrzoaiTd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The identity ID of the RAM user provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <c>Group</c> is returned for the <c>PrincipalType</c> parameter, the value of this parameter is the ID of a CloudSSO user group (g-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
        /// <item><description>If <c>User</c> is returned for the <c>PrincipalType</c> parameter, the value of this parameter is the ID of a CloudSSO user (u-\<em>\</em>\<em>\</em>\<em>\</em>\<em>\</em>).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>u-88d73u*****</para>
        /// </summary>
        [NameInMap("PrincipalId")]
        [Validation(Required=false)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// <para>The identity type of the RAM user provisioning. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: The identity of the RAM user provisioning is a CloudSSO user.</description></item>
        /// <item><description>Group: The identity of the RAM user provisioning is a CloudSSO user group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("PrincipalType")]
        [Validation(Required=false)]
        public string PrincipalType { get; set; }

        /// <summary>
        /// <para>The ID of the object for which you create the RAM user provisioning. The value is fixed as the ID of the member in the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743382******</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The object for which you create the RAM user provisioning. The value is fixed as <c>RD-Account</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
