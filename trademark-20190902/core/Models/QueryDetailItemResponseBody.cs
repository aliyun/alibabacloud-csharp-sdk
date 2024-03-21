// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class QueryDetailItemResponseBody : TeaModel {
        [NameInMap("Module")]
        [Validation(Required=false)]
        public QueryDetailItemResponseBodyModule Module { get; set; }
        public class QueryDetailItemResponseBodyModule : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public QueryDetailItemResponseBodyModuleAttributes Attributes { get; set; }
            public class QueryDetailItemResponseBodyModuleAttributes : TeaModel {
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public List<QueryDetailItemResponseBodyModuleAttributesAttribute> Attribute { get; set; }
                public class QueryDetailItemResponseBodyModuleAttributesAttribute : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("DetailDescription")]
            [Validation(Required=false)]
            public string DetailDescription { get; set; }

            [NameInMap("DetailObjectJson")]
            [Validation(Required=false)]
            public string DetailObjectJson { get; set; }

            [NameInMap("DetailPagePicUrl")]
            [Validation(Required=false)]
            public string DetailPagePicUrl { get; set; }

            [NameInMap("DetailPicUrl")]
            [Validation(Required=false)]
            public QueryDetailItemResponseBodyModuleDetailPicUrl DetailPicUrl { get; set; }
            public class QueryDetailItemResponseBodyModuleDetailPicUrl : TeaModel {
                [NameInMap("picUlr")]
                [Validation(Required=false)]
                public List<string> PicUlr { get; set; }

            }

            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("MainPicUrl")]
            [Validation(Required=false)]
            public string MainPicUrl { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
