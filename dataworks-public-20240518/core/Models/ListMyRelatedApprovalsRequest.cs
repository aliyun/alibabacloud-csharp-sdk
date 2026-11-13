// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by the requested permissions.</para>
        /// <para>Note: The types of permissions that can be requested vary based on the resource level and are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// </summary>
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public List<string> AccessTypes { get; set; }

        /// <summary>
        /// <para>Filters by resource type.</para>
        /// <para>Note: The resource types supported for application are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <para>The end time of the application. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1779724799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Filters by authorization principal. </para>
        /// <para>Note: The authorization principal types supported by the system are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authPrincipal.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// </summary>
        [NameInMap("Grantee")]
        [Validation(Required=false)]
        public ListMyRelatedApprovalsRequestGrantee Grantee { get; set; }
        public class ListMyRelatedApprovalsRequestGrantee : TeaModel {
            /// <summary>
            /// <para>The ID of the authorization principal. The meaning of the ID varies based on the principal type:</para>
            /// <list type="bullet">
            /// <item><description><c>RamUser</c>: DataWorks user ID.</description></item>
            /// <item><description><c>RamRole</c>: DataWorks user ID that starts with &quot;ROLE_&quot;.</description></item>
            /// <item><description><c>DataworksTenantMember</c>: DataWorks user ID.</description></item>
            /// <item><description><c>DataworksTenantRole</c>: DataWorks tenant role code.</description></item>
            /// <item><description><c>DataworksProjectRole</c>: DataWorks workspace role code.</description></item>
            /// <item><description><c>DataworksProjectMember</c>: DataWorks user ID.</description></item>
            /// <item><description><c>DlfRole</c>: DLF Next role name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROLE_3133343434</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>The type of the authorization principal. Valid values:</para>
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
        /// <para>The pagination cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Performs exact or generalized filtering based on resources. The resource description is constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ListMyRelatedApprovalsRequestResource Resource { get; set; }
        public class ListMyRelatedApprovalsRequestResource : TeaModel {
            /// <summary>
            /// <para>The resource type.</para>
            /// <para>Note: The resource types supported for application are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
            /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <para>The resource parsing version is constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.version.</para>
            /// <para><a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.0</para>
            /// </summary>
            [NameInMap("DefVersion")]
            [Validation(Required=false)]
            public string DefVersion { get; set; }

            /// <summary>
            /// <para>The resource metadata.</para>
            /// <para>Note: The metadata is constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources. A valid resource declaration must include the full-path metadata declaration from level 0 to the validLeaf level.</para>
            /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;workspace&quot;: &quot;449056&quot;, &quot;project&quot;: &quot;sync_destination&quot;}</para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

        }

        /// <summary>
        /// <para>Filters by least privilege resource type.</para>
        /// <para>Note: The least privilege resource types are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources[*].isValidLeaf being true.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;table&quot;, &quot;column&quot;]</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public List<string> ResourceType { get; set; }

        /// <summary>
        /// <para>The start time of the application. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1771948800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Filters by approval status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WaitApproval: Pending approval.</description></item>
        /// <item><description>Confirmed: Pending authorization.</description></item>
        /// <item><description>RejectApproval: Rejected.</description></item>
        /// <item><description>AuthorizeSucceed: Authorized.</description></item>
        /// <item><description>AuthorizeFailed: Authorization failed.</description></item>
        /// <item><description>Deleted: Deleted.</description></item>
        /// <item><description>Canceled: Withdrawn.</description></item>
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
