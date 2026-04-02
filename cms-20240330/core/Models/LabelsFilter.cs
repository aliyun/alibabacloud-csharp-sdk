// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class LabelsFilter : TeaModel {
        /// <summary>
        /// <para>匹配所有标签（AND）</para>
        /// </summary>
        [NameInMap("allOf")]
        [Validation(Required=false)]
        public List<LabelMatcher> AllOf { get; set; }

        /// <summary>
        /// <para>匹配任意一个标签（OR）</para>
        /// </summary>
        [NameInMap("anyOf")]
        [Validation(Required=false)]
        public List<LabelMatcher> AnyOf { get; set; }

    }

}
