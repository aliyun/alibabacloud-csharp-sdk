// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>Filter by requested permissions.</para>
        /// <para>Note: Different resource levels support different application permission types, all constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
        /// </summary>
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public List<string> AccessTypes { get; set; }

        /// <summary>
        /// <para>Filter by resource type.</para>
        /// <para>Note: The resource types supported by the system for applications are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <para>Application time end (millisecond timestamp)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1779724799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Filter by authorization principal.</para>
        /// <para>Note: The authorization principal types supported by the system are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authPrincipal.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
        /// </summary>
        [NameInMap("Grantee")]
        [Validation(Required=false)]
        public ListMyRelatedApprovalsRequestGrantee Grantee { get; set; }
        public class ListMyRelatedApprovalsRequestGrantee : TeaModel {
            /// <summary>
            /// <para>Authorization principal ID:</para>
            /// <list type="bullet">
            /// <item><description><c>RamUser</c>: Dataworks UserId</description></item>
            /// <item><description><c>RamRole</c>: Dataworks UserId prefixed with &quot;ROLE_&quot;</description></item>
            /// <item><description><c>DataworksTenantMember</c>: Dataworks UserId</description></item>
            /// <item><description><c>DataworksTenantRole</c>: Dataworks tenant roleCode</description></item>
            /// <item><description><c>DataworksProjectRole</c>: Dataworks workspace roleCode</description></item>
            /// <item><description><c>DataworksProjectMember</c>: Dataworks UserId</description></item>
            /// <item><description><c>DlfRole</c>: DlfNext role name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROLE_3133343434</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>Authorization principal type:</para>
            /// <list type="bullet">
            /// <item><description><c>RamRole</c></description></item>
            /// <item><description><c>RamUser</c></description></item>
            /// <item><description><c>DataworksTenantMember</c></description></item>
            /// <item><description><c>DataworksTenantRole</c></description></item>
            /// <item><description><c>DataworksProjectMember</c></description></item>
            /// <item><description><c>DataworksProjectRole</c></description></item>
            /// <item><description><c>DlfRole</c></description></item>
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
        /// <para>Pagination cursor</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Page size (default 10, maximum 200)</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filter by resource with exact/generalized matching. The resource description is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ListMyRelatedApprovalsRequestResource Resource { get; set; }
        public class ListMyRelatedApprovalsRequestResource : TeaModel {
            /// <summary>
            /// <para>Resource type.</para>
            /// <para>Note: The resource types supported by the system for applications are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
            /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <para>The resource parsing version is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.version.</para>
            /// <para><a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.0</para>
            /// </summary>
            [NameInMap("DefVersion")]
            [Validation(Required=false)]
            public string DefVersion { get; set; }

            /// <summary>
            /// <para>Resource metadata.</para>
            /// <para>Note: The metadata is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources. A valid resource declaration must include the full-path metadata declaration from level 0 to validLeaf layer.</para>
            /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

        }

        /// <summary>
        /// <para>Filter by minimum permission resource type.</para>
        /// <para>Note: The minimum permission resource type is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources[*].isValidLeaf being true.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Site Documentation</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;table&quot;, &quot;column&quot;]</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public List<string> ResourceType { get; set; }

        /// <summary>
        /// <para>Application time start (millisecond timestamp)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1771948800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Filter by approval status. Enum values:</para>
        /// <list type="bullet">
        /// <item><description>WaitApproval: Pending approval</description></item>
        /// <item><description>Confirmed: Pending authorization</description></item>
        /// <item><description>RejectApproval: Approval rejected</description></item>
        /// <item><description>AuthorizeSucceed: Authorization succeeded</description></item>
        /// <item><description>AuthorizeFailed: Authorization failed</description></item>
        /// <item><description>Deleted: Deleted</description></item>
        /// <item><description>Canceled: Withdrawn</description></item>
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
