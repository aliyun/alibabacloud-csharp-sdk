// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Prompt : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-11-15T07:06:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>这是一个自动驾驶场景的提示词。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;context&quot;: &quot;你是一个拥有十年驾龄的老司机，请你针对以下图片场景做出你的分析判断。&quot;,
        ///   &quot;inputData&quot;: &quot;{\n  \&quot;反光贴条\&quot;: \&quot; 通常为黄色，或者黄黑间隔，贴在墙角等永久的突出障碍物上，用于提示车主避让。为条带状，不是锥筒，不是地锁，不是水马！\&quot;,\n  \&quot;地锁\&quot;: \&quot;也叫车位锁，升起时可以阻止车位被占用。存在地锁时，务必输出地锁为升起还是降下状态。有升起架子时为升起状态,否则为降下状态。\&quot;\n}&quot;
        /// }</para>
        /// </summary>
        [NameInMap("FrameworkContent")]
        [Validation(Required=false)]
        public string FrameworkContent { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ICIO</para>
        /// </summary>
        [NameInMap("FrameworkType")]
        [Validation(Required=false)]
        public string FrameworkType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-12-26T02:17:18Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pmt-axbxtc****xxx</para>
        /// </summary>
        [NameInMap("PromptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>自动驾驶提示词</para>
        /// </summary>
        [NameInMap("PromptName")]
        [Validation(Required=false)]
        public string PromptName { get; set; }

    }

}
