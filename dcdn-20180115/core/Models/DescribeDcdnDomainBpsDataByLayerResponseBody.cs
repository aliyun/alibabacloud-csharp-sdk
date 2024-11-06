// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainBpsDataByLayerResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth returned at each time interval.</para>
        /// </summary>
        [NameInMap("BpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataInterval BpsDataInterval { get; set; }
        public class DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainBpsDataByLayerResponseBodyBpsDataIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The traffic that is used to deliver dynamic content. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("DynamicTrafficValue")]
                [Validation(Required=false)]
                public string DynamicTrafficValue { get; set; }

                /// <summary>
                /// <para>The bandwidth that is used to deliver dynamic content. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.34</para>
                /// </summary>
                [NameInMap("DynamicValue")]
                [Validation(Required=false)]
                public string DynamicValue { get; set; }

                /// <summary>
                /// <para>The traffic that is used to deliver static content. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>131</para>
                /// </summary>
                [NameInMap("StaticTrafficValue")]
                [Validation(Required=false)]
                public string StaticTrafficValue { get; set; }

                /// <summary>
                /// <para>The bandwidth that is used to deliver static content. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.22</para>
                /// </summary>
                [NameInMap("StaticValue")]
                [Validation(Required=false)]
                public string StaticValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T21:00:00Z</para>
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
                /// <para>The total bandwidth. Unit: bit/s.</para>
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
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
