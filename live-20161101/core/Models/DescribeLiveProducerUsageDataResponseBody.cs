// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveProducerUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The production studio usage data.</para>
        /// </summary>
        [NameInMap("BillProducerData")]
        [Validation(Required=false)]
        public DescribeLiveProducerUsageDataResponseBodyBillProducerData BillProducerData { get; set; }
        public class DescribeLiveProducerUsageDataResponseBodyBillProducerData : TeaModel {
            [NameInMap("BillProducerDataItem")]
            [Validation(Required=false)]
            public List<DescribeLiveProducerUsageDataResponseBodyBillProducerDataBillProducerDataItem> BillProducerDataItem { get; set; }
            public class DescribeLiveProducerUsageDataResponseBodyBillProducerDataBillProducerDataItem : TeaModel {
                /// <summary>
                /// <para>The domain name. If domain is specified by the SplitBy parameter, the usage data is returned based on different domain names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The production studio instance. If instance is specified by the SplitBy parameter, the usage data is returned based on different production studio instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a17d0184-462d-4630-b2a6-8c26dde2****</para>
                /// </summary>
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public string Instance { get; set; }

                /// <summary>
                /// <para>The duration of high definition streaming. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6000</para>
                /// </summary>
                [NameInMap("OutputHdDuration")]
                [Validation(Required=false)]
                public long? OutputHdDuration { get; set; }

                /// <summary>
                /// <para>The duration of low definition streaming. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("OutputLdDuration")]
                [Validation(Required=false)]
                public long? OutputLdDuration { get; set; }

                /// <summary>
                /// <para>The duration of standard definition streaming. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("OutputSdDuration")]
                [Validation(Required=false)]
                public long? OutputSdDuration { get; set; }

                /// <summary>
                /// <para>The region. If region is specified by the SplitBy parameter, the usage data is returned based on different regions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-30T00:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The duration of high definition transcoding. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6777</para>
                /// </summary>
                [NameInMap("TranHdDuration")]
                [Validation(Required=false)]
                public long? TranHdDuration { get; set; }

                /// <summary>
                /// <para>The duration of low definition transcoding. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("TranLdDuration")]
                [Validation(Required=false)]
                public long? TranLdDuration { get; set; }

                /// <summary>
                /// <para>The duration of standard definition transcoding. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>666</para>
                /// </summary>
                [NameInMap("TranSdDuration")]
                [Validation(Required=false)]
                public long? TranSdDuration { get; set; }

                /// <summary>
                /// <para>The type of the production studio. If type is specified by the SplitBy parameter, the usage data is returned based on different types of production studios.</para>
                /// 
                /// <b>Example:</b>
                /// <para>slidelive</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The end of the time range during which data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-09-30T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start of the time range for which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-10-31T15:59:59Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
