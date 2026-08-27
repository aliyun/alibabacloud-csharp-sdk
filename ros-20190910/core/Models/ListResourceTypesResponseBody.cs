// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA00860C-ECAF-5253-A1F9-8198695A7157</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource type summary list.</para>
        /// </summary>
        [NameInMap("ResourceTypeSummaries")]
        [Validation(Required=false)]
        public List<ListResourceTypesResponseBodyResourceTypeSummaries> ResourceTypeSummaries { get; set; }
        public class ListResourceTypesResponseBodyResourceTypeSummaries : TeaModel {
            /// <summary>
            /// <para>The creation time. The time is displayed in UTC+0 based on the ISO 8601 standard but without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-24T08:25:21</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The default version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("DefaultVersionId")]
            [Validation(Required=false)]
            public string DefaultVersionId { get; set; }

            /// <summary>
            /// <para>The resource type description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>It is a demo.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The entity type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>Resource: regular resource type.</description></item>
            /// <item><description>DataSource: data source resource type. </description></item>
            /// <item><description>Module: module.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Module</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The latest version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v10</para>
            /// </summary>
            [NameInMap("LatestVersionId")]
            [Validation(Required=false)]
            public string LatestVersionId { get; set; }

            /// <summary>
            /// <para>The resource type provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ROS: Resource Orchestration Service.</description></item>
            /// <item><description>Self: the user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROS</para>
            /// </summary>
            [NameInMap("Provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MODULE::MyOrganization::MyService::MyUsecase</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The total number of versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalVersionCount")]
            [Validation(Required=false)]
            public int? TotalVersionCount { get; set; }

            /// <summary>
            /// <para>The update time. The time is displayed in UTC+0 based on the ISO 8601 standard but without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-24T08:25:21</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The resource type array.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

    }

}
