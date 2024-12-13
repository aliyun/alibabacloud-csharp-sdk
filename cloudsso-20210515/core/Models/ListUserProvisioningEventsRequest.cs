// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListUserProvisioningEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00xz91nf****</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to initiate the next request. If this is your first time to call this operation, you do not need to specify the <c>NextToken</c> parameter.</para>
        /// <para>When you call this operation for the first time, if the total number of entries to return is larger than the value of <c>MaxResults</c>, the entries are truncated. The system returns entries based on the value of <c>MaxResults</c>, and does not return the excess entries. In this case, the value of the response parameter <c>IsTruncated</c> is <c>true</c>, and <c>NextToken</c> is returned. In the next call, you can use the value of <c>NextToken</c> and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of <c>IsTruncated</c> becomes <c>false</c>. This way, all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user provisioning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>up-002axzhapcbz6e63****</para>
        /// </summary>
        [NameInMap("UserProvisioningId")]
        [Validation(Required=false)]
        public string UserProvisioningId { get; set; }

    }

}
