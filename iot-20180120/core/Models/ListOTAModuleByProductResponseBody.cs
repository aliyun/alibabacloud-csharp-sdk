// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListOTAModuleByProductResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListOTAModuleByProductResponseBodyData> Data { get; set; }
        public class ListOTAModuleByProductResponseBodyData : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

        }

    }

}
