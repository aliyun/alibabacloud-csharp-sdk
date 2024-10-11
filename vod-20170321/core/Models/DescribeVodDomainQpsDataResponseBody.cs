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

        /// <summary>
        /// <para>The list of QPS records at each interval.</para>
        /// </summary>
        [NameInMap("QpsDataInterval")]
        [Validation(Required=false)]
        public DescribeVodDomainQpsDataResponseBodyQpsDataInterval QpsDataInterval { get; set; }
        public class DescribeVodDomainQpsDataResponseBodyQpsDataInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeVodDomainQpsDataResponseBodyQpsDataIntervalDataModule> DataModule { get; set; }
            public class DescribeVodDomainQpsDataResponseBodyQpsDataIntervalDataModule : TeaModel {
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
                /// <para>The QPS data in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DomesticValue")]
                [Validation(Required=false)]
                public string DomesticValue { get; set; }

                /// <summary>
                /// <para>The QPS that is calculated based on the HTTPS requests sent to POPs in the Chinese mainland.</para>
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
                /// <para>The QPS that is calculated based on the HTTPS requests sent to POPs in the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsDomesticValue")]
                [Validation(Required=false)]
                public string HttpsDomesticValue { get; set; }

                /// <summary>
                /// <para>The QPS that is calculated based on the HTTPS requests sent to POPs outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsOverseasValue")]
                [Validation(Required=false)]
                public string HttpsOverseasValue { get; set; }

                /// <summary>
                /// <para>The QPS that is calculated based on the HTTPS requests sent to points of presence (POPs).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("HttpsValue")]
                [Validation(Required=false)]
                public string HttpsValue { get; set; }

                /// <summary>
                /// <para>The QPS data outside the Chinese mainland.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OverseasValue")]
                [Validation(Required=false)]
                public string OverseasValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-06-27 10:10:58</para>
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
