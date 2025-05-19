// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class ListMyGroupsResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public ListMyGroupsResponseBodyResources Resources { get; set; }
        public class ListMyGroupsResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<ListMyGroupsResponseBodyResourcesResource> Resource { get; set; }
            public class ListMyGroupsResponseBodyResourcesResource : TeaModel {
                [NameInMap("BindUrl")]
                [Validation(Required=false)]
                public string BindUrl { get; set; }

                [NameInMap("BindUrls")]
                [Validation(Required=false)]
                public string BindUrls { get; set; }

                [NameInMap("ContactGroups")]
                [Validation(Required=false)]
                public ListMyGroupsResponseBodyResourcesResourceContactGroups ContactGroups { get; set; }
                public class ListMyGroupsResponseBodyResourcesResourceContactGroups : TeaModel {
                    [NameInMap("ContactGroup")]
                    [Validation(Required=false)]
                    public List<ListMyGroupsResponseBodyResourcesResourceContactGroupsContactGroup> ContactGroup { get; set; }
                    public class ListMyGroupsResponseBodyResourcesResourceContactGroupsContactGroup : TeaModel {
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
