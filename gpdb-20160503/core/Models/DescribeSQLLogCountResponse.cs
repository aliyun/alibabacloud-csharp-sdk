// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogCountResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=true)]
        public string DBClusterId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=true)]
        public string StartTime { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=true)]
        public string EndTime { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public List<DescribeSQLLogCountResponseItems> Items { get; set; }
        public class DescribeSQLLogCountResponseItems : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("Series")]
            [Validation(Required=true)]
            public List<DescribeSQLLogCountResponseItemsSeries> Series { get; set; }
            public class DescribeSQLLogCountResponseItemsSeries : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=true)]
                public List<DescribeSQLLogCountResponseItemsSeriesValues> Values { get; set; }
                public class DescribeSQLLogCountResponseItemsSeriesValues : TeaModel {
                    [NameInMap("Point")]
                    [Validation(Required=true)]
                    public List<string> Point { get; set; }

                }

            }

        }

    }

}
