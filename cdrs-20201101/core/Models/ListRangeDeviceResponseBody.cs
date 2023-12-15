// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListRangeDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRangeDeviceResponseBodyData> Data { get; set; }
        public class ListRangeDeviceResponseBodyData : TeaModel {
            [NameInMap("CorpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            [NameInMap("DataSourceIdName")]
            [Validation(Required=false)]
            public string DataSourceIdName { get; set; }

            [NameInMap("DataSourceIdPoi")]
            [Validation(Required=false)]
            public string DataSourceIdPoi { get; set; }

            [NameInMap("Distance")]
            [Validation(Required=false)]
            public string Distance { get; set; }

            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

            [NameInMap("NearPoi")]
            [Validation(Required=false)]
            public string NearPoi { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
