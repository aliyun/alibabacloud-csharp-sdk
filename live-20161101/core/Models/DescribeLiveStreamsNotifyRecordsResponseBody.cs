// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsNotifyRecordsResponseBody : TeaModel {
        [NameInMap("NotifyRecordsInfo")]
        [Validation(Required=false)]
        public DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfo NotifyRecordsInfo { get; set; }
        public class DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfo : TeaModel {
            [NameInMap("LiveStreamNotifyRecordsInfo")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfoLiveStreamNotifyRecordsInfo> LiveStreamNotifyRecordsInfo { get; set; }
            public class DescribeLiveStreamsNotifyRecordsResponseBodyNotifyRecordsInfoLiveStreamNotifyRecordsInfo : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("NotifyContent")]
                [Validation(Required=false)]
                public string NotifyContent { get; set; }

                [NameInMap("NotifyHeader")]
                [Validation(Required=false)]
                public string NotifyHeader { get; set; }

                [NameInMap("NotifyResponse")]
                [Validation(Required=false)]
                public string NotifyResponse { get; set; }

                [NameInMap("NotifyResult")]
                [Validation(Required=false)]
                public string NotifyResult { get; set; }

                [NameInMap("NotifyTime")]
                [Validation(Required=false)]
                public string NotifyTime { get; set; }

                [NameInMap("NotifyType")]
                [Validation(Required=false)]
                public string NotifyType { get; set; }

                [NameInMap("NotifyUrl")]
                [Validation(Required=false)]
                public string NotifyUrl { get; set; }

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
