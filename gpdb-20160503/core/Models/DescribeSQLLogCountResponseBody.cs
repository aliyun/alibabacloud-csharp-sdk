// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogCountResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSQLLogCountResponseBodyItems> Items { get; set; }
        public class DescribeSQLLogCountResponseBodyItems : TeaModel {
            [NameInMap("Series")]
            [Validation(Required=false)]
            public List<DescribeSQLLogCountResponseBodyItemsSeries> Series { get; set; }
            public class DescribeSQLLogCountResponseBodyItemsSeries : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<DescribeSQLLogCountResponseBodyItemsSeriesValues> Values { get; set; }
                public class DescribeSQLLogCountResponseBodyItemsSeriesValues : TeaModel {
                    [NameInMap("Point")]
                    [Validation(Required=false)]
                    public List<string> Point { get; set; }

                }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
