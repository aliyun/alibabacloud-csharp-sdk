// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDelayedStreamingUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the stream delay usage data.</para>
        /// </summary>
        [NameInMap("DelayData")]
        [Validation(Required=false)]
        public DescribeLiveDelayedStreamingUsageResponseBodyDelayData DelayData { get; set; }
        public class DescribeLiveDelayedStreamingUsageResponseBodyDelayData : TeaModel {
            [NameInMap("DelayDataItem")]
            [Validation(Required=false)]
            public List<DescribeLiveDelayedStreamingUsageResponseBodyDelayDataDelayDataItem> DelayDataItem { get; set; }
            public class DescribeLiveDelayedStreamingUsageResponseBodyDelayDataDelayDataItem : TeaModel {
                /// <summary>
                /// <para>The domain name. If SplitBy is set to domain, the data returned is grouped by domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The duration of stream delay.</para>
                /// 
                /// <b>Example:</b>
                /// <para>84</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                /// <summary>
                /// <para>The ID of the region. If SplitBy is set to region, the data returned is grouped by region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The name of the stream. If SplitBy is set to stream, the data returned is grouped by stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The timestamp of the data returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-10T20:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The end of the time range during which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B460F8B-993C-4F48-B98A-910811DEBFEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the data was queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
