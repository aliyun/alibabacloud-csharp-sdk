// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FCFFE4A4-F34F-4EEF-B401-36A01689AFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics of the live streams.</para>
        /// </summary>
        [NameInMap("StreamCountInfos")]
        [Validation(Required=false)]
        public DescribeLiveStreamCountResponseBodyStreamCountInfos StreamCountInfos { get; set; }
        public class DescribeLiveStreamCountResponseBodyStreamCountInfos : TeaModel {
            [NameInMap("StreamCountInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfo> StreamCountInfo { get; set; }
            public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfo : TeaModel {
                /// <summary>
                /// <para>The number of online streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The maximum allowed number of concurrently ingested streams. This parameter is available only to users in the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Limit")]
                [Validation(Required=false)]
                public long? Limit { get; set; }

                /// <summary>
                /// <para>The information about the live streams.</para>
                /// </summary>
                [NameInMap("StreamCountDetails")]
                [Validation(Required=false)]
                public DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetails StreamCountDetails { get; set; }
                public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetails : TeaModel {
                    [NameInMap("StreamCountDetail")]
                    [Validation(Required=false)]
                    public List<DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail> StreamCountDetail { get; set; }
                    public class DescribeLiveStreamCountResponseBodyStreamCountInfosStreamCountInfoStreamCountDetailsStreamCountDetail : TeaModel {
                        /// <summary>
                        /// <para>The number of online streams.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        /// <summary>
                        /// <para>The video codec. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>h264</b></description></item>
                        /// <item><description><b>h265</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>h264</para>
                        /// </summary>
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                        /// <summary>
                        /// <para>The video bitrate. This parameter is returned only for transcoded streams.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>390</para>
                        /// </summary>
                        [NameInMap("VideoDataRate")]
                        [Validation(Required=false)]
                        public long? VideoDataRate { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the live stream. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>raw</b>: source streams</description></item>
                /// <item><description><b>trans</b>: transcoded streams</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>raw</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
