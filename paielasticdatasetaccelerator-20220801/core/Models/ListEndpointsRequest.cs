// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListEndpointsRequest : TeaModel {
        [NameInMap("EndpointIds")]
        [Validation(Required=false)]
        public string EndpointIds { get; set; }

        /// <summary>
        /// 所属加速实例的ID。
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SlotIds")]
        [Validation(Required=false)]
        public string SlotIds { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
