// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreatePromptRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE (default): Visible only to you and administrators in this workspace.</description></item>
        /// <item><description>PUBLIC: Visible to all users in this workspace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The description of the prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an information extraction prompt for autonomous driving highway scenarios, focusing on extracting information such as lanes and weather</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The content of the prompt framework.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;context&quot;:&quot;You are an experienced driver with ten years of driving experience. Please analyze and evaluate the following image scenario.&quot;,
        ///   &quot;inputData&quot;:&quot;{
        ///     \&quot;Reflective tape\&quot;: \&quot;Usually yellow or alternating yellow and black, attached to permanent protruding obstacles such as wall corners to remind drivers to avoid them.\&quot;,
        ///     \&quot;Parking lock\&quot;: \&quot;Also known as a parking space lock, it prevents the parking space from being occupied when raised. If a parking lock is present, be sure to output whether it is in the raised or lowered state.\&quot;,
        ///   }&quot;
        /// }</para>
        /// </summary>
        [NameInMap("FrameworkContent")]
        [Validation(Required=false)]
        public string FrameworkContent { get; set; }

        /// <summary>
        /// <para>The prompt optimization template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICIO</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <para>The name of the prompt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Autonomous driving highway information extraction</para>
        /// </summary>
        [NameInMap("PromptName")]
        [Validation(Required=false)]
        public string PromptName { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call the <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>796**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
