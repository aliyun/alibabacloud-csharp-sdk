// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListStreamingDataSourcesResponseBody : TeaModel {
        [NameInMap("DataSourceItems")]
        [Validation(Required=false)]
        public List<ListStreamingDataSourcesResponseBodyDataSourceItems> DataSourceItems { get; set; }
        public class ListStreamingDataSourcesResponseBodyDataSourceItems : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataSourceConfig")]
            [Validation(Required=false)]
            public string DataSourceConfig { get; set; }

            [NameInMap("DataSourceDescription")]
            [Validation(Required=false)]
            public string DataSourceDescription { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public int? ServiceId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
