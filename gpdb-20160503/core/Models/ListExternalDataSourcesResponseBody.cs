// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListExternalDataSourcesResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListExternalDataSourcesResponseBodyItems> Items { get; set; }
        public class ListExternalDataSourcesResponseBodyItems : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataSourceDescription")]
            [Validation(Required=false)]
            public string DataSourceDescription { get; set; }

            [NameInMap("DataSourceDir")]
            [Validation(Required=false)]
            public string DataSourceDir { get; set; }

            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("DataSourceStatus")]
            [Validation(Required=false)]
            public string DataSourceStatus { get; set; }

            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            [NameInMap("ExternalDataServiceId")]
            [Validation(Required=false)]
            public int? ExternalDataServiceId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

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
