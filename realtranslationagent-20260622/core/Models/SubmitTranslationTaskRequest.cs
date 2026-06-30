// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RealTranslationAgent20260622.Models
{
    public class SubmitTranslationTaskRequest : TeaModel {
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
        public SubmitTranslationTaskRequestConfig Config { get; set; }
        public class SubmitTranslationTaskRequestConfig : TeaModel {
            [NameInMap("Font")]
            [Validation(Required=false)]
            public string Font { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SourceLanguage")]
            [Validation(Required=false)]
            public string SourceLanguage { get; set; }

            [NameInMap("Style")]
            [Validation(Required=false)]
            public string Style { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TargetLanguage")]
            [Validation(Required=false)]
            public string TargetLanguage { get; set; }

        }

        [NameInMap("CustomTerms")]
        [Validation(Required=false)]
        public List<SubmitTranslationTaskRequestCustomTerms> CustomTerms { get; set; }
        public class SubmitTranslationTaskRequestCustomTerms : TeaModel {
            [NameInMap("SourceTerm")]
            [Validation(Required=false)]
            public string SourceTerm { get; set; }

            [NameInMap("TargetTerm")]
            [Validation(Required=false)]
            public string TargetTerm { get; set; }

        }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
