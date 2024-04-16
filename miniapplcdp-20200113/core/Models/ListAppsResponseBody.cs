// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Miniapplcdp20200113.Models
{
    public class ListAppsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAppsResponseBodyData Data { get; set; }
        public class ListAppsResponseBodyData : TeaModel {
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListAppsResponseBodyDataItems> Items { get; set; }
            public class ListAppsResponseBodyDataItems : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppStatus")]
                [Validation(Required=false)]
                public string AppStatus { get; set; }

                [NameInMap("AppType")]
                [Validation(Required=false)]
                public string AppType { get; set; }

                [NameInMap("Categories")]
                [Validation(Required=false)]
                public List<ListAppsResponseBodyDataItemsCategories> Categories { get; set; }
                public class ListAppsResponseBodyDataItemsCategories : TeaModel {
                    [NameInMap("CategoryId")]
                    [Validation(Required=false)]
                    public string CategoryId { get; set; }

                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    [NameInMap("ParentCategoryId")]
                    [Validation(Required=false)]
                    public string ParentCategoryId { get; set; }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public bool? IsTemplate { get; set; }

                [NameInMap("LastEditTime")]
                [Validation(Required=false)]
                public string LastEditTime { get; set; }

                [NameInMap("MainModuleId")]
                [Validation(Required=false)]
                public string MainModuleId { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("PlatformVersion")]
                [Validation(Required=false)]
                public string PlatformVersion { get; set; }

                [NameInMap("SchemaVersion")]
                [Validation(Required=false)]
                public string SchemaVersion { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
