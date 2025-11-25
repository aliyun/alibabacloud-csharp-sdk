// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListComputeResourcesResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListComputeResourcesResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListComputeResourcesResponseBodyPagingInfo : TeaModel {
            [NameInMap("ComputeResources")]
            [Validation(Required=false)]
            public List<ListComputeResourcesResponseBodyPagingInfoComputeResources> ComputeResources { get; set; }
            public class ListComputeResourcesResponseBodyPagingInfoComputeResources : TeaModel {
                [NameInMap("ComputeResource")]
                [Validation(Required=false)]
                public List<ListComputeResourcesResponseBodyPagingInfoComputeResourcesComputeResource> ComputeResource { get; set; }
                public class ListComputeResourcesResponseBodyPagingInfoComputeResourcesComputeResource : TeaModel {
                    [NameInMap("ConnectionProperties")]
                    [Validation(Required=false)]
                    public object ConnectionProperties { get; set; }

                    [NameInMap("ConnectionPropertiesMode")]
                    [Validation(Required=false)]
                    public string ConnectionPropertiesMode { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("CreateUser")]
                    [Validation(Required=false)]
                    public string CreateUser { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public long? ModifyTime { get; set; }

                    [NameInMap("ModifyUser")]
                    [Validation(Required=false)]
                    public string ModifyUser { get; set; }

                    [NameInMap("WhetherDefault")]
                    [Validation(Required=false)]
                    public bool? WhetherDefault { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
