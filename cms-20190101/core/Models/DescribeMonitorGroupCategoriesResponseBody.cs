// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorGroupCategoriesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("MonitorGroupCategories")]
        [Validation(Required=false)]
        public DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategories MonitorGroupCategories { get; set; }
        public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategories : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }
            [NameInMap("MonitorGroupCategory")]
            [Validation(Required=false)]
            public DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategory MonitorGroupCategory { get; set; }
            public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategory : TeaModel {
                [NameInMap("CategoryItem")]
                [Validation(Required=false)]
                public List<DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategoryCategoryItem> CategoryItem { get; set; }
                public class DescribeMonitorGroupCategoriesResponseBodyMonitorGroupCategoriesMonitorGroupCategoryCategoryItem : TeaModel {
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                }

            }
        };

    }

}
