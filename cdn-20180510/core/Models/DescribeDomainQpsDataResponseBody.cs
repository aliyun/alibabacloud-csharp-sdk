// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainQpsDataResponseBody : TeaModel {
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
        /// <para>2019-11-30T05:40:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainQpsDataResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeDomainQpsDataResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainQpsDataResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainQpsDataResponseBodyQpsDataIntervalDataModule : TeaModel {
                [NameInMap("AccDomesticValue")]
                [Validation(Required=false)]
                public string AccDomesticValue { get; set; }

                [NameInMap("AccOverseasValue")]
                [Validation(Required=false)]
                public string AccOverseasValue { get; set; }

                [NameInMap("AccValue")]
                [Validation(Required=false)]
                public string AccValue { get; set; }

                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                [NameInMap("HttpsAccDomesticValue")]
                [Validation(Required=false)]
                public string HttpsAccDomesticValue { get; set; }

                [NameInMap("HttpsAccOverseasValue")]
                [Validation(Required=false)]
                public string HttpsAccOverseasValue { get; set; }

                [NameInMap("HttpsAccValue")]
                [Validation(Required=false)]
                public string HttpsAccValue { get; set; }

                [NameInMap("HttpsDomesticValue")]
                [Validation(Required=false)]
                public string HttpsDomesticValue { get; set; }

                [NameInMap("HttpsOverseasValue")]
                [Validation(Required=false)]
                public string HttpsOverseasValue { get; set; }

                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B8333EDB-4595-46E0-AFE9-29BAA290D0E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-11-30T05:33:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
