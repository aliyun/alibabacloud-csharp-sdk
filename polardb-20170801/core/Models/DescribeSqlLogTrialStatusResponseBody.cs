// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSqlLogTrialStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("EverTrialed")]
        [Validation(Required=false)]
        public string EverTrialed { get; set; }

        [NameInMap("OpenTrial")]
        [Validation(Required=false)]
        public string OpenTrial { get; set; }

        [NameInMap("RemainDays")]
        [Validation(Required=false)]
        public string RemainDays { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("UsedDays")]
        [Validation(Required=false)]
        public string UsedDays { get; set; }

    }

}
