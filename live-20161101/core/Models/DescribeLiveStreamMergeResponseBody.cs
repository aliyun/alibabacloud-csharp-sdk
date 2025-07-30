// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamMergeResponseBody : TeaModel {
        /// <summary>
        /// <para>Live stream information list.</para>
        /// </summary>
        [NameInMap("LiveStreamMergeList")]
        [Validation(Required=false)]
        public DescribeLiveStreamMergeResponseBodyLiveStreamMergeList LiveStreamMergeList { get; set; }
        public class DescribeLiveStreamMergeResponseBodyLiveStreamMergeList : TeaModel {
            [NameInMap("LiveStreamMerge")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamMergeResponseBodyLiveStreamMergeListLiveStreamMerge> LiveStreamMerge { get; set; }
            public class DescribeLiveStreamMergeResponseBodyLiveStreamMergeListLiveStreamMerge : TeaModel {
                /// <summary>
                /// <para>The name of the application that generates the output stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The application that is being used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app1</para>
                /// </summary>
                [NameInMap("AppUsing")]
                [Validation(Required=false)]
                public string AppUsing { get; set; }

                /// <summary>
                /// <para>The streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The end time of the stream mixing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-05-29T01:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The names of the applications that generate the input additional streams other than the primary stream and secondary stream, and the names of these additional streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app3/stream3,app4/stream4,app5/stream5,…,appN/streamN</para>
                /// </summary>
                [NameInMap("ExtraInAppStreams")]
                [Validation(Required=false)]
                public string ExtraInAppStreams { get; set; }

                /// <summary>
                /// <para>The name of the application that generates the input primary stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app1</para>
                /// </summary>
                [NameInMap("InAppName1")]
                [Validation(Required=false)]
                public string InAppName1 { get; set; }

                /// <summary>
                /// <para>The name of the application that generates the input secondary stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app2</para>
                /// </summary>
                [NameInMap("InAppName2")]
                [Validation(Required=false)]
                public string InAppName2 { get; set; }

                /// <summary>
                /// <para>The name of the input primary stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InStream1</para>
                /// </summary>
                [NameInMap("InStreamName1")]
                [Validation(Required=false)]
                public string InStreamName1 { get; set; }

                /// <summary>
                /// <para>The name of the input secondary stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stream2</para>
                /// </summary>
                [NameInMap("InStreamName2")]
                [Validation(Required=false)]
                public string InStreamName2 { get; set; }

                [NameInMap("LiveMerger")]
                [Validation(Required=false)]
                public string LiveMerger { get; set; }

                [NameInMap("MergeParameters")]
                [Validation(Required=false)]
                public string MergeParameters { get; set; }

                /// <summary>
                /// <para>The streaming protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The start time of the stream mixing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-05-29T00:00:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The name of the output stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>StreamName</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The stream that is being used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InStream1</para>
                /// </summary>
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
