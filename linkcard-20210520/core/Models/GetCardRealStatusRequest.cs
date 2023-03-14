// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetCardRealStatusRequest : TeaModel {
        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("Msisdn")]
        [Validation(Required=false)]
        public string Msisdn { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public List<string> SerialNo { get; set; }

    }

}
