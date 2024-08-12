// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class DetachLabelsRequest : TeaModel {
        [NameInMap("LabelIds")]
        [Validation(Required=false)]
        public string LabelIds { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("SerialNoList")]
        [Validation(Required=false)]
        public string SerialNoList { get; set; }

    }

}
