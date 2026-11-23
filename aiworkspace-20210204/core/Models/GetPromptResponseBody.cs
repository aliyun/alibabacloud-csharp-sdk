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
        /// <item><description>PUBLIC: Accessible to all members in the current workspace.</description></item>
        /// <item><description>PRIVATE: Accessible only to the creator.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The creation time. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-10-16T01:44:10Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is an information extraction prompt for autonomous driving highway scenarios, focusing on extracting lanes, weather, and other details</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The content of the prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;context&quot;:&quot;You are an experienced driver with ten years of driving experience. Please analyze and judge the following image scenario.&quot;,
        ///   &quot;inputData&quot;:&quot;{
        ///     \&quot;Reflective tape\&quot;: \&quot;Usually yellow or yellow-and-black striped, attached to permanent protruding obstacles such as wall corners to remind drivers to avoid them. It is strip-shaped, not a traffic cone, not a parking lock, and not a water barrier!\&quot;,
        ///     \&quot;Parking lock\&quot;: \&quot;Also known as a parking space lock, it prevents the parking space from being occupied when raised. If a parking lock is present, make sure to output whether it is in the raised or lowered state. It is in the raised state if the lifting frame is up; otherwise, it is in the lowered state.\&quot;
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
        /// <para>The update time. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-08-27T02:01:10Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The name of the prompt.</para>
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
