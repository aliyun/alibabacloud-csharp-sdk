// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class InvokeDataAPIServiceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public InvokeDataAPIServiceResponseData Data { get; set; }
        public class InvokeDataAPIServiceResponseData : TeaModel {
            [NameInMap("ApiSrn")]
            [Validation(Required=true)]
            public string ApiSrn { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=true)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }

            [NameInMap("TotalSize")]
            [Validation(Required=true)]
            public int? TotalSize { get; set; }

            [NameInMap("FieldNameList")]
            [Validation(Required=true)]
            public InvokeDataAPIServiceResponseDataFieldNameList FieldNameList { get; set; }
            public class InvokeDataAPIServiceResponseDataFieldNameList : TeaModel {
                /// <summary>
                /// FieldNameList
                /// </summary>
                [NameInMap("FieldNameList")]
                [Validation(Required=true)]
                public List<string> FieldNameList { get; set; }

            }

            [NameInMap("ResultList")]
            [Validation(Required=true)]
            public InvokeDataAPIServiceResponseDataResultList ResultList { get; set; }
            public class InvokeDataAPIServiceResponseDataResultList : TeaModel {
                /// <summary>
                /// ResultList
                /// </summary>
                [NameInMap("ResultList")]
                [Validation(Required=true)]
                public List<Dictionary<string, object>> ResultList { get; set; }

            }

        }

    }

}
