// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByTimeStampResponseBody : TeaModel {
        /// <summary>
        /// A list of bandwidth values by ISP and region.
        /// </summary>
        [NameInMap("BpsDataList")]
        [Validation(Required=false)]
        public DescribeDomainBpsDataByTimeStampResponseBodyBpsDataList BpsDataList { get; set; }
        public class DescribeDomainBpsDataByTimeStampResponseBodyBpsDataList : TeaModel {
            [NameInMap("BpsDataModel")]
            [Validation(Required=false)]
            public List<DescribeDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel> BpsDataModel { get; set; }
            public class DescribeDomainBpsDataByTimeStampResponseBodyBpsDataListBpsDataModel : TeaModel {
                /// <summary>
                /// The bandwidth value.
                /// </summary>
                [NameInMap("Bps")]
                [Validation(Required=false)]
                public long? Bps { get; set; }

                /// <summary>
                /// The name of the ISP.
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("LocationName")]
                [Validation(Required=false)]
                public string LocationName { get; set; }

                /// <summary>
                /// The timestamp of the data returned.
                /// </summary>
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The point in time.
        /// </summary>
        [NameInMap("TimeStamp")]
        [Validation(Required=false)]
        public string TimeStamp { get; set; }

    }

}
