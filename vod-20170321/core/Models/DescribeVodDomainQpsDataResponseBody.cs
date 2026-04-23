// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainQpsDataResponseBody : TeaModel {
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
        /// <para>The end of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>YYYY-MM-DD**Thh:mm:ss</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-02T15:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainQpsDataResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeVodDomainQpsDataResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainQpsDataResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainQpsDataResponseBodyQpsDataIntervalDataModule : TeaModel {
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
        /// <para>25818875-5F78-4AF6-D7393642CA58*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which data was queried. The time follows the ISO 8601 standard in the <em>YYYY-MM-DD**Thh:mm:ss</em> format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-05-02T15:50:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
