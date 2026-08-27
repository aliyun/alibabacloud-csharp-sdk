// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypeVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resource type version information.</para>
        /// </summary>
        [NameInMap("ResourceTypeVersions")]
        [Validation(Required=false)]
        public List<ListResourceTypeVersionsResponseBodyResourceTypeVersions> ResourceTypeVersions { get; set; }
        public class ListResourceTypeVersionsResponseBodyResourceTypeVersions : TeaModel {
            /// <summary>
            /// <para>The time when the version was created. The time is displayed in UTC+0 based on the ISO 8601 standard but without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-24T08:25:21</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The version description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>It is a demo.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The entity type. Valid values: Module, which indicates a module.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Module</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>Indicates whether the version is the default version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The version is the default version.</description></item>
            /// <item><description>false: The version is not the default version.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefaultVersion")]
            [Validation(Required=false)]
            public bool? IsDefaultVersion { get; set; }

            /// <summary>
            /// <para>The resource type provider. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ROS: Resource Orchestration Service.</description></item>
            /// <item><description>Self: The user.</description></item>
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
            /// <para>The time when the version was last updated. The time is displayed in UTC+0 based on the ISO 8601 standard but without the Z suffix. Format: YYYY-MM-DDThh:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-24T08:25:21</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public string VersionId { get; set; }

        }

    }

}
