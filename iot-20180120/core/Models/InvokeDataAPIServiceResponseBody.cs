// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class InvokeDataAPIServiceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public InvokeDataAPIServiceResponseBodyData Data { get; set; }
        public class InvokeDataAPIServiceResponseBodyData : TeaModel {
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public InvokeDataAPIServiceResponseBodyDataResultList ResultList { get; set; }
            public class InvokeDataAPIServiceResponseBodyDataResultList : TeaModel {
                [NameInMap("ResultList")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> ResultList { get; set; }

            }
            [NameInMap("ApiSrn")]
            [Validation(Required=false)]
            public string ApiSrn { get; set; }
            [NameInMap("FieldNameList")]
            [Validation(Required=false)]
            public InvokeDataAPIServiceResponseBodyDataFieldNameList FieldNameList { get; set; }
            public class InvokeDataAPIServiceResponseBodyDataFieldNameList : TeaModel {
                [NameInMap("FieldNameList")]
                [Validation(Required=false)]
                public List<string> FieldNameList { get; set; }

            }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
