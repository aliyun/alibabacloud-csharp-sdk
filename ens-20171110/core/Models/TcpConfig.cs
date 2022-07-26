// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class TcpConfig : TeaModel {
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        [NameInMap("PersistenceTimeout")]
        [Validation(Required=false)]
        public int? PersistenceTimeout { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

    }

}
