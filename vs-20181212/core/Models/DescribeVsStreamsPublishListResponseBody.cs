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
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("ClientAddr")]
                [Validation(Required=false)]
                public string ClientAddr { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("EdgeNodeAddr")]
                [Validation(Required=false)]
                public string EdgeNodeAddr { get; set; }

                [NameInMap("PublishDomain")]
                [Validation(Required=false)]
                public string PublishDomain { get; set; }

                [NameInMap("PublishTime")]
                [Validation(Required=false)]
                public string PublishTime { get; set; }

                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                [NameInMap("PublishUrl")]
                [Validation(Required=false)]
                public string PublishUrl { get; set; }

                [NameInMap("StopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                [NameInMap("StreamUrl")]
                [Validation(Required=false)]
                public string StreamUrl { get; set; }

                [NameInMap("TranscodeId")]
                [Validation(Required=false)]
                public string TranscodeId { get; set; }

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
