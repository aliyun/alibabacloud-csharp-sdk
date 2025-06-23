// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ChangeDomainDkimRecordResponseBody : TeaModel {
        [NameInMap("Changed")]
        [Validation(Required=false)]
        public bool? Changed { get; set; }

        [NameInMap("DkimPublicKey")]
        [Validation(Required=false)]
        public string DkimPublicKey { get; set; }

        [NameInMap("DkimRsaLength")]
        [Validation(Required=false)]
        public int? DkimRsaLength { get; set; }

        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
