// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetCreativeInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCreativeInfoResponseBodyData Data { get; set; }
        public class GetCreativeInfoResponseBodyData : TeaModel {
            [NameInMap("AccountNo")]
            [Validation(Required=false)]
            public string AccountNo { get; set; }

            [NameInMap("ChainValue")]
            [Validation(Required=false)]
            public string ChainValue { get; set; }

            [NameInMap("ComponentIdList")]
            [Validation(Required=false)]
            public string ComponentIdList { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("MainId")]
            [Validation(Required=false)]
            public long? MainId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("UrlType")]
            [Validation(Required=false)]
            public string UrlType { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
