// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class GetDocStructureResultRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ImageStrategy")]
        [Validation(Required=false)]
        public string ImageStrategy { get; set; }

        [NameInMap("RevealMarkdown")]
        [Validation(Required=false)]
        public bool? RevealMarkdown { get; set; }

    }

}
