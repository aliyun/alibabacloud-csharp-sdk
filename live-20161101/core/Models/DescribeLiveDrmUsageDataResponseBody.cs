// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDrmUsageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The usage of the DRM encryption service at each time interval.</para>
        /// </summary>
        [NameInMap("DrmUsageData")]
        [Validation(Required=false)]
        public DescribeLiveDrmUsageDataResponseBodyDrmUsageData DrmUsageData { get; set; }
        public class DescribeLiveDrmUsageDataResponseBodyDrmUsageData : TeaModel {
            [NameInMap("DataModule")]
            [Validation(Required=false)]
            public List<DescribeLiveDrmUsageDataResponseBodyDrmUsageDataDataModule> DataModule { get; set; }
            public class DescribeLiveDrmUsageDataResponseBodyDrmUsageDataDataModule : TeaModel {
                /// <summary>
                /// <para>The number of times DRM-encrypted live streams are requested.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The domain name. If the value of SplitBy includes domain, the returned data is grouped by domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                /// <summary>
                /// <para>The DRM type. If the value of SplitBy includes drm_type, the returned data is grouped by DRM type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Widevine</para>
                /// </summary>
                [NameInMap("DrmType")]
                [Validation(Required=false)]
                public string DrmType { get; set; }

                /// <summary>
                /// <para>The ID of the region. If the value of SplitBy includes region, the returned data is grouped by region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-01T16:00:00Z</para>
                /// </summary>
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
