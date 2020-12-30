// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodStorageDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DataInterval")]
        [Validation(Required=false)]
        public string DataInterval { get; set; }

        [NameInMap("StorageData")]
        [Validation(Required=false)]
        public DescribeVodStorageDataResponseBodyStorageData StorageData { get; set; }
        public class DescribeVodStorageDataResponseBodyStorageData : TeaModel {
            [NameInMap("StorageDataItem")]
            [Validation(Required=false)]
            public List<DescribeVodStorageDataResponseBodyStorageDataStorageDataItem> StorageDataItem { get; set; }
            public class DescribeVodStorageDataResponseBodyStorageDataStorageDataItem : TeaModel {
                public string StorageUtilization { get; set; }
                public string TimeStamp { get; set; }
                public string NetworkOut { get; set; }
            }
        };

    }

}
