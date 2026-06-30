// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class SubmitTranslationTaskShrinkRequest : TeaModel {
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        [NameInMap("BaseTaskId")]
        [Validation(Required=false)]
        public string BaseTaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string ConfigShrink { get; set; }

        [NameInMap("CustomTerms")]
        [Validation(Required=false)]
        public string CustomTermsShrink { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
