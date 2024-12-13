// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationProvisioningsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access configuration. The ID can be used to filter access permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00ccule7tadaijxc****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// <para>Valid values: 1 to 20.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. If this is your first time to call this operation, you do not need to specify the <c>NextToken</c> parameter.</para>
        /// <para>When you call this operation for the first time, if the total number of entries to return exceeds the value of <c>MaxResults</c>, the entries are truncated. Only the entries that match the value of <c>MaxResults</c> are returned, and the excess entries are not returned. In this case, the value of the response parameter <c>IsTruncated</c> is <c>true</c>, and <c>NextToken</c> is returned. In the next call, you can use the value of <c>NextToken</c> and maintain the settings of the other request parameters to query the excess entries. You can repeat the call until the value of <c>IsTruncated</c> becomes <c>false</c>. This way, all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status of the access configuration. The value can be used to filter accounts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Provisioned: The access configuration is provisioned.</description></item>
        /// <item><description>ReprovisionRequired: The access configuration needs to be re-provisioned.</description></item>
        /// <item><description>DeprovisionFailed: The access configuration failed to be provisioned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Provisioned</para>
        /// </summary>
        [NameInMap("ProvisioningStatus")]
        [Validation(Required=false)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// <para>The ID of the task object. The ID can be used to filter access permissions.</para>
        /// <remarks>
        /// <para> You can use the type to filter access permissions only if you specify both <c>TargetId</c> and <c>TargetType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The type of the task object. The type can be used to filter access permissions.</para>
        /// <para>Set the value to RD-Account, which specifies the accounts in the resource directory.</para>
        /// <remarks>
        /// <para> You can use the type to filter access permissions only if you specify both <c>TargetId</c> and <c>TargetType</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RD-Account</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
