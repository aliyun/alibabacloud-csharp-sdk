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

        /// <summary>
        /// <para>The list of QPS records at each interval.</para>
        /// </summary>
        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeDomainQpsDataResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeDomainQpsDataResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeDomainQpsDataResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeDomainQpsDataResponseBodyQpsDataIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The number of requests in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AccDomesticValue")]
                [Validation(Required=false)]
                public string AccDomesticValue { get; set; }

                /// <summary>
                /// <para>The number of requests outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AccOverseasValue")]
                [Validation(Required=false)]
                public string AccOverseasValue { get; set; }

                /// <summary>
                /// <para>The total number of requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AccValue")]
                [Validation(Required=false)]
                public string AccValue { get; set; }

                /// <summary>
                /// <para>The number of queries per second in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                /// <summary>
                /// <para>The number of HTTPS requests sent to POPs in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsAccDomesticValue")]
                [Validation(Required=false)]
                public string HttpsAccDomesticValue { get; set; }

                /// <summary>
                /// <para>The number of HTTPS requests sent to POPs outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsAccOverseasValue")]
                [Validation(Required=false)]
                public string HttpsAccOverseasValue { get; set; }

                /// <summary>
                /// <para>The number of HTTPS requests sent to POPs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsAccValue")]
                [Validation(Required=false)]
                public string HttpsAccValue { get; set; }

                /// <summary>
                /// <para>The number of queries per second that is calculated based on the HTTPS requests sent to POPs in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsDomesticValue")]
                [Validation(Required=false)]
                public string HttpsDomesticValue { get; set; }

                /// <summary>
                /// <para>The number of queries per second that is calculated based on the HTTPS requests sent to POPs outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsOverseasValue")]
                [Validation(Required=false)]
                public string HttpsOverseasValue { get; set; }

                /// <summary>
                /// <para>The number of queries per second that is calculated based on the HTTPS requests sent to points of presence (POPs).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                /// <summary>
                /// <para>The number of queries per second outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-11-30T05:40:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The total QPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
