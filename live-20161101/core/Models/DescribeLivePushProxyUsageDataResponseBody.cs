// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLivePushProxyUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T21:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PushProxyData")]
        [Validation(Required=false)]
        public DescribeLivePushProxyUsageDataResponseBodyPushProxyData PushProxyData { get; set; }
        public class DescribeLivePushProxyUsageDataResponseBodyPushProxyData : TeaModel {
            [NameInMap("PushProxyDataItem")]
            [Validation(Required=false)]
            public List<DescribeLivePushProxyUsageDataResponseBodyPushProxyDataPushProxyDataItem> PushProxyDataItem { get; set; }
            public class DescribeLivePushProxyUsageDataResponseBodyPushProxyDataPushProxyDataItem : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("StreamCount")]
                [Validation(Required=false)]
                public long? StreamCount { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B460F8B-993C-4F48-B98A-910811DEBFEB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-10T20:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
