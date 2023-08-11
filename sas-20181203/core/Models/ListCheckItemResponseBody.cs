// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemResponseBody : TeaModel {
        [NameInMap("CheckItems")]
        [Validation(Required=false)]
        public List<ListCheckItemResponseBodyCheckItems> CheckItems { get; set; }
        public class ListCheckItemResponseBodyCheckItems : TeaModel {
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            [NameInMap("CheckShowName")]
            [Validation(Required=false)]
            public string CheckShowName { get; set; }

            [NameInMap("CustomConfigs")]
            [Validation(Required=false)]
            public List<ListCheckItemResponseBodyCheckItemsCustomConfigs> CustomConfigs { get; set; }
            public class ListCheckItemResponseBodyCheckItemsCustomConfigs : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("ShowName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                [NameInMap("TypeDefine")]
                [Validation(Required=false)]
                public string TypeDefine { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public ListCheckItemResponseBodyCheckItemsDescription Description { get; set; }
            public class ListCheckItemResponseBodyCheckItemsDescription : TeaModel {
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("InstanceSubType")]
            [Validation(Required=false)]
            public string InstanceSubType { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("SectionIds")]
            [Validation(Required=false)]
            public List<long?> SectionIds { get; set; }

            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
