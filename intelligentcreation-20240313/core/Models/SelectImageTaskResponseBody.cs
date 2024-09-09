// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SelectImageTaskResponseBody : TeaModel {
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("failed")]
        [Validation(Required=false)]
        public string Failed { get; set; }

        [NameInMap("generationSource")]
        [Validation(Required=false)]
        public string GenerationSource { get; set; }

        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("imageInfos")]
        [Validation(Required=false)]
        public List<SelectImageTaskResponseBodyImageInfos> ImageInfos { get; set; }
        public class SelectImageTaskResponseBodyImageInfos : TeaModel {
            [NameInMap("customImageUrl")]
            [Validation(Required=false)]
            public string CustomImageUrl { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("imageH")]
            [Validation(Required=false)]
            public string ImageH { get; set; }

            [NameInMap("imageW")]
            [Validation(Required=false)]
            public string ImageW { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("subtaskProcessing")]
        [Validation(Required=false)]
        public string SubtaskProcessing { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
