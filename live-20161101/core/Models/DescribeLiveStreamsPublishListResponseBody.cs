// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsPublishListResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

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
        /// <para>The information about the stream ingest records.</para>
        /// </summary>
        [NameInMap("PublishInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsPublishListResponseBodyPublishInfo PublishInfo { get; set; }
        public class DescribeLiveStreamsPublishListResponseBodyPublishInfo : TeaModel {
            [NameInMap("LiveStreamPublishInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo> LiveStreamPublishInfo { get; set; }
            public class DescribeLiveStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo : TeaModel {
                /// <summary>
                /// <para>Internal error</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000001</para>
                /// </summary>
                [NameInMap("AliInnerErrorFlags")]
                [Validation(Required=false)]
                public string AliInnerErrorFlags { get; set; }

                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The IP address of the client that ingested the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.175.XX.XX</para>
                /// </summary>
                [NameInMap("ClientAddr")]
                [Validation(Required=false)]
                public string ClientAddr { get; set; }

                /// <summary>
                /// <para>The ingest domain or main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The IP address of the CDN point of presence (POP) to which the stream was ingested.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.175.XX.XX</para>
                /// </summary>
                [NameInMap("EdgeNodeAddr")]
                [Validation(Required=false)]
                public string EdgeNodeAddr { get; set; }

                /// <summary>
                /// <para>The ingest domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo.aliyundoc.com</para>
                /// </summary>
                [NameInMap("PublishDomain")]
                [Validation(Required=false)]
                public string PublishDomain { get; set; }

                /// <summary>
                /// <para>The time when the stream ingest was started. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-02T03:05:53Z</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <para>The type of the stream ingest. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>edge</b>: edge ingest</description></item>
                /// <item><description><b>center</b>: live center ingest</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>edge</para>
                /// </summary>
                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                /// <summary>
                /// <para>The complete ingest URL.</para>
                /// </summary>
                [NameInMap("PublishUrl")]
                [Validation(Required=false)]
                public string PublishUrl { get; set; }

                /// <summary>
                /// <para>The time when the stream ingest was stopped. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-12-02T03:11:19Z</para>
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveStream****</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The streaming URL.</para>
                /// </summary>
                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

                /// <summary>
                /// <para>The ID of the transcoding template.</para>
                /// <remarks>
                /// <para> This parameter is not returned if the value of the Transcoded parameter is no.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ld</para>
                /// </summary>
                [NameInMap("TranscodeId")]
                [Validation(Required=false)]
                public string TranscodeId { get; set; }

                /// <summary>
                /// <para>Indicates whether the stream was a transcoded stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yes</para>
                /// </summary>
                [NameInMap("Transcoded")]
                [Validation(Required=false)]
                public string Transcoded { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40A4F36D-A7CC-473A-88E7-154F92242566</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
