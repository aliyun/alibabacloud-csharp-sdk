// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainRealTimeQpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the backup set.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDcdnDomainRealTimeQpsDataResponseBodyData Data { get; set; }
        public class DescribeDcdnDomainRealTimeQpsDataResponseBodyData : TeaModel {
            [NameInMap("QpsModel")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel> QpsModel { get; set; }
            public class DescribeDcdnDomainRealTimeQpsDataResponseBodyDataQpsModel : TeaModel {
                /// <summary>
                /// <para>The number of queries per second (QPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1851.25</para>
                /// </summary>
                [NameInMap("Qps")]
                [Validation(Required=false)]
                public float? Qps { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-01-02T11:26:00Z</para>
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
        /// <para>32DC9806-E9F9-4490-BBDC-B3A9E32FCC1D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
