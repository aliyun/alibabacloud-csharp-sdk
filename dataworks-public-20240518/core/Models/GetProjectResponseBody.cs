// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the workspace.</para>
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
            /// <item><description><para>true: The development environment is enabled for the workspace, which supports isolation between the development and production environments.</para>
            /// </description></item>
            /// <item><description><para>false: Only the production environment is used.</para>
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
            /// <para>Indicates whether the development role is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>false: The development role is enabled.</para>
            /// </description></item>
            /// <item><description><para>true: The development role is disabled.</para>
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
            /// <para>28477242</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The workspace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sora_finance</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The user ID of the workspace owner, which is the Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>207947397706614299</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>Indicates whether PAI task scheduling is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: You can create Machine Learning Platform for AI (PAI) nodes in the DataWorks workspace and run them on a periodic schedule based on the node configurations.</para>
            /// </description></item>
            /// <item><description><para>false: PAI task scheduling is disabled.</para>
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
            /// <para>The workspace status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Available: The workspace is running normally.</description></item>
            /// <item><description>Initializing: The workspace is being initialized.</description></item>
            /// <item><description>InitFailed: The workspace failed to be initialized.</description></item>
            /// <item><description>Forbidden: The workspace is manually disabled.</description></item>
            /// <item><description>Deleting: The workspace is being deleted.</description></item>
            /// <item><description>DeleteFailed: The workspace failed to be deleted.</description></item>
            /// <item><description>Frozen: The workspace is frozen due to overdue payment.</description></item>
            /// <item><description>Updating: The workspace is being updated.</description></item>
            /// <item><description>UpdateFailed: The workspace failed to be updated.</description></item>
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
        /// <para>The request ID, which is used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
