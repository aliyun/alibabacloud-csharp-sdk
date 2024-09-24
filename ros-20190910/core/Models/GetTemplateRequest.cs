// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change set.</para>
        /// <remarks>
        /// <para>You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1f6521a4-05af-4975-afe9-bc4b45ad****</para>
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the shared information about the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only the template owner can query the shared information of a template.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("IncludePermission")]
        [Validation(Required=false)]
        public string IncludePermission { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the information about tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only if you specify TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public string IncludeTags { get; set; }

        /// <summary>
        /// <para>The region ID of the stack or stack group that uses the template. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the stack group.</para>
        /// <remarks>
        /// <para>You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// <remarks>
        /// <para>You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// <para>This parameter applies to shared and private templates. If the template is a shared template, the value of TemplateId is the same as the value of TemplateARN. You can use the template ID to query a shared template.</para>
        /// <remarks>
        /// <para>You must specify one of the following parameters: StackId, ChangeSetId, StackGroupName, and TemplateId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The stage of the template. This parameter takes effect only if you specify StackId, ChangeSetId, or StackGroupName.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Processed (default): returns the processed template.</description></item>
        /// <item><description>Original: returns the original template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Processed</para>
        /// </summary>
        [NameInMap("TemplateStage")]
        [Validation(Required=false)]
        public string TemplateStage { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter takes effect only if you specify TemplateId.\
        /// If the template is a shared template, you can specify this parameter only if VersionOption is set to AllVersions. For more information, see <a href="https://help.aliyun.com/document_detail/194768.html">SetTemplatePermission</a>.</para>
        /// <para>Valid values: v1 to v100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
