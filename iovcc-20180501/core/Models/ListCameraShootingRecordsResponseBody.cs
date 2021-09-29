// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListCameraShootingRecordsResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShootingRecords")]
        [Validation(Required=false)]
        public ListCameraShootingRecordsResponseBodyShootingRecords ShootingRecords { get; set; }
        public class ListCameraShootingRecordsResponseBodyShootingRecords : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListCameraShootingRecordsResponseBodyShootingRecordsPagination Pagination { get; set; }
            public class ListCameraShootingRecordsResponseBodyShootingRecordsPagination : TeaModel {
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public long? TotalPageCount { get; set; }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

            }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCameraShootingRecordsResponseBodyShootingRecordsList> List { get; set; }
            public class ListCameraShootingRecordsResponseBodyShootingRecordsList : TeaModel {
                public long? Id { get; set; }
                public long? ShootingType { get; set; }
                public long? Number { get; set; }
                public long? Time { get; set; }
                public long? RecordTime { get; set; }
                public long? Status { get; set; }
            }
        };

    }

}
