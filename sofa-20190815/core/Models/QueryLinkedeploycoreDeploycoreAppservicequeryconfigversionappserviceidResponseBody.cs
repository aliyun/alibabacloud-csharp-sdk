// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkedeploycoreDeploycoreAppservicequeryconfigversionappserviceidResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryLinkedeploycoreDeploycoreAppservicequeryconfigversionappserviceidResponseBodyData> Data { get; set; }
        public class QueryLinkedeploycoreDeploycoreAppservicequeryconfigversionappserviceidResponseBodyData : TeaModel {
            [NameInMap("AppServiceId")]
            [Validation(Required=false)]
            public long? AppServiceId { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("ConfigId")]
            [Validation(Required=false)]
            public long? ConfigId { get; set; }

            [NameInMap("ConfigStatus")]
            [Validation(Required=false)]
            public string ConfigStatus { get; set; }

            [NameInMap("ConfigVersion")]
            [Validation(Required=false)]
            public string ConfigVersion { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

        }

    }

}
