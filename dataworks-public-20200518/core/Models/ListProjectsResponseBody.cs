// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListProjectsResponseBody : TeaModel {
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListProjectsResponseBodyPageResult PageResult { get; set; }
        public class ListProjectsResponseBodyPageResult : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("ProjectList")]
            [Validation(Required=false)]
            public List<ListProjectsResponseBodyPageResultProjectList> ProjectList { get; set; }
            public class ListProjectsResponseBodyPageResultProjectList : TeaModel {
                [NameInMap("DisableDevelopment")]
                [Validation(Required=false)]
                public bool? DisableDevelopment { get; set; }

                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public int? IsDefault { get; set; }

                [NameInMap("ProjectDescription")]
                [Validation(Required=false)]
                public string ProjectDescription { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("ProjectIdentifier")]
                [Validation(Required=false)]
                public string ProjectIdentifier { get; set; }

                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                [NameInMap("ProjectOwnerBaseId")]
                [Validation(Required=false)]
                public string ProjectOwnerBaseId { get; set; }

                [NameInMap("ProjectStatus")]
                [Validation(Required=false)]
                public int? ProjectStatus { get; set; }

                [NameInMap("ProjectStatusCode")]
                [Validation(Required=false)]
                public string ProjectStatusCode { get; set; }

                [NameInMap("ResourceManagerResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceManagerResourceGroupId { get; set; }

                [NameInMap("TablePrivacyMode")]
                [Validation(Required=false)]
                public int? TablePrivacyMode { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListProjectsResponseBodyPageResultProjectListTags> Tags { get; set; }
                public class ListProjectsResponseBodyPageResultProjectListTags : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("UseProxyOdpsAccount")]
                [Validation(Required=false)]
                public bool? UseProxyOdpsAccount { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
