// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class QueryLiveDomainMultiStreamListResponseBody : TeaModel {
        /// <summary>
        /// <para>The online streams returned.</para>
        /// </summary>
        [NameInMap("OnlineStreams")]
        [Validation(Required=false)]
        public List<QueryLiveDomainMultiStreamListResponseBodyOnlineStreams> OnlineStreams { get; set; }
        public class QueryLiveDomainMultiStreamListResponseBodyOnlineStreams : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apptest</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The switchover records.</para>
            /// </summary>
            [NameInMap("ChangeLogs")]
            [Validation(Required=false)]
            public List<QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsChangeLogs> ChangeLogs { get; set; }
            public class QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsChangeLogs : TeaModel {
                /// <summary>
                /// <para>The reason for the switchover.</para>
                /// <list type="bullet">
                /// <item><description>merge cut manually: You proactively switched the stream.</description></item>
                /// <item><description>master stream no data: No data is available in the active stream.</description></item>
                /// <item><description>master stream low quality: The quality of the active stream deteriorated.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>merge cut manually</para>
                /// </summary>
                [NameInMap("ChangeReason")]
                [Validation(Required=false)]
                public string ChangeReason { get; set; }

                /// <summary>
                /// <para>The switchover time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-11-13T09:20:47Z</para>
                /// </summary>
                [NameInMap("ChangeTime")]
                [Validation(Required=false)]
                public string ChangeTime { get; set; }

                /// <summary>
                /// <para>The stream used after the switchover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rtmp://118.178.168.35:1936/wwMultitest/pull.livetest2.aliyunlive.com_wwMultitest428_AliRewrite_2?vhost=pull.livetest2.aliyunlive.com&amp;live_rtmp_test=on</para>
                /// </summary>
                [NameInMap("MasterUpstream")]
                [Validation(Required=false)]
                public string MasterUpstream { get; set; }

                /// <summary>
                /// <para>The IP address used after the switchover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("UpstreamIp")]
                [Validation(Required=false)]
                public string UpstreamIp { get; set; }

                /// <summary>
                /// <para>The identifier of the stream after the switchover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>***test_AliRewrite_2</para>
                /// </summary>
                [NameInMap("UpstreamSequence")]
                [Validation(Required=false)]
                public string UpstreamSequence { get; set; }

            }

            /// <summary>
            /// <para>The main streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>play.***.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether the dual-stream disaster recovery feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled</description></item>
            /// <item><description><b>off</b>: disabled</description></item>
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
            /// <para>The standby streams.</para>
            /// </summary>
            [NameInMap("UpstreamList")]
            [Validation(Required=false)]
            public List<QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsUpstreamList> UpstreamList { get; set; }
            public class QueryLiveDomainMultiStreamListResponseBodyOnlineStreamsUpstreamList : TeaModel {
                /// <summary>
                /// <para>The active/standby tag.</para>
                /// <remarks>
                /// <para> This parameter indicates whether the active or standby stream is being distributed.</para>
                /// </remarks>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("MasterFlag")]
                [Validation(Required=false)]
                public bool? MasterFlag { get; set; }

                /// <summary>
                /// <para>The IP address of the stream ingest client.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("UpstreamIp")]
                [Validation(Required=false)]
                public string UpstreamIp { get; set; }

                /// <summary>
                /// <para>The unique identifier of the stream ingest.</para>
                /// 
                /// <b>Example:</b>
                /// <para>***test_Alirewrite1</para>
                /// </summary>
                [NameInMap("UpstreamSequence")]
                [Validation(Required=false)]
                public string UpstreamSequence { get; set; }

                /// <summary>
                /// <para>The stream ingest time.</para>
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
        /// <para>The page number.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
