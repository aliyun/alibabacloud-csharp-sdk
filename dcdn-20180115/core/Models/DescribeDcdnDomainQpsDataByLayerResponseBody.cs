// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainQpsDataByLayerResponseBody : TeaModel {
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
        /// <para>The accelerated domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The layer at which the data was collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// <para>The QPS returned at each time interval.</para>
        /// </summary>
        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainQpsDataByLayerResponseBodyQpsDataIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The number of requests in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("AccDomesticValue")]
                [Validation(Required=false)]
                public string AccDomesticValue { get; set; }

                /// <summary>
                /// <para>The number of requests outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>44</para>
                /// </summary>
                [NameInMap("AccOverseasValue")]
                [Validation(Required=false)]
                public string AccOverseasValue { get; set; }

                /// <summary>
                /// <para>The total number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>56</para>
                /// </summary>
                [NameInMap("AccValue")]
                [Validation(Required=false)]
                public string AccValue { get; set; }

                /// <summary>
                /// <para>The number of queries per second in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                /// <summary>
                /// <para>The number of queries per second outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.44</para>
                /// </summary>
                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T21:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total number of queries per second.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
