// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRefDocItem : TeaModel {
        [NameInMap("docInfo")]
        [Validation(Required=false)]
        public ChatRefDocInfo DocInfo { get; set; }

        [NameInMap("docName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        [NameInMap("docUrl")]
        [Validation(Required=false)]
        public string DocUrl { get; set; }

        [NameInMap("originDocName")]
        [Validation(Required=false)]
        public string OriginDocName { get; set; }

        [NameInMap("originDocUrl")]
        [Validation(Required=false)]
        public string OriginDocUrl { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public List<ChatDocumentPageNum> PageNum { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
