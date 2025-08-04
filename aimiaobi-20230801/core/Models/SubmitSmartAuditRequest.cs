// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitSmartAuditRequest : TeaModel {
        [NameInMap("ImageUrlList")]
        [Validation(Required=false)]
        public List<SubmitSmartAuditRequestImageUrlList> ImageUrlList { get; set; }
        public class SubmitSmartAuditRequestImageUrlList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("SubCodes")]
        [Validation(Required=false)]
        public List<string> SubCodes { get; set; }

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
        public List<SubmitSmartAuditRequestImageUrls> ImageUrls { get; set; }
        public class SubmitSmartAuditRequestImageUrls : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
