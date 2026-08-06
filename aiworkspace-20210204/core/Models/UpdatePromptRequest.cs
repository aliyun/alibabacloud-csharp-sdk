// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class UpdatePromptRequest : TeaModel {
        /// <summary>
        /// <para>The description of the prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an information extraction prompt for autonomous driving highway scenarios, focusing on extracting lane and weather information</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The prompt content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;context&quot;:&quot;You are an experienced driver with ten years of driving experience. Please analyze and make judgments about the following image scenarios.&quot;,
        ///   &quot;inputData&quot;:&quot;{
        ///     \&quot;Reflective strips\&quot;: \&quot;Usually yellow, or yellow-black alternating, attached to permanent protruding obstacles such as wall corners to remind drivers to avoid them.\&quot;,
        ///     \&quot;Ground lock\&quot;: \&quot;Also known as a parking space lock. When raised, it prevents the parking space from being occupied. When a ground lock is present, you must indicate whether it is in the raised or lowered state.\&quot;,
        ///   }&quot;
        /// }</para>
        /// </summary>
        [NameInMap("FrameworkContent")]
        [Validation(Required=false)]
        public string FrameworkContent { get; set; }

        /// <summary>
        /// <para>The framework type of the prompt template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICIO</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can obtain the ID by calling the <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>302914</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
