// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeIceDurPeriodByDaySubTypeResponseBody : TeaModel {
        [NameInMap("JobInfoList")]
        [Validation(Required=false)]
        public List<DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoList> JobInfoList { get; set; }
        public class DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoList : TeaModel {
            [NameInMap("DateTs")]
            [Validation(Required=false)]
            public long? DateTs { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("SubJobInfoList")]
            [Validation(Required=false)]
            public List<DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoListSubJobInfoList> SubJobInfoList { get; set; }
            public class DescribeIceDurPeriodByDaySubTypeResponseBodyJobInfoListSubJobInfoList : TeaModel {
                [NameInMap("SubJobDuration")]
                [Validation(Required=false)]
                public long? SubJobDuration { get; set; }

                [NameInMap("SubJobType")]
                [Validation(Required=false)]
                public string SubJobType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
