// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class FaceshifterTRequest : TeaModel {
        [NameInMap("Age")]
        [Validation(Required=false)]
        public int? Age { get; set; }

        [NameInMap("Gender")]
        [Validation(Required=false)]
        public int? Gender { get; set; }

        [NameInMap("PicUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        [NameInMap("Race")]
        [Validation(Required=false)]
        public int? Race { get; set; }

    }

}
