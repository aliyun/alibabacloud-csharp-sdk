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

        [NameInMap("StorageData")]
        [Validation(Required=false)]
        public DescribeVodStorageDataResponseBodyStorageData StorageData { get; set; }
        public class DescribeVodStorageDataResponseBodyStorageData : TeaModel {
            [NameInMap("StorageDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodStorageDataResponseBodyStorageDataStorageDataItem> StorageDataItem { get; set; }
            public class DescribeVodStorageDataResponseBodyStorageDataStorageDataItem : TeaModel {
                [NameInMap("NetworkOut")]
                [Validation(Required=false)]
                public string NetworkOut { get; set; }

                [NameInMap("StorageUtilization")]
                [Validation(Required=false)]
                public string StorageUtilization { get; set; }

                [NameInMap("TimeStamp")]
                [Validation(Required=false)]
                public string TimeStamp { get; set; }

            }

        }

    }

}
