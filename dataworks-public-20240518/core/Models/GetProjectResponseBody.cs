// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the workspace.</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public GetProjectResponseBodyProject Project { get; set; }
        public class GetProjectResponseBodyProject : TeaModel {
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
            public List<GetProjectResponseBodyProjectAliyunResourceTags> AliyunResourceTags { get; set; }
            public class GetProjectResponseBodyProjectAliyunResourceTags : TeaModel {
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
            /// <item><description>true: The development environment is enabled. In this case, the development environment is isolated from the production environment in the workspace.</description></item>
            /// <item><description>false: The development environment is disabled. In this case, only the production environment is used in the workspace.</description></item>
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
            /// <item><description>false</description></item>
            /// <item><description>true</description></item>
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
            /// <para>28477242</para>
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
            /// <para>207947397706614299</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>Indicates whether scheduling of PAI tasks is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Scheduling of PAI tasks is enabled. In this case, you can create a PAI node in a DataWorks workspace and configure scheduling properties for the node to implement periodic scheduling of PAI tasks.</description></item>
            /// <item><description>false: Scheduling of PAI tasks is disabled.</description></item>
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
            /// <item><description>Available</description></item>
            /// <item><description>Initializing</description></item>
            /// <item><description>InitFailed</description></item>
            /// <item><description>Forbidden</description></item>
            /// <item><description>Deleting</description></item>
            /// <item><description>DeleteFailed</description></item>
            /// <item><description>Frozen</description></item>
            /// <item><description>Updating</description></item>
            /// <item><description>UpdateFailed</description></item>
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
        /// <para>The request ID. You can locate logs and troubleshoot issues based on the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
