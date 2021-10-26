// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateProductSpecsRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("IsHide")]
        [Validation(Required=false)]
        public bool? IsHide { get; set; }

        [NameInMap("Unit")]
        [Validation(Required=false)]
        public int? Unit { get; set; }

        [NameInMap("RpsValue")]
        [Validation(Required=false)]
        public long? RpsValue { get; set; }

        [NameInMap("QuotaValue")]
        [Validation(Required=false)]
        public long? QuotaValue { get; set; }

        [NameInMap("LifeCycle")]
        [Validation(Required=false)]
        public int? LifeCycle { get; set; }

    }

}
