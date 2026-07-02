// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GuidingQuestion : TeaModel {
        /// <summary>
        /// <para>The answer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;将场景文本检测和布局分析统一起来是重要的，因为这两个任务虽然在文献中通常被独立研究，但实际上是紧密相关的。&quot;</para>
        /// </summary>
        [NameInMap("Answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <para>The question.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;为什么将场景文本检测和布局分析统一起来是重要的？&quot;</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

    }

}
