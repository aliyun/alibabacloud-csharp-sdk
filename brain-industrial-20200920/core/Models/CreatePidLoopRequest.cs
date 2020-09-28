// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class CreatePidLoopRequest : TeaModel {
        [NameInMap("PidLoopName")]
        [Validation(Required=true)]
        public string PidLoopName { get; set; }

        [NameInMap("IsCrucialPidLoop")]
        [Validation(Required=true)]
        public bool? IsCrucialPidLoop { get; set; }

        [NameInMap("PidLoopDesc")]
        [Validation(Required=false)]
        public string PidLoopDesc { get; set; }

        [NameInMap("PidProjectId")]
        [Validation(Required=true)]
        public string PidProjectId { get; set; }

        [NameInMap("PidLoopDcsType")]
        [Validation(Required=true)]
        public string PidLoopDcsType { get; set; }

        [NameInMap("PidLoopType")]
        [Validation(Required=true)]
        public string PidLoopType { get; set; }

        [NameInMap("PidLoopConfiguration")]
        [Validation(Required=true)]
        public Dictionary<string, object> PidLoopConfiguration { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=true)]
        public string ClientToken { get; set; }

    }

}
