// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypns20170620.Models
{
    public class QueryDictDataItemResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryDictDataItemResponseBodyData> Data { get; set; }
        public class QueryDictDataItemResponseBodyData : TeaModel {
            [NameInMap("ClassifyItemCode")]
            [Validation(Required=false)]
            public string ClassifyItemCode { get; set; }

            [NameInMap("ClassifyItemValue")]
            [Validation(Required=false)]
            public string ClassifyItemValue { get; set; }

            [NameInMap("DataItemCode")]
            [Validation(Required=false)]
            public string DataItemCode { get; set; }

            [NameInMap("DataItemOrder")]
            [Validation(Required=false)]
            public int? DataItemOrder { get; set; }

            [NameInMap("DataItemParent")]
            [Validation(Required=false)]
            public string DataItemParent { get; set; }

            [NameInMap("DataItemValue")]
            [Validation(Required=false)]
            public string DataItemValue { get; set; }

            [NameInMap("ItemType")]
            [Validation(Required=false)]
            public int? ItemType { get; set; }

            [NameInMap("SubListData")]
            [Validation(Required=false)]
            public List<QueryDictDataItemResponseBodyDataSubListData> SubListData { get; set; }
            public class QueryDictDataItemResponseBodyDataSubListData : TeaModel {
                [NameInMap("ClassifyItemCode")]
                [Validation(Required=false)]
                public string ClassifyItemCode { get; set; }

                [NameInMap("ClassifyItemValue")]
                [Validation(Required=false)]
                public string ClassifyItemValue { get; set; }

                [NameInMap("DataItemCode")]
                [Validation(Required=false)]
                public string DataItemCode { get; set; }

                [NameInMap("DataItemOrder")]
                [Validation(Required=false)]
                public int? DataItemOrder { get; set; }

                [NameInMap("DataItemParent")]
                [Validation(Required=false)]
                public string DataItemParent { get; set; }

                [NameInMap("DataItemValue")]
                [Validation(Required=false)]
                public string DataItemValue { get; set; }

                [NameInMap("ItemType")]
                [Validation(Required=false)]
                public int? ItemType { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
