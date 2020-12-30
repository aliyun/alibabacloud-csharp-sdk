// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListBasicStatisticsReportSubItemsResponseBody : TeaModel {
        [NameInMap("SubItems")]
        [Validation(Required=false)]
        public ListBasicStatisticsReportSubItemsResponseBodySubItems SubItems { get; set; }
        public class ListBasicStatisticsReportSubItemsResponseBodySubItems : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListBasicStatisticsReportSubItemsResponseBodySubItemsList> List { get; set; }
            public class ListBasicStatisticsReportSubItemsResponseBodySubItemsList : TeaModel {
                public string BasicStatisticsReportSubItemName { get; set; }
                public string Value { get; set; }
                public int? Percentage { get; set; }
                public int? Count { get; set; }
                public List<ListBasicStatisticsReportSubItemsResponseBodySubItemsListRow> Row { get; set; }
                public class ListBasicStatisticsReportSubItemsResponseBodySubItemsListRow : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
