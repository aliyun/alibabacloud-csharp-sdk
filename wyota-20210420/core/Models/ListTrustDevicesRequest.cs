// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListTrustDevicesRequest : TeaModel {
        [NameInMap("LabelContent")]
        [Validation(Required=false)]
        public string LabelContent { get; set; }

        [NameInMap("LabelId")]
        [Validation(Required=false)]
        public string LabelId { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("UserCustomId")]
        [Validation(Required=false)]
        public string UserCustomId { get; set; }

    }

}
