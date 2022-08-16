// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TrimPolicy : TeaModel {
        [NameInMap("DisableDeleteEmptyCell")]
        [Validation(Required=false)]
        public bool? DisableDeleteEmptyCell { get; set; }

        [NameInMap("DisableDeleteRepeatedStyle")]
        [Validation(Required=false)]
        public bool? DisableDeleteRepeatedStyle { get; set; }

        [NameInMap("DisableDeleteUnusedPicture")]
        [Validation(Required=false)]
        public bool? DisableDeleteUnusedPicture { get; set; }

        [NameInMap("DisableDeleteUnusedShape")]
        [Validation(Required=false)]
        public bool? DisableDeleteUnusedShape { get; set; }

    }

}
