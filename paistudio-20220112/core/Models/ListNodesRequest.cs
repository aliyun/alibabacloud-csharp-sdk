// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListNodesRequest : TeaModel {
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        [NameInMap("FilterByQuotaId")]
        [Validation(Required=false)]
        public string FilterByQuotaId { get; set; }

        [NameInMap("FilterByResourceGroupIds")]
        [Validation(Required=false)]
        public string FilterByResourceGroupIds { get; set; }

        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

        [NameInMap("NodeStatuses")]
        [Validation(Required=false)]
        public string NodeStatuses { get; set; }

        [NameInMap("NodeTypes")]
        [Validation(Required=false)]
        public string NodeTypes { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OrderStatuses")]
        [Validation(Required=false)]
        public string OrderStatuses { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public string ResourceGroupIds { get; set; }

        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        [NameInMap("Verbose")]
        [Validation(Required=false)]
        public bool? Verbose { get; set; }

    }

}
