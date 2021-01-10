// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskModelsRequest : TeaModel {
        [NameInMap("DataNode")]
        [Validation(Required=false)]
        public string DataNode { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("RuleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("SelectType")]
        [Validation(Required=false)]
        public string SelectType { get; set; }

        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

    }

}
