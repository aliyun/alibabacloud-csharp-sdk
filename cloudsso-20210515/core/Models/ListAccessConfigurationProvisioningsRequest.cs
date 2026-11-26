// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationProvisioningsRequest : TeaModel {
        /// <summary>
        /// <para>The access configuration ID used as a filter condition for the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-00ccule7tadaijxc****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

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
        /// <para>The maximum number of entries to return on each page.</para>
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
        /// <para>The token used to return the next page of query results. You do not need to specify NextToken when you call this operation for the first time.</para>
        /// <para>When you call this operation for the first time, if the total number of returned entries exceeds the value of MaxResults, the returned results are truncated. Only the number of entries specified by MaxResults is returned, the IsTruncated parameter is set to true, and a NextToken is returned. You can use the returned NextToken to call this operation again to query the truncated entries while keeping other request parameters unchanged. You can repeat this process until IsTruncated is set to false, which indicates that all entries are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the provisioning target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("OriginTargetId")]
        [Validation(Required=false)]
        public string OriginTargetId { get; set; }

        /// <summary>
        /// <para>The provisioning status used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Provisioned: The provisioning succeeded.</description></item>
        /// <item><description>ReprovisionRequired: Reprovisioning is required.</description></item>
        /// <item><description>DeprovisionFailed: The provisioning failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Provisioned</para>
        /// </summary>
        [NameInMap("ProvisioningStatus")]
        [Validation(Required=false)]
        public string ProvisioningStatus { get; set; }

        /// <summary>
        /// <para>The target ID used as a filter condition for the query.</para>
        /// <remarks>
        /// <para>You must specify both TargetId and TargetType for them to take effect as filter conditions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>114240524784****</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

        /// <summary>
        /// <para>The target type used as a filter condition for the query.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RD-Account: The target is an account in a resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify both TargetId and TargetType for them to take effect as filter conditions.</para>
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
