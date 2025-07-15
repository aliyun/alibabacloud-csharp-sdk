// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainPushTrafficDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity.</para>
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

        /// <summary>
        /// <para>The traffic data that was collected at each interval.</para>
        /// </summary>
        [NameInMap("TrafficDataPerInterval")]
        [Validation(Required=false)]
        public DescribeLiveDomainPushTrafficDataResponseBodyTrafficDataPerInterval TrafficDataPerInterval { get; set; }
        public class DescribeLiveDomainPushTrafficDataResponseBodyTrafficDataPerInterval : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainPushTrafficDataResponseBodyTrafficDataPerIntervalDataModule> DataModule { get; set; }
            public class DescribeLiveDomainPushTrafficDataResponseBodyTrafficDataPerIntervalDataModule : TeaModel {
                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-10T20:05:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

                /// <summary>
                /// <para>The traffic. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1288111</para>
                /// </summary>
                [NameInMap("TrafficValue")]
                [Validation(Required=false)]
                public string TrafficValue { get; set; }

            }

        }

    }

}
