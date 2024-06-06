// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class SubmitDocumentAnalyzeJobAdvanceRequest : TeaModel {
        [NameInMap("fileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("folderId")]
        [Validation(Required=false)]
        public string FolderId { get; set; }

        [NameInMap("ossUrl")]
        [Validation(Required=false)]
        public Stream OssUrlObject { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
