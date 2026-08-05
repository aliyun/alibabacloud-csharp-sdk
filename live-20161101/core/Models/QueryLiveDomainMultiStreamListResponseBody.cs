// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class QueryLiveDomainMultiStreamListResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of online records.</para>
        /// </summary>
        [NameInMap("OnlineStreams")]
        [Validation(Required=false)]
        public List<QueryLiveDomainMultiStreamListResponseBodyOnlineStreams> OnlineStreams { get; set; }
        public class QueryLiveDomainMultiStreamListResponseBodyOnlineStreams : TeaModel {
            /// <summary>
            /// <para>The application name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apptest</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The stream switching records.</para>
            /// </summary>
            [NameInMap("ChangeLogs")]
            [Validation(Required=false)]
            public List<QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsChangeLogs> ChangeLogs { get; set; }
            public class QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsChangeLogs : TeaModel {
                /// <summary>
                /// <para>The reason for stream switching.</para>
                /// <list type="bullet">
                /// <item><description>merge cut manually: The user manually switched the stream.</description></item>
                /// <item><description>master stream no data: The primary stream has no data.</description></item>
                /// <item><description>master stream low quality: The primary stream quality degraded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>merge cut manually</para>
                /// </summary>
                [NameInMap("ChangeReason")]
                [Validation(Required=false)]
                public string ChangeReason { get; set; }

                /// <summary>
                /// <para>The stream switching time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format (UTC+0).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-13T09:20:47Z</para>
                /// </summary>
                [NameInMap("ChangeTime")]
                [Validation(Required=false)]
                public string ChangeTime { get; set; }

                /// <summary>
                /// <para>The stream that is actually used after the switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://118.178.168.35:1936/wwMultitest/pull.livetest2.aliyunlive.com_wwMultitest428_AliRewrite_2?vhost=pull.livetest2.aliyunlive.com&amp;live_rtmp_test=on</para>
                /// </summary>
                [NameInMap("MasterUpstream")]
                [Validation(Required=false)]
                public string MasterUpstream { get; set; }

                /// <summary>
                /// <para>The IP address used after the stream switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("UpstreamIp")]
                [Validation(Required=false)]
                public string UpstreamIp { get; set; }

                /// <summary>
                /// <para>The stream identifier after the switch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>***test_AliRewrite_2</para>
                /// </summary>
                [NameInMap("UpstreamSequence")]
                [Validation(Required=false)]
                public string UpstreamSequence { get; set; }

            }

            /// <summary>
            /// <para>The streaming domain of the streamer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>play.***.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The feature switch. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled.</description></item>
            /// <item><description><b>off</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("OptimalMode")]
            [Validation(Required=false)]
            public string OptimalMode { get; set; }

            /// <summary>
            /// <para>The name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>teststream</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

            /// <summary>
            /// <para>The list of all candidate streams.</para>
            /// </summary>
            [NameInMap("UpstreamList")]
            [Validation(Required=false)]
            public List<QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsUpstreamList> UpstreamList { get; set; }
            public class QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsUpstreamList : TeaModel {
                /// <summary>
                /// <para>The primary/secondary flag.</para>
                /// <remarks>
                /// <para>Indicates which stream is currently being used for merged distribution.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("MasterFlag")]
                [Validation(Required=false)]
                public bool? MasterFlag { get; set; }

                /// <summary>
                /// <para>The IP address of the ingest client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("UpstreamIp")]
                [Validation(Required=false)]
                public string UpstreamIp { get; set; }

                /// <summary>
                /// <para>The unique identifier of the ingest stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>***test_Alirewrite1</para>
                /// </summary>
                [NameInMap("UpstreamSequence")]
                [Validation(Required=false)]
                public string UpstreamSequence { get; set; }

                /// <summary>
                /// <para>The stream ingest time. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format (UTC+0).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-13T09:20:47Z</para>
                /// </summary>
                [NameInMap("UpstreamTime")]
                [Validation(Required=false)]
                public string UpstreamTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF60DB6A-7FD6-426E-9288-122CC1A5****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
