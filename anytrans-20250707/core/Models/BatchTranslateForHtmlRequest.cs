// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class BatchTranslateForHtmlRequest : TeaModel {
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public BatchTranslateForHtmlRequestExt Ext { get; set; }
        public class BatchTranslateForHtmlRequestExt : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public BatchTranslateForHtmlRequestExtConfig Config { get; set; }
            public class BatchTranslateForHtmlRequestExtConfig : TeaModel {
                [NameInMap("skipCsiCheck")]
                [Validation(Required=false)]
                public bool? SkipCsiCheck { get; set; }

            }

            [NameInMap("domainHint")]
            [Validation(Required=false)]
            public string DomainHint { get; set; }

            [NameInMap("examples")]
            [Validation(Required=false)]
            public List<BatchTranslateForHtmlRequestExtExamples> Examples { get; set; }
            public class BatchTranslateForHtmlRequestExtExamples : TeaModel {
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            [NameInMap("langDetect")]
            [Validation(Required=false)]
            public bool? LangDetect { get; set; }

            [NameInMap("sensitives")]
            [Validation(Required=false)]
            public List<string> Sensitives { get; set; }

            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<BatchTranslateForHtmlRequestExtTerminologies> Terminologies { get; set; }
            public class BatchTranslateForHtmlRequestExtTerminologies : TeaModel {
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            [NameInMap("textTransform")]
            [Validation(Required=false)]
            public BatchTranslateForHtmlRequestExtTextTransform TextTransform { get; set; }
            public class BatchTranslateForHtmlRequestExtTextTransform : TeaModel {
                [NameInMap("toLower")]
                [Validation(Required=false)]
                public bool? ToLower { get; set; }

                [NameInMap("toTitle")]
                [Validation(Required=false)]
                public bool? ToTitle { get; set; }

                [NameInMap("toUpper")]
                [Validation(Required=false)]
                public bool? ToUpper { get; set; }

            }

        }

        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public Dictionary<string, object> Text { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
