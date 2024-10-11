// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodStorageDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The time granularity at which the data was queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>hour</b></description></item>
        /// <item><description><b>day</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-****-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage usage data returned.</para>
        /// </summary>
        [NameInMap("StorageData")]
        [Validation(Required=false)]
        public DescribeVodStorageDataResponseBodyStorageData StorageData { get; set; }
        public class DescribeVodStorageDataResponseBodyStorageData : TeaModel {
            [NameInMap("StorageDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodStorageDataResponseBodyStorageDataStorageDataItem> StorageDataItem { get; set; }
            public class DescribeVodStorageDataResponseBodyStorageDataStorageDataItem : TeaModel {
                /// <summary>
                /// <para>The outbound traffic. Unit: bytes. The outbound traffic is generated when videos are directly downloaded or played from OSS buckets without Alibaba Cloud CDN acceleration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111</para>
                /// </summary>
                [NameInMap("NetworkOut")]
                [Validation(Required=false)]
                public string NetworkOut { get; set; }

                /// <summary>
                /// <para>The detailed usage data of storage-related resources. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111</para>
                /// </summary>
                [NameInMap("StorageUtilization")]
                [Validation(Required=false)]
                public string StorageUtilization { get; set; }

                /// <summary>
                /// <para>The timestamp of the returned data. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-01T15:00:00Z</para>
                /// </summary>
                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
