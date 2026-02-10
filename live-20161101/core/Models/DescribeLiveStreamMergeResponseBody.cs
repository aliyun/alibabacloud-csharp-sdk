// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMergeResponseBody : TeaModel {
        [NameInMap("LiveStreamMergeList")]
        [Validation(Required=false)]
        public DescribeLiveStreamMergeResponseBodyLiveStreamMergeList LiveStreamMergeList { get; set; }
        public class DescribeLiveStreamMergeResponseBodyLiveStreamMergeList : TeaModel {
            [NameInMap("LiveStreamMerge")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamMergeResponseBodyLiveStreamMergeListLiveStreamMerge> LiveStreamMerge { get; set; }
            public class DescribeLiveStreamMergeResponseBodyLiveStreamMergeListLiveStreamMerge : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppUsing")]
                [Validation(Required=false)]
                public string AppUsing { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExtraInAppStreams")]
                [Validation(Required=false)]
                public string ExtraInAppStreams { get; set; }

                [NameInMap("InAppName1")]
                [Validation(Required=false)]
                public string InAppName1 { get; set; }

                [NameInMap("InAppName2")]
                [Validation(Required=false)]
                public string InAppName2 { get; set; }

                [NameInMap("InStreamName1")]
                [Validation(Required=false)]
                public string InStreamName1 { get; set; }

                [NameInMap("InStreamName2")]
                [Validation(Required=false)]
                public string InStreamName2 { get; set; }

                [NameInMap("LiveMerger")]
                [Validation(Required=false)]
                public string LiveMerger { get; set; }

                [NameInMap("MergeParameters")]
                [Validation(Required=false)]
                public string MergeParameters { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("StreamUsing")]
                [Validation(Required=false)]
                public string StreamUsing { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
