// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeIceDurPeriodByDaySubTypeRequest : TeaModel {
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("StartTs")]
        [Validation(Required=false)]
        public long? StartTs { get; set; }

        [NameInMap("TimeZone")]
        [Validation(Required=false)]
        public string TimeZone { get; set; }

    }

}
