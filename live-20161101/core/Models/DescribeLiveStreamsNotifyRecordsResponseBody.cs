// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsNotifyRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The stream ingest callback records.</para>
        /// </summary>
        [NameInMap("NotifyRecordsInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfo NotifyRecordsInfo { get; set; }
        public class DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfo : TeaModel {
            [NameInMap("LiveStreamNotifyRecordsInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfoLiveStreamNotifyRecordsInfo> LiveStreamNotifyRecordsInfo { get; set; }
            public class DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfoLiveStreamNotifyRecordsInfo : TeaModel {
                /// <summary>
                /// <para>The name of the application to which the live stream belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The result of the request. If success is returned, the request is successful. If an error message is returned, the request failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ingest domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>push.example1.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The callback content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;action\&quot;:\&quot;publish_done\&quot;,\&quot;app\&quot;:\&quot;push.example1.com\&quot;}</para>
                /// </summary>
                [NameInMap("NotifyContent")]
                [Validation(Required=false)]
                public string NotifyContent { get; set; }

                /// <summary>
                /// <para>The callback result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success</description></item>
                /// <item><description>failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("NotifyResult")]
                [Validation(Required=false)]
                public string NotifyResult { get; set; }

                /// <summary>
                /// <para>The time when the callback was invoked. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-19T19:09:28Z</para>
                /// </summary>
                [NameInMap("NotifyTime")]
                [Validation(Required=false)]
                public string NotifyTime { get; set; }

                /// <summary>
                /// <para>The event. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>publish: The stream ingest starts.</description></item>
                /// <item><description>publish_done: The stream ingest is interrupted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>publish_done</para>
                /// </summary>
                [NameInMap("NotifyType")]
                [Validation(Required=false)]
                public string NotifyType { get; set; }

                /// <summary>
                /// <para>The callback URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xx.xx.xx.xx/callbacks">http://xx.xx.xx.xx/callbacks</a></para>
                /// </summary>
                [NameInMap("NotifyUrl")]
                [Validation(Required=false)]
                public string NotifyUrl { get; set; }

                /// <summary>
                /// <para>The name of the live stream.</para>
                /// 
                /// <b>Example:</b>
                /// <para>stream</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F675E4B4-125D-1533-901B-11A724644285</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
