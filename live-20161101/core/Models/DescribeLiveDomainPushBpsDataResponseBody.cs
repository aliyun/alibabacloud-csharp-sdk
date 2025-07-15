// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainPushBpsDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth data that was collected at each interval.</para>
        /// </summary>
        [NameInMap("BpsDataPerInterval")]
        [Validation(Required=false)]
        public DescribeLiveDomainPushBpsDataResponseBodyBpsDataPerInterval BpsDataPerInterval { get; set; }
        public class DescribeLiveDomainPushBpsDataResponseBodyBpsDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainPushBpsDataResponseBodyBpsDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainPushBpsDataResponseBodyBpsDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The bandwidth. Unit: bit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11288111</para>
                /// </summary>
                [NameInMap("BpsValue")]
                [Validation(Required=false)]
                public string BpsValue { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The time granularity of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The ingest domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range during which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C6CCEC4-6B88-4D4A-93E4-D47B3D92CF8F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
