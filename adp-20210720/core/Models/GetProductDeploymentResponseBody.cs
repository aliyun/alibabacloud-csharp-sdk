// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetProductDeploymentResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProductDeploymentResponseBodyData Data { get; set; }
        public class GetProductDeploymentResponseBodyData : TeaModel {
            [NameInMap("envParams")]
            [Validation(Required=false)]
            public string EnvParams { get; set; }

            [NameInMap("envUID")]
            [Validation(Required=false)]
            public string EnvUID { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
