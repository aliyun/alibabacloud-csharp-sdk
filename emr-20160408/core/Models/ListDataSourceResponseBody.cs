// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListDataSourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("DataSourceList")]
        [Validation(Required=false)]
        public ListDataSourceResponseBodyDataSourceList DataSourceList { get; set; }
        public class ListDataSourceResponseBodyDataSourceList : TeaModel {
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public List<ListDataSourceResponseBodyDataSourceListDataSource> DataSource { get; set; }
            public class ListDataSourceResponseBodyDataSourceListDataSource : TeaModel {
                public string Status { get; set; }
                public string Conf { get; set; }
                public string SourceType { get; set; }
                public long? GmtModified { get; set; }
                public string Creator { get; set; }
                public string Modifier { get; set; }
                public string Description { get; set; }
                public long? GmtCreate { get; set; }
                public string CreateFrom { get; set; }
                public string Name { get; set; }
                public string Id { get; set; }
                public string ClusterId { get; set; }
            }
        };

    }

}
