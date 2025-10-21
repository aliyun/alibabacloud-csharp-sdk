// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class ListModelCategoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("ContentSafeImageSupported")]
        [Validation(Required=false)]
        public int? ContentSafeImageSupported { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("ContentSafeTextSupported")]
        [Validation(Required=false)]
        public int? ContentSafeTextSupported { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo</para>
        /// </summary>
        [NameInMap("ModelCategoryName")]
        [Validation(Required=false)]
        public string ModelCategoryName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ModelSource")]
        [Validation(Required=false)]
        public string ModelSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("PromptAttackTextSupported")]
        [Validation(Required=false)]
        public int? PromptAttackTextSupported { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("SensitiveTopicTextSupported")]
        [Validation(Required=false)]
        public int? SensitiveTopicTextSupported { get; set; }

    }

}
