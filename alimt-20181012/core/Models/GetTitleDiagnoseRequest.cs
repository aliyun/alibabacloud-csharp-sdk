// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleDiagnoseRequest : TeaModel {
        [NameInMap("Title")]
        [Validation(Required=true)]
        public string Title { get; set; }

        [NameInMap("Language")]
        [Validation(Required=true)]
        public string Language { get; set; }

        [NameInMap("Platform")]
        [Validation(Required=true)]
        public string Platform { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=true)]
        public string CategoryId { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

    }

}
