// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Filters by the requested permissions.</para>
        /// <para>Note: The types of permissions that can be requested vary based on the resource level and are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// </summary>
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public string AccessTypesShrink { get; set; }

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
        public string GranteeShrink { get; set; }

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
        public string ResourceShrink { get; set; }

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
        public string ResourceTypeShrink { get; set; }

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
        public string StatusesShrink { get; set; }

    }

}
