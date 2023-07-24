// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeQpsDataResponseBody : TeaModel {
        /// <summary>
        /// The information about the backup set.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                /// <summary>
                /// The number of queries per second (QPS).
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// The timestamp of the data returned. The time follows the ISO 8601 standard. The time is displayed in UTC.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
