// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPendingApprovalsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by requested permissions.</para>
        /// <para>Note: Different resource levels support different permission types. All are uniformly constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
        /// </summary>
        [NameInMap("AccessTypes")]
        [Validation(Required=false)]
        public List<string> AccessTypes { get; set; }

        /// <summary>
        /// <para>Filters by resource type.</para>
        /// <para>Note: The supported resource types for requests are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <para>End time of the application period (millisecond timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1779724799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Filters by authorization principal.</para>
        /// <para>Note: The supported authorization principal types are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authPrincipal.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
        /// </summary>
        [NameInMap("Grantee")]
        [Validation(Required=false)]
        public ListPendingApprovalsRequestGrantee Grantee { get; set; }
        public class ListPendingApprovalsRequestGrantee : TeaModel {
            /// <summary>
            /// <para>Authorization principal ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ROLE_3133343434</para>
            /// </summary>
            [NameInMap("PrincipalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            /// <summary>
            /// <para>Authorization principal type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RamRole</para>
            /// </summary>
            [NameInMap("PrincipalType")]
            [Validation(Required=false)]
            public string PrincipalType { get; set; }

        }

        /// <summary>
        /// <para>Cursor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJpZCI6MTIzfQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Page size (default: 10, maximum: 200).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by resource with exact or fuzzy matching. Resource descriptions are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ListPendingApprovalsRequestResource Resource { get; set; }
        public class ListPendingApprovalsRequestResource : TeaModel {
            /// <summary>
            /// <para>Resource type.</para>
            /// <para>Note: The supported resource types for requests are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
            /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <para>Resource parsing version is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.version.</para>
            /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.0</para>
            /// </summary>
            [NameInMap("DefVersion")]
            [Validation(Required=false)]
            public string DefVersion { get; set; }

            /// <summary>
            /// <para>Resource metadata.</para>
            /// <para>Note: Metadata is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources. A valid resource declaration must include the full path metadata declaration from level 0 to the validLeaf level.</para>
            /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

        }

        /// <summary>
        /// <para>Filters by minimum permission resource type.</para>
        /// <para>Note: The minimum permission resource type is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources[*].isValidLeaf being true.</para>
        /// <para>Reference: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema International Documentation</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;table&quot;, &quot;column&quot;]</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public List<string> ResourceType { get; set; }

        /// <summary>
        /// <para>Start time of the application period (millisecond timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1771948800000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
