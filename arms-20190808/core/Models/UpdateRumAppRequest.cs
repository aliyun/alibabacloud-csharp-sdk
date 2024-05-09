// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateRumAppRequest : TeaModel {
        [NameInMap("AutoRestart")]
        [Validation(Required=false)]
        public bool? AutoRestart { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IsSubscribe")]
        [Validation(Required=false)]
        public bool? IsSubscribe { get; set; }

        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Restart")]
        [Validation(Required=false)]
        public bool? Restart { get; set; }

        [NameInMap("ServiceDomainOperationJson")]
        [Validation(Required=false)]
        public string ServiceDomainOperationJson { get; set; }

        [NameInMap("Stop")]
        [Validation(Required=false)]
        public bool? Stop { get; set; }

    }

}
