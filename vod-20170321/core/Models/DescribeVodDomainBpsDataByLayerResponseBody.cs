// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainBpsDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth returned at each time interval. Unit: bit/s.</para>
        /// </summary>
        [NameInMap("BpsDataInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainBpsDataByLayerResponseBodyBpsDataInterval BpsDataInterval { get; set; }
        public class DescribeVodDomainBpsDataByLayerResponseBodyBpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-02-08T10:09:19Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("TrafficValue")]
                [Validation(Required=false)]
                public long? TrafficValue { get; set; }

                /// <summary>
                /// <para>The peak bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>75.33</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public double? Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The time interval between the entries returned. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public int? DataInterval { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A*****F6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
