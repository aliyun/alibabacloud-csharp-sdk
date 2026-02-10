// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDrmUsageDataResponseBody : TeaModel {
        [NameInMap("DrmUsageData")]
        [Validation(Required=false)]
        public DescribeLiveDrmUsageDataResponseBodyDrmUsageData DrmUsageData { get; set; }
        public class DescribeLiveDrmUsageDataResponseBodyDrmUsageData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDrmUsageDataResponseBodyDrmUsageDataDataModule> DataModule { get; set; }
            public class DescribeLiveDrmUsageDataResponseBodyDrmUsageDataDataModule : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("DrmType")]
                [Validation(Required=false)]
                public string DrmType { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91FC2D9D-B042-4634-8A5C-7B8E7482C22D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
