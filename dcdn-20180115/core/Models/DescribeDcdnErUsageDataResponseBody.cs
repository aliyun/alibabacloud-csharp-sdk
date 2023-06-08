// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnErUsageDataResponseBody : TeaModel {
        /// <summary>
        /// The end of the time range during which data was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The list of the data returned.
        /// </summary>
        [NameInMap("ErAccData")]
        [Validation(Required=false)]
        public DescribeDcdnErUsageDataResponseBodyErAccData ErAccData { get; set; }
        public class DescribeDcdnErUsageDataResponseBodyErAccData : TeaModel {
            [NameInMap("ErAccItem")]
            [Validation(Required=false)]
            public List<DescribeDcdnErUsageDataResponseBodyErAccDataErAccItem> ErAccItem { get; set; }
            public class DescribeDcdnErUsageDataResponseBodyErAccDataErAccItem : TeaModel {
                /// <summary>
                /// The number of requests.
                /// </summary>
                [NameInMap("ErAcc")]
                [Validation(Required=false)]
                public long? ErAcc { get; set; }

                /// <summary>
                /// The ID of the routine. This parameter is returned only when SplitBy is set to routine.
                /// </summary>
                [NameInMap("Routine")]
                [Validation(Required=false)]
                public string Routine { get; set; }

                /// <summary>
                /// The specification of the routine. This parameter is returned only when SplitBy is set to spec.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// The timestamp of the returned data.
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

        /// <summary>
        /// The start of the time range during which data was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
