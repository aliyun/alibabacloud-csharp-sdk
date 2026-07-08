// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class BatchTranslateForHtmlShrinkRequest : TeaModel {
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string ExtShrink { get; set; }

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
        public string TextShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
