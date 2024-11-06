// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainQpsDataResponseBody : TeaModel {
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
        /// <para>2017-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The QPS returned at each time interval.</para>
        /// </summary>
        [NameInMap("QpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeDcdnDomainQpsDataResponseBodyQpsDataPerInterval QpsDataPerInterval { get; set; }
        public class DescribeDcdnDomainQpsDataResponseBodyQpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeDcdnDomainQpsDataResponseBodyQpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The total number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Acc")]
                [Validation(Required=false)]
                public float? Acc { get; set; }

                /// <summary>
                /// <para>The number of requests for dynamic content delivery over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DynamicHttpAcc")]
                [Validation(Required=false)]
                public float? DynamicHttpAcc { get; set; }

                /// <summary>
                /// <para>The QPS for dynamic content delivery over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DynamicHttpQps")]
                [Validation(Required=false)]
                public float? DynamicHttpQps { get; set; }

                /// <summary>
                /// <para>The number of requests for dynamic content delivery over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DynamicHttpsAcc")]
                [Validation(Required=false)]
                public float? DynamicHttpsAcc { get; set; }

                /// <summary>
                /// <para>The QPS for dynamic content delivery over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DynamicHttpsQps")]
                [Validation(Required=false)]
                public float? DynamicHttpsQps { get; set; }

                /// <summary>
                /// <para>The total QPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.56</para>
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// <para>The number of requests for static content delivery over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StaticHttpAcc")]
                [Validation(Required=false)]
                public float? StaticHttpAcc { get; set; }

                /// <summary>
                /// <para>The QPS for static content delivery over HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StaticHttpQps")]
                [Validation(Required=false)]
                public float? StaticHttpQps { get; set; }

                /// <summary>
                /// <para>The number of requests for static content delivery over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StaticHttpsAcc")]
                [Validation(Required=false)]
                public float? StaticHttpsAcc { get; set; }

                /// <summary>
                /// <para>The QPS for static content delivery over HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StaticHttpsQps")]
                [Validation(Required=false)]
                public float? StaticHttpsQps { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T21:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

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
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
