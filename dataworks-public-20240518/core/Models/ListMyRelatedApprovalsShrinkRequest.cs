// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public string AccessTypesShrink { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <para>The end of the application time range, specified as a millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1779724799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Filters approvals by the specified principal.</para>
        /// </summary>
        [NameInMap("Grantee")]
        [Validation(Required=false)]
        public string GranteeShrink { get; set; }

        /// <summary>
        /// <para>The pagination token that acts as a cursor to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The resource declaration.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string ResourceShrink { get; set; }

        /// <summary>
        /// <para>The resource type, specified as a leaf node name. Multiple values are supported because a single business semantic can be mapped to multiple leaf node names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;table&quot;, &quot;column&quot;]</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceTypeShrink { get; set; }

        /// <summary>
        /// <para>The start of the application time range, specified as a millisecond timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1771948800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Filters the results by approval status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>WaitApproval</c>: Pending approval</para>
        /// </description></item>
        /// <item><description><para><c>Confirmed</c>: Pending authorization</para>
        /// </description></item>
        /// <item><description><para><c>RejectApproval</c>: Approval rejected</para>
        /// </description></item>
        /// <item><description><para><c>AuthorizeSucceed</c>: Authorization succeeded</para>
        /// </description></item>
        /// <item><description><para><c>AuthorizeFailed</c>: Authorization failed</para>
        /// </description></item>
        /// <item><description><para><c>Deleted</c>: Deleted</para>
        /// </description></item>
        /// <item><description><para><c>Canceled</c>: Withdrawn</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WAIT_APPROVAL</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public string StatusesShrink { get; set; }

    }

}
