// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetPromptResponseBody : TeaModel {
        /// <summary>
        /// <para>The access type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: All members in the current workspace can access the prompt.</description></item>
        /// <item><description>PRIVATE: Only the creator can access the prompt.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16T01:44:10Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The prompt description.</para>
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
        ///     \&quot;Reflective strips\&quot;: \&quot;Usually yellow or yellow-black alternating, attached to permanent protruding obstacles such as wall corners to remind drivers to avoid them. They are strip-shaped, not cones, not ground locks, not water barriers!\&quot;,
        ///     \&quot;Ground lock\&quot;: \&quot;Also called a parking space lock, it can prevent a parking space from being occupied when raised. When a ground lock is present, you must indicate whether it is in the raised or lowered state. It is in the raised state when there is a raised frame, otherwise it is in the lowered state.\&quot;,
        ///   }&quot;
        /// }</para>
        /// </summary>
        [NameInMap("FrameworkContent")]
        [Validation(Required=false)]
        public string FrameworkContent { get; set; }

        /// <summary>
        /// <para>The prompt template framework type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICIO</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-27T02:01:10Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The prompt name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Autonomous driving prompt</para>
        /// </summary>
        [NameInMap("PromptName")]
        [Validation(Required=false)]
        public string PromptName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
