// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeSQLLogTemplatesResponseBody : TeaModel {
        [NameInMap("ItemsNumbers")]
        [Validation(Required=false)]
        public int? ItemsNumbers { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("MaxRecordsPerPage")]
        [Validation(Required=false)]
        public int? MaxRecordsPerPage { get; set; }

        [NameInMap("DBInstanceID")]
        [Validation(Required=false)]
        public int? DBInstanceID { get; set; }

        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSQLLogTemplatesResponseBodyItems Items { get; set; }
        public class DescribeSQLLogTemplatesResponseBodyItems : TeaModel {
            [NameInMap("Template")]
            [Validation(Required=false)]
            public List<DescribeSQLLogTemplatesResponseBodyItemsTemplate> Template { get; set; }
            public class DescribeSQLLogTemplatesResponseBodyItemsTemplate : TeaModel {
                public long? TotalConsume { get; set; }
                public float? AvgUpdateRows { get; set; }
                public long? TotalScanRows { get; set; }
                public string Template { get; set; }
                public string TemplateHash { get; set; }
                public int? ItemID { get; set; }
                public long? TotalUpdateRows { get; set; }
                public long? TotalCounts { get; set; }
                public float? AvgScanRows { get; set; }
                public string SqlType { get; set; }
                public float? AvgConsume { get; set; }
            }
        };

        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        [NameInMap("Finish")]
        [Validation(Required=false)]
        public string Finish { get; set; }

        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        [NameInMap("PagingID")]
        [Validation(Required=false)]
        public string PagingID { get; set; }

    }

}
