// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetCardDetailRequest : TeaModel {
        [NameInMap("DestroyCard")]
        [Validation(Required=false)]
        public bool? DestroyCard { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ShowPsim")]
        [Validation(Required=false)]
        public bool? ShowPsim { get; set; }

    }

}
