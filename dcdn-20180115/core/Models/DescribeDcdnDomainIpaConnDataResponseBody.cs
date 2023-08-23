// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainIpaConnDataResponseBody : TeaModel {
        /// <summary>
        /// The number of user connections at each time interval.
        /// </summary>
        [NameInMap("ConnectionDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerInterval ConnectionDataPerInterval { get; set; }
        public class DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainIpaConnDataResponseBodyConnectionDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// The number of IPA user connections.
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
