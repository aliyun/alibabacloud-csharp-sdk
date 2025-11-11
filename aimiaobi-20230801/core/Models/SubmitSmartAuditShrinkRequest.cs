// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitSmartAuditShrinkRequest : TeaModel {
        [NameInMap("ImageUrlList")]
        [Validation(Required=false)]
        public string ImageUrlListShrink { get; set; }

        [NameInMap("NoteId")]
        [Validation(Required=false)]
        public string NoteId { get; set; }

        [NameInMap("SubCodes")]
        [Validation(Required=false)]
        public string SubCodesShrink { get; set; }

        [NameInMap("TermsName")]
        [Validation(Required=false)]
        public string TermsName { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        [NameInMap("imageUrls")]
        [Validation(Required=false)]
        public string ImageUrlsShrink { get; set; }

    }

}
