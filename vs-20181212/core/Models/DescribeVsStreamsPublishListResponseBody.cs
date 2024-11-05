// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsPublishListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PublishInfo")]
        [Validation(Required=false)]
        public DescribeVsStreamsPublishListResponseBodyPublishInfo PublishInfo { get; set; }
        public class DescribeVsStreamsPublishListResponseBodyPublishInfo : TeaModel {
            [NameInMap("LiveStreamPublishInfo")]
            [Validation(Required=false)]
            public List<DescribeVsStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo> LiveStreamPublishInfo { get; set; }
            public class DescribeVsStreamsPublishListResponseBodyPublishInfoLiveStreamPublishInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxApp</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.0.1</para>
                /// </summary>
                [NameInMap("ClientAddr")]
                [Validation(Required=false)]
                public string ClientAddr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.0.1</para>
                /// </summary>
                [NameInMap("EdgeNodeAddr")]
                [Validation(Required=false)]
                public string EdgeNodeAddr { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("PublishDomain")]
                [Validation(Required=false)]
                public string PublishDomain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2016-06-29T19:00:00Z</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>center</para>
                /// </summary>
                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com/xxxApp/3402000****320000001.m3u8">https://example.aliyundoc.com/xxxApp/3402000****320000001.m3u8</a></para>
                /// </summary>
                [NameInMap("PublishUrl")]
                [Validation(Required=false)]
                public string PublishUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2016-06-29T19:00:00Z</para>
                /// </summary>
                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxStream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com/xxxApp/3402000****320000001.m3u8">https://example.aliyundoc.com/xxxApp/3402000****320000001.m3u8</a></para>
                /// </summary>
                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3888920****8138204-cn-qingdao</para>
                /// </summary>
                [NameInMap("TranscodeId")]
                [Validation(Required=false)]
                public string TranscodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>yes</para>
                /// </summary>
                [NameInMap("Transcoded")]
                [Validation(Required=false)]
                public string Transcoded { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>119F7639-4646-51A4-B6C1-300D391C0104</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
