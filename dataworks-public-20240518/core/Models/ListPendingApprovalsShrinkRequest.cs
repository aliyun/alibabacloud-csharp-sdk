// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPendingApprovalsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Filters by requested permissions.</para>
        /// <para>Note: The permission types supported for application vary across resource levels and are uniformly constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
        /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// </summary>
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public string AccessTypesShrink { get; set; }

        /// <summary>
        /// <para>Filters by resource type.</para>
        /// <para>Note: The resource types for which permissions can be requested are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
        /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <para>The end of the time range for request submission, as a timestamp in milliseconds.</para>
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
        /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// </summary>
        [NameInMap("Grantee")]
        [Validation(Required=false)]
        public string GranteeShrink { get; set; }

        /// <summary>
        /// <para>The cursor.</para>
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
        /// <para>Filters by exact or generalized resource. The resource description is constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.</para>
        /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string ResourceShrink { get; set; }

        /// <summary>
        /// <para>Filters by least privilege resource type.</para>
        /// <para>Note: The least privilege resource types are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources[*].isValidLeaf being true.</para>
        /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for the international site</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;table&quot;, &quot;column&quot;]</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceTypeShrink { get; set; }

        /// <summary>
        /// <para>The start of the time range for request submission, as a timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1771948800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
