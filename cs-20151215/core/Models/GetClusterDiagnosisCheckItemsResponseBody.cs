// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterDiagnosisCheckItemsResponseBody : TeaModel {
        [NameInMap("check_items")]
        [Validation(Required=false)]
        public List<GetClusterDiagnosisCheckItemsResponseBodyCheckItems> CheckItems { get; set; }
        public class GetClusterDiagnosisCheckItemsResponseBodyCheckItems : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("display")]
            [Validation(Required=false)]
            public string Display { get; set; }

            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("refer")]
            [Validation(Required=false)]
            public string Refer { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("is_success")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
