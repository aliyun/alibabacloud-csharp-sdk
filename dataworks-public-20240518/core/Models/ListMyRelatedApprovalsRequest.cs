// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>The permissions.</para>
        /// </summary>
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public List<string> AccessTypes { get; set; }

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
        public ListMyRelatedApprovalsRequestGrantee Grantee { get; set; }
        public class ListMyRelatedApprovalsRequestGrantee : TeaModel {
            /// <summary>
            /// <para>The ID of the principal. The format varies based on the value of <c>PrincipalType</c>.</para>
            /// <list type="bullet">
            /// <item><description><para>If <c>PrincipalType</c> is <c>RamUser</c>, this parameter is the Dataworks user ID.</para>
            /// </description></item>
            /// <item><description><para>If <c>PrincipalType</c> is <c>RamRole</c>, this parameter is a Dataworks user ID that starts with <c>ROLE_</c>.</para>
            /// </description></item>
            /// <item><description><para>If <c>PrincipalType</c> is <c>DataworksTenantMember</c>, this parameter is the Dataworks user ID.</para>
            /// </description></item>
            /// <item><description><para>If <c>PrincipalType</c> is <c>DataworksTenantRole</c>, this parameter is the Dataworks tenant <c>roleCode</c>.</para>
            /// </description></item>
            /// <item><description><para>If <c>PrincipalType</c> is <c>DataworksProjectRole</c>, this parameter is the Dataworks workspace <c>roleCode</c>.</para>
            /// </description></item>
            /// <item><description><para>If <c>PrincipalType</c> is <c>DataworksProjectMember</c>, this parameter is the Dataworks user ID.</para>
            /// </description></item>
            /// <item><description><para>If <c>PrincipalType</c> is <c>DlfRole</c>, this parameter is the DlfNext role name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROLE_3133343434</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The type of the principal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>RamRole</c></para>
            /// </description></item>
            /// <item><description><para><c>RamUser</c></para>
            /// </description></item>
            /// <item><description><para><c>DataworksTenantMember</c></para>
            /// </description></item>
            /// <item><description><para><c>DataworksTenantRole</c></para>
            /// </description></item>
            /// <item><description><para><c>DataworksProjectMember</c></para>
            /// </description></item>
            /// <item><description><para><c>DataworksProjectRole</c></para>
            /// </description></item>
            /// <item><description><para><c>DlfRole</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RamRole</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

        }

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
        public ListMyRelatedApprovalsRequestResource Resource { get; set; }
        public class ListMyRelatedApprovalsRequestResource : TeaModel {
            /// <summary>
            /// <para>The <c>name</c> of the <c>ResourceSchema</c> used to parse the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <para>The <c>version</c> of the <c>ResourceSchema</c> used to parse the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.0</para>
            /// </summary>
            [NameInMap("DefVersion")]
            [Validation(Required=false)]
            public string DefVersion { get; set; }

            /// <summary>
            /// <para>The resource metadata. The <c>ResourceSchema</c> defines its content.</para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

        }

        /// <summary>
        /// <para>The resource type, specified as a leaf node name. Multiple values are supported because a single business semantic can be mapped to multiple leaf node names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;table&quot;, &quot;column&quot;]</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public List<string> ResourceType { get; set; }

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
        public List<string> Statuses { get; set; }

    }

}
