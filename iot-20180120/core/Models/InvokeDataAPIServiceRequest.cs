// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class InvokeDataAPIServiceRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("ApiSrn")]
        [Validation(Required=false)]
        public string ApiSrn { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Param")]
        [Validation(Required=false)]
        public List<InvokeDataAPIServiceRequestParam> Param { get; set; }
        public class InvokeDataAPIServiceRequestParam : TeaModel {
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

            [NameInMap("ListParamType")]
            [Validation(Required=false)]
            public string ListParamType { get; set; }

            [NameInMap("ListParamValue")]
            [Validation(Required=false)]
            public List<string> ListParamValue { get; set; }

        }

    }

}
