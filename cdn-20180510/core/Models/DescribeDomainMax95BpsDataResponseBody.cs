// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainMax95BpsDataResponseBody : TeaModel {
        [NameInMap("DetailData")]
        [Validation(Required=false)]
        public DescribeDomainMax95BpsDataResponseBodyDetailData DetailData { get; set; }
        public class DescribeDomainMax95BpsDataResponseBodyDetailData : TeaModel {
            [NameInMap("Max95Detail")]
            [Validation(Required=false)]
            public List<DescribeDomainMax95BpsDataResponseBodyDetailDataMax95Detail> Max95Detail { get; set; }
            public class DescribeDomainMax95BpsDataResponseBodyDetailDataMax95Detail : TeaModel {
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                [NameInMap("Max95Bps")]
                [Validation(Required=false)]
                public float? Max95Bps { get; set; }

                [NameInMap("Max95BpsPeakTime")]
                [Validation(Required=false)]
                public string Max95BpsPeakTime { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The accelerated domain name.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The 95th percentile bandwidth in the Chinese mainland.
        /// </summary>
        [NameInMap("DomesticMax95Bps")]
        [Validation(Required=false)]
        public string DomesticMax95Bps { get; set; }

        /// <summary>
        /// The end of the time range for which the data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The 95th percentile bandwidth.
        /// </summary>
        [NameInMap("Max95Bps")]
        [Validation(Required=false)]
        public string Max95Bps { get; set; }

        /// <summary>
        /// The 95th percentile bandwidth outside the Chinese mainland.
        /// </summary>
        [NameInMap("OverseasMax95Bps")]
        [Validation(Required=false)]
        public string OverseasMax95Bps { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range for which the data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
