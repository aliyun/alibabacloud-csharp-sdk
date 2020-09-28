// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListLoopParameterTagValuesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TagsValuesRsp")]
        [Validation(Required=true)]
        public ListLoopParameterTagValuesResponseTagsValuesRsp TagsValuesRsp { get; set; }
        public class ListLoopParameterTagValuesResponseTagsValuesRsp : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("DataList")]
            [Validation(Required=true)]
            public ListLoopParameterTagValuesResponseTagsValuesRspDataList DataList { get; set; }
            public class ListLoopParameterTagValuesResponseTagsValuesRspDataList : TeaModel {
                [NameInMap("Op")]
                [Validation(Required=true)]
                public List<ListLoopParameterTagValuesResponseTagsValuesRspDataListOp> Op { get; set; }
                public class ListLoopParameterTagValuesResponseTagsValuesRspDataListOp : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Op1")]
                [Validation(Required=true)]
                public List<ListLoopParameterTagValuesResponseTagsValuesRspDataListOp1> Op1 { get; set; }
                public class ListLoopParameterTagValuesResponseTagsValuesRspDataListOp1 : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Op2")]
                [Validation(Required=true)]
                public List<ListLoopParameterTagValuesResponseTagsValuesRspDataListOp2> Op2 { get; set; }
                public class ListLoopParameterTagValuesResponseTagsValuesRspDataListOp2 : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Sp")]
                [Validation(Required=true)]
                public List<ListLoopParameterTagValuesResponseTagsValuesRspDataListSp> Sp { get; set; }
                public class ListLoopParameterTagValuesResponseTagsValuesRspDataListSp : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

                [NameInMap("Pv")]
                [Validation(Required=true)]
                public List<ListLoopParameterTagValuesResponseTagsValuesRspDataListPv> Pv { get; set; }
                public class ListLoopParameterTagValuesResponseTagsValuesRspDataListPv : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                }

            }
        };

    }

}
