// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyApplicationsRequest : TeaModel {
        /// <summary>
        /// <para>Filters by resource type.</para>
        /// <para>Note: The resource types supported by the system for applications are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
        /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for International site</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("DefSchema")]
        [Validation(Required=false)]
        public string DefSchema { get; set; }

        /// <summary>
        /// <para>The end time of the application period (millisecond timestamp).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1779724799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>Filters by resource with exact or wildcard matching. The resource description is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.</para>
        /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for International site</a></para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public ListMyApplicationsRequestResource Resource { get; set; }
        public class ListMyApplicationsRequestResource : TeaModel {
            /// <summary>
            /// <para>The resource type.</para>
            /// <para>Note: The resource types supported by the system for applications are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
            /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for International site</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <para>The resource parsing version, which is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.version.</para>
            /// <para><a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for International site</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.0.0</para>
            /// </summary>
            [NameInMap("DefVersion")]
            [Validation(Required=false)]
            public string DefVersion { get; set; }

            /// <summary>
            /// <para>The resource metadata.</para>
            /// <para>Note: The metadata is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources. A valid resource declaration must include the full-path metadata declarations from level 0 to the validLeaf level.</para>
            /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for International site</a></para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetaData { get; set; }

        }

        /// <summary>
        /// <para>Filters by minimum permission resource type.</para>
        /// <para>Note: The minimum permission resource type is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources[*].isValidLeaf being true.</para>
        /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for International site</a></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public List<string> ResourceType { get; set; }

        /// <summary>
        /// <para>The start time of the application period (millisecond timestamp).</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description>WaitApproval: pending approval.</description></item>
        /// <item><description>Confirmed: pending authorization.</description></item>
        /// <item><description>RejectApproval: approval rejected.</description></item>
        /// <item><description>AuthorizeSucceed: authorization succeeded.</description></item>
        /// <item><description>AuthorizeFailed: authorization failed.</description></item>
        /// <item><description>Deleted: deleted.</description></item>
        /// <item><description>Canceled: withdrawn.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Deleted</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
