// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class AddPidLoopToScheduleRequest : TeaModel {
        [NameInMap("PidLoopIdList")]
        [Validation(Required=true)]
        public Dictionary<string, object> PidLoopIdList { get; set; }

    }

}
