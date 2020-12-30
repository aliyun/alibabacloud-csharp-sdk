// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeCategoriesResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Categories")]
        [Validation(Required=false)]
        public DescribeCategoriesResponseBodyCategories Categories { get; set; }
        public class DescribeCategoriesResponseBodyCategories : TeaModel {
            [NameInMap("Category")]
            [Validation(Required=false)]
            public List<DescribeCategoriesResponseBodyCategoriesCategory> Category { get; set; }
            public class DescribeCategoriesResponseBodyCategoriesCategory : TeaModel {
                public string CategoryLogo { get; set; }
                public string UpdateTime { get; set; }
                public DescribeCategoriesResponseBodyCategoriesCategoryDemoProjects DemoProjects { get; set; }
                public class DescribeCategoriesResponseBodyCategoriesCategoryDemoProjects : TeaModel {
                    [NameInMap("DemoProject")]
                    [Validation(Required=false)]
                    public List<DescribeCategoriesResponseBodyCategoriesCategoryDemoProjectsDemoProject> DemoProject { get; set; }
                    public class DescribeCategoriesResponseBodyCategoriesCategoryDemoProjectsDemoProject : TeaModel {
                        [NameInMap("SourceUrl")]
                        [Validation(Required=false)]
                        public string SourceUrl { get; set; }

                        [NameInMap("PackageDownloadUrl")]
                        [Validation(Required=false)]
                        public string PackageDownloadUrl { get; set; }

                        [NameInMap("PackageUrl")]
                        [Validation(Required=false)]
                        public string PackageUrl { get; set; }

                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                    }

                }
                public string CreateTime { get; set; }
                public string CategoryId { get; set; }
                public string CategoryName { get; set; }
                public string CategoryDescription { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
