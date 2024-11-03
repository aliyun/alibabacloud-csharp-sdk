// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainHttpCodeDataByLayerResponseBody : TeaModel {
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
        /// <para>The statistics of HTTP status codes returned at each time interval.</para>
        /// </summary>
        [NameInMap("HttpCodeDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval HttpCodeDataInterval { get; set; }
        public class DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-10T20:35:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total number of times that HTTP status codes were returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110</para>
                /// </summary>
                [NameInMap("TotalValue")]
                [Validation(Required=false)]
                public string TotalValue { get; set; }

                /// <summary>
                /// <para>The number of times that the HTTP status code was returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;200&quot;: 10, &quot;206&quot;: 100}</para>
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

    }

}
