// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIElasticDatasetAccelerator20220801.Models
{
    public class ListSlotsRequest : TeaModel {
        /// <summary>
        /// 加速槽所对应的数据集加速挂载点的唯一标识符。
        /// </summary>
        [NameInMap("EndpointIds")]
        [Validation(Required=false)]
        public string EndpointIds { get; set; }

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

        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("SlotIds")]
        [Validation(Required=false)]
        public string SlotIds { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// 数据集加速槽的数据存储路径（URI）。
        /// </summary>
        [NameInMap("StorageUri")]
        [Validation(Required=false)]
        public string StorageUri { get; set; }

    }

}
