// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetOSSStatisResponseBody : TeaModel {
        [NameInMap("MaxStorageUtilization")]
        [Validation(Required=false)]
        public long? MaxStorageUtilization { get; set; }

        [NameInMap("OssStatisList")]
        [Validation(Required=false)]
        public GetOSSStatisResponseBodyOssStatisList OssStatisList { get; set; }
        public class GetOSSStatisResponseBodyOssStatisList : TeaModel {
            [NameInMap("OSSMetric")]
            [Validation(Required=false)]
            public List<GetOSSStatisResponseBodyOssStatisListOSSMetric> OSSMetric { get; set; }
            public class GetOSSStatisResponseBodyOssStatisListOSSMetric : TeaModel {
                [NameInMap("StatTime")]
                [Validation(Required=false)]
                public string StatTime { get; set; }

                [NameInMap("StatTimeUTC")]
                [Validation(Required=false)]
                public string StatTimeUTC { get; set; }

                [NameInMap("StorageUtilization")]
                [Validation(Required=false)]
                public long? StorageUtilization { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
