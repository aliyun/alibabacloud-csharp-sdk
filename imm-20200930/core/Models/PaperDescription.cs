// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class PaperDescription : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public List<Summary> Description { get; set; }

        [NameInMap("TitleID")]
        [Validation(Required=false)]
        public List<string> TitleID { get; set; }

    }

}
