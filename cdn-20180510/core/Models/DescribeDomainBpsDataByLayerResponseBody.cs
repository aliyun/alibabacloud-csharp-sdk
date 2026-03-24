// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainBpsDataByLayerResponseBody : TeaModel {
        [NameInMap("BpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainBpsDataByLayerResponseBodyBpsDataInterval BpsDataInterval { get; set; }
        public class DescribeDomainBpsDataByLayerResponseBodyBpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TrafficValue")]
                [Validation(Required=false)]
                public string TrafficValue { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The time interval between the data entries. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C565B910-BC3B-467B-9046-2A48566EA967</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
