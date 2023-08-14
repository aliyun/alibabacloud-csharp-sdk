// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudcontrol20220830.Models
{
    public class ListResourceTypesResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resourceTypes")]
        [Validation(Required=false)]
        public List<ListResourceTypesResponseBodyResourceTypes> ResourceTypes { get; set; }
        public class ListResourceTypesResponseBodyResourceTypes : TeaModel {
            [NameInMap("createOnlyProperties")]
            [Validation(Required=false)]
            public List<string> CreateOnlyProperties { get; set; }

            [NameInMap("deleteOnlyProperties")]
            [Validation(Required=false)]
            public List<string> DeleteOnlyProperties { get; set; }

            [NameInMap("filterProperties")]
            [Validation(Required=false)]
            public List<string> FilterProperties { get; set; }

            [NameInMap("getOnlyProperties")]
            [Validation(Required=false)]
            public List<string> GetOnlyProperties { get; set; }

            [NameInMap("getResponseProperties")]
            [Validation(Required=false)]
            public List<string> GetResponseProperties { get; set; }

            [NameInMap("handlers")]
            [Validation(Required=false)]
            public ListResourceTypesResponseBodyResourceTypesHandlers Handlers { get; set; }
            public class ListResourceTypesResponseBodyResourceTypesHandlers : TeaModel {
                [NameInMap("create")]
                [Validation(Required=false)]
                public ListResourceTypesResponseBodyResourceTypesHandlersCreate Create { get; set; }
                public class ListResourceTypesResponseBodyResourceTypesHandlersCreate : TeaModel {
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                [NameInMap("delete")]
                [Validation(Required=false)]
                public ListResourceTypesResponseBodyResourceTypesHandlersDelete Delete { get; set; }
                public class ListResourceTypesResponseBodyResourceTypesHandlersDelete : TeaModel {
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                [NameInMap("get")]
                [Validation(Required=false)]
                public ListResourceTypesResponseBodyResourceTypesHandlersGet Get { get; set; }
                public class ListResourceTypesResponseBodyResourceTypesHandlersGet : TeaModel {
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                [NameInMap("list")]
                [Validation(Required=false)]
                public ListResourceTypesResponseBodyResourceTypesHandlersList List { get; set; }
                public class ListResourceTypesResponseBodyResourceTypesHandlersList : TeaModel {
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

                [NameInMap("update")]
                [Validation(Required=false)]
                public ListResourceTypesResponseBodyResourceTypesHandlersUpdate Update { get; set; }
                public class ListResourceTypesResponseBodyResourceTypesHandlersUpdate : TeaModel {
                    [NameInMap("permissions")]
                    [Validation(Required=false)]
                    public List<string> Permissions { get; set; }

                }

            }

            [NameInMap("info")]
            [Validation(Required=false)]
            public ListResourceTypesResponseBodyResourceTypesInfo Info { get; set; }
            public class ListResourceTypesResponseBodyResourceTypesInfo : TeaModel {
                [NameInMap("chargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("deliveryScope")]
                [Validation(Required=false)]
                public string DeliveryScope { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("listOnlyProperties")]
            [Validation(Required=false)]
            public List<string> ListOnlyProperties { get; set; }

            [NameInMap("listResponseProperties")]
            [Validation(Required=false)]
            public List<string> ListResponseProperties { get; set; }

            [NameInMap("primaryIdentifier")]
            [Validation(Required=false)]
            public string PrimaryIdentifier { get; set; }

            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            [NameInMap("publicProperties")]
            [Validation(Required=false)]
            public List<string> PublicProperties { get; set; }

            [NameInMap("readOnlyProperties")]
            [Validation(Required=false)]
            public List<string> ReadOnlyProperties { get; set; }

            [NameInMap("required")]
            [Validation(Required=false)]
            public List<string> Required { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("sensitiveInfoProperties")]
            [Validation(Required=false)]
            public List<string> SensitiveInfoProperties { get; set; }

            [NameInMap("updateOnlyProperties")]
            [Validation(Required=false)]
            public List<string> UpdateOnlyProperties { get; set; }

            [NameInMap("updateTypeProperties")]
            [Validation(Required=false)]
            public List<string> UpdateTypeProperties { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
