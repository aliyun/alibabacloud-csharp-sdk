// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainBpsDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned at each time interval.</para>
        /// </summary>
        [NameInMap("BpsDataInterval")]
        [Validation(Required=false)]
        public DescribeLiveDomainBpsDataByLayerResponseBodyBpsDataInterval BpsDataInterval { get; set; }
        public class DescribeLiveDomainBpsDataByLayerResponseBodyBpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-15T16:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>331</para>
                /// </summary>
                [NameInMap("TrafficValue")]
                [Validation(Required=false)]
                public string TrafficValue { get; set; }

                /// <summary>
                /// <para>The peak bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.56</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The time interval between the data entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-2A48566EA967</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
