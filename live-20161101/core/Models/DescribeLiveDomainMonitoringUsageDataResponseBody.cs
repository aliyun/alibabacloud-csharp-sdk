// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainMonitoringUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// <para>The end of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-10T22:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the monitoring session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e62af24d-a354-3b0c-9f1f-da592c4b****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The live monitoring data.</para>
        /// </summary>
        [NameInMap("MonitoringData")]
        [Validation(Required=false)]
        public DescribeLiveDomainMonitoringUsageDataResponseBodyMonitoringData MonitoringData { get; set; }
        public class DescribeLiveDomainMonitoringUsageDataResponseBodyMonitoringData : TeaModel {
            [NameInMap("MonitoringDataItem")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainMonitoringUsageDataResponseBodyMonitoringDataMonitoringDataItem> MonitoringDataItem { get; set; }
            public class DescribeLiveDomainMonitoringUsageDataResponseBodyMonitoringDataMonitoringDataItem : TeaModel {
                /// <summary>
                /// <para>The domain name. This field is valid only when you specify domain for the <b>SplitBy</b> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The duration. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The ID of the monitoring session. This field is valid only when you specify instance for the <b>SplitBy</b> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e62af24d-a354-3b0c-9f1f-da592c4b****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The region of the live center. This field is valid only when you specify Region for the <b>SplitBy</b> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The resolution. This field is valid only when you specify resolution for the <b>SplitBy</b> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>720P</para>
                /// </summary>
                [NameInMap("Resolution")]
                [Validation(Required=false)]
                public string Resolution { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The region of the live center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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
        /// <para>The beginning of the time range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-12-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
