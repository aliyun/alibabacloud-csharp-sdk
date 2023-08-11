// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleFlightItemListItemListShoppingItemMapValueCabinQuantityValue : TeaModel {
        [NameInMap("cabin")]
        [Validation(Required=false)]
        public string Cabin { get; set; }

        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        [NameInMap("cabin_class_name")]
        [Validation(Required=false)]
        public string CabinClassName { get; set; }

        [NameInMap("cabin_class_memo")]
        [Validation(Required=false)]
        public string CabinClassMemo { get; set; }

        [NameInMap("specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public string Quantity { get; set; }

        [NameInMap("link_cabins")]
        [Validation(Required=false)]
        public List<string> LinkCabins { get; set; }

        [NameInMap("reshop_change_cabin")]
        [Validation(Required=false)]
        public bool? ReshopChangeCabin { get; set; }

        [NameInMap("child_cabin_type")]
        [Validation(Required=false)]
        public int? ChildCabinType { get; set; }

        [NameInMap("infant_basic_cabin")]
        [Validation(Required=false)]
        public string InfantBasicCabin { get; set; }

        [NameInMap("inner_cabin_class")]
        [Validation(Required=false)]
        public int? InnerCabinClass { get; set; }

    }

}
