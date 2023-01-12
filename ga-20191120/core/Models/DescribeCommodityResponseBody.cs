// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeCommodityResponseBody : TeaModel {
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("CommodityName")]
        [Validation(Required=false)]
        public string CommodityName { get; set; }

        [NameInMap("Components")]
        [Validation(Required=false)]
        public List<DescribeCommodityResponseBodyComponents> Components { get; set; }
        public class DescribeCommodityResponseBodyComponents : TeaModel {
            [NameInMap("ComponentCode")]
            [Validation(Required=false)]
            public string ComponentCode { get; set; }

            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<DescribeCommodityResponseBodyComponentsProperties> Properties { get; set; }
            public class DescribeCommodityResponseBodyComponentsProperties : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PropertyValueList")]
                [Validation(Required=false)]
                public List<DescribeCommodityResponseBodyComponentsPropertiesPropertyValueList> PropertyValueList { get; set; }
                public class DescribeCommodityResponseBodyComponentsPropertiesPropertyValueList : TeaModel {
                    [NameInMap("OrderIndex")]
                    [Validation(Required=false)]
                    public long? OrderIndex { get; set; }

                    [NameInMap("Text")]
                    [Validation(Required=false)]
                    public string Text { get; set; }

                    [NameInMap("Tips")]
                    [Validation(Required=false)]
                    public string Tips { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
