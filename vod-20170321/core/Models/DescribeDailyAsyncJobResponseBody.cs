// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeDailyAsyncJobResponseBody : TeaModel {
        [NameInMap("DailyJobList")]
        [Validation(Required=false)]
        public List<DescribeDailyAsyncJobResponseBodyDailyJobList> DailyJobList { get; set; }
        public class DescribeDailyAsyncJobResponseBodyDailyJobList : TeaModel {
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("JobCount")]
            [Validation(Required=false)]
            public int? JobCount { get; set; }

        }

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
