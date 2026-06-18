// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class UpdatePromptTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The template content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请写一篇小红书种草笔记，增加丰富的emoji元素，结尾作总结，并加上相关标签。主题为：${theme}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>小红书文案助手</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
