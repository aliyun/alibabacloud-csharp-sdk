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

        [NameInMap("HttpCodeDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval HttpCodeDataInterval { get; set; }
        public class DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainHttpCodeDataByLayerResponseBodyHttpCodeDataIntervalDataModule : TeaModel {
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("TotalValue")]
                [Validation(Required=false)]
                public string TotalValue { get; set; }

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
