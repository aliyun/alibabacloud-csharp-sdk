// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetDailyReportPidParamRequest : TeaModel {
        [NameInMap("PidLoopId")]
        [Validation(Required=true)]
        public string PidLoopId { get; set; }

        [NameInMap("PidReportDate")]
        [Validation(Required=false)]
        public string PidReportDate { get; set; }

    }

}
