// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class QueryContentInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryContentInfoResponseBodyData Data { get; set; }
        public class QueryContentInfoResponseBodyData : TeaModel {
            [NameInMap("BrandUserId")]
            [Validation(Required=false)]
            public long? BrandUserId { get; set; }
            [NameInMap("ChainValue")]
            [Validation(Required=false)]
            public string ChainValue { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("OpenScene")]
            [Validation(Required=false)]
            public int? OpenScene { get; set; }
            [NameInMap("ProxyUserId")]
            [Validation(Required=false)]
            public long? ProxyUserId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }
        };

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
