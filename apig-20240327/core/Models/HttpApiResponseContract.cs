// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiResponseContract : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("contentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<HttpApiResponseContractItems> Items { get; set; }
        public class HttpApiResponseContractItems : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public int? Code { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("jsonSchema")]
            [Validation(Required=false)]
            public string JsonSchema { get; set; }

        }

    }

}
