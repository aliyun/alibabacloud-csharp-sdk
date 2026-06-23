// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListProjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListProjectsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The workspaces.</para>
            /// </summary>
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyPagingInfoProjects> Projects { get; set; }
            public class ListProjectsResponseBodyPagingInfoProjects : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud resource group to which the workspace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmzbn7pti3zfa</para>
                /// </summary>
                [NameInMap("AliyunResourceGroupId")]
                [Validation(Required=false)]
                public string AliyunResourceGroupId { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("AliyunResourceTags")]
                [Validation(Required=false)]
                public List<ListProjectsResponseBodyPagingInfoProjectsAliyunResourceTags> AliyunResourceTags { get; set; }
                public class ListProjectsResponseBodyPagingInfoProjectsAliyunResourceTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>batch</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>blue</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The description of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Financial analysis group project data development</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the development environment is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: The development environment is enabled. In this case, the development environment is isolated from the production environment in the workspace.</para>
                /// </description></item>
                /// <item><description><para>false: The development environment is disabled. In this case, only the production environment is used in the workspace.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DevEnvironmentEnabled")]
                [Validation(Required=false)]
                public bool? DevEnvironmentEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the Develop role is disabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>false (default)</para>
                /// </description></item>
                /// <item><description><para>true</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DevRoleDisabled")]
                [Validation(Required=false)]
                public bool? DevRoleDisabled { get; set; }

                /// <summary>
                /// <para>The display name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sora financial analysis</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the workspace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sora_finance</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the workspace belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123532153125</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>Indicates whether scheduling of PAI tasks is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>true: Scheduling of PAI tasks is enabled. In this case, you can create a PAI node in a DataWorks workspace and configure scheduling properties for the node to implement periodic scheduling of PAI tasks.</para>
                /// </description></item>
                /// <item><description><para>false: Scheduling of PAI tasks is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PaiTaskEnabled")]
                [Validation(Required=false)]
                public bool? PaiTaskEnabled { get; set; }

                /// <summary>
                /// <para>The status of the workspace. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Available</para>
                /// </description></item>
                /// <item><description><para>Initializing</para>
                /// </description></item>
                /// <item><description><para>InitFailed</para>
                /// </description></item>
                /// <item><description><para>Forbidden</para>
                /// </description></item>
                /// <item><description><para>Deleting</para>
                /// </description></item>
                /// <item><description><para>DeleteFailed</para>
                /// </description></item>
                /// <item><description><para>Frozen</para>
                /// </description></item>
                /// <item><description><para>Updating</para>
                /// </description></item>
                /// <item><description><para>UpdateFailed</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D24AD9A-652F-59E2-AC1F-05029300F8A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
