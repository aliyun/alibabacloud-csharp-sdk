// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListUserDefineRegionResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code that is returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The additional information that is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The namespaces.
        /// </summary>
        [NameInMap("UserDefineRegionList")]
        [Validation(Required=false)]
        public ListUserDefineRegionResponseBodyUserDefineRegionList UserDefineRegionList { get; set; }
        public class ListUserDefineRegionResponseBodyUserDefineRegionList : TeaModel {
            [NameInMap("UserDefineRegionEntity")]
            [Validation(Required=false)]
            public List<ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity> UserDefineRegionEntity { get; set; }
            public class ListUserDefineRegionResponseBodyUserDefineRegionListUserDefineRegionEntity : TeaModel {
                /// <summary>
                /// The ID of the region to which the namespace belongs.
                /// </summary>
                [NameInMap("BelongRegion")]
                [Validation(Required=false)]
                public string BelongRegion { get; set; }

                /// <summary>
                /// Indicates whether remote debugging is allowed.
                /// </summary>
                [NameInMap("DebugEnable")]
                [Validation(Required=false)]
                public bool? DebugEnable { get; set; }

                /// <summary>
                /// The description of the namespace.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The unique identifier of the namespace.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The type of the registry. Valid values:
                /// 
                /// *   default: shared service registry of Enterprise Distributed Application Service (EDAS)
                /// *   exclusive_mse: Microservices Engine (MSE) Nacos registry
                /// </summary>
                [NameInMap("MseInstanceId")]
                [Validation(Required=false)]
                public string MseInstanceId { get; set; }

                /// <summary>
                /// The ID of the namespace.
                /// 
                /// > The ID cannot be changed after the namespace is created. The ID is in the `Physical region ID:Logical region identifier` format .
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the namespace.
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

                /// <summary>
                /// The ID of the MSE instance.
                /// </summary>
                [NameInMap("RegistryType")]
                [Validation(Required=false)]
                public string RegistryType { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the namespace belongs.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
