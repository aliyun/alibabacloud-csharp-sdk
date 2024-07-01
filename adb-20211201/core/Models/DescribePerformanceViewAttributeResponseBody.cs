// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePerformanceViewAttributeResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("CreateFromViewType")]
        [Validation(Required=false)]
        public string CreateFromViewType { get; set; }

        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("FillOriginViewKeys")]
        [Validation(Required=false)]
        public bool? FillOriginViewKeys { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ViewDetail")]
        [Validation(Required=false)]
        public DescribePerformanceViewAttributeResponseBodyViewDetail ViewDetail { get; set; }
        public class DescribePerformanceViewAttributeResponseBodyViewDetail : TeaModel {
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<DescribePerformanceViewAttributeResponseBodyViewDetailCategories> Categories { get; set; }
            public class DescribePerformanceViewAttributeResponseBodyViewDetailCategories : TeaModel {
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<DescribePerformanceViewAttributeResponseBodyViewDetailCategoriesKeys> Keys { get; set; }
                public class DescribePerformanceViewAttributeResponseBodyViewDetailCategoriesKeys : TeaModel {
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    [NameInMap("Selected")]
                    [Validation(Required=false)]
                    public bool? Selected { get; set; }

                }

            }

            [NameInMap("ChartLinked")]
            [Validation(Required=false)]
            public bool? ChartLinked { get; set; }

            [NameInMap("ChartsPerLine")]
            [Validation(Required=false)]
            public int? ChartsPerLine { get; set; }

        }

        [NameInMap("ViewName")]
        [Validation(Required=false)]
        public string ViewName { get; set; }

    }

}
