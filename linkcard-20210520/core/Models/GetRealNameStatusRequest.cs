// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetRealNameStatusRequest : TeaModel {
        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("ListMsisdns")]
        [Validation(Required=false)]
        public List<string> ListMsisdns { get; set; }

    }

}
