// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsOnlineListResponseBody : TeaModel {
        [NameInMap("OnlineInfo")]
        [Validation(Required=false)]
        public DescribeVsStreamsOnlineListResponseBodyOnlineInfo OnlineInfo { get; set; }
        public class DescribeVsStreamsOnlineListResponseBodyOnlineInfo : TeaModel {
            [NameInMap("LiveStreamOnlineInfo")]
            [Validation(Required=false)]
            public List<DescribeVsStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo> LiveStreamOnlineInfo { get; set; }
            public class DescribeVsStreamsOnlineListResponseBodyOnlineInfoLiveStreamOnlineInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxApp</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>push.example.com</para>
                /// </summary>
                [NameInMap("PublishDomain")]
                [Validation(Required=false)]
                public string PublishDomain { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2015-12-02T06:58:04Z</para>
                /// </summary>
                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>edge</para>
                /// </summary>
                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rtmp://example.com/xchen</para>
                /// </summary>
                [NameInMap("PublishUrl")]
                [Validation(Required=false)]
                public string PublishUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testxchen_small</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("TranscodeId")]
                [Validation(Required=false)]
                public string TranscodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>no</para>
                /// </summary>
                [NameInMap("Transcoded")]
                [Validation(Required=false)]
                public string Transcoded { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B31FC4AD-3592-573E-8063-878F722B322A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
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
