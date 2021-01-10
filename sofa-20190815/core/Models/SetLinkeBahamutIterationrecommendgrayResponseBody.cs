// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SetLinkeBahamutIterationrecommendgrayResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<SetLinkeBahamutIterationrecommendgrayResponseBodyResult> Result { get; set; }
        public class SetLinkeBahamutIterationrecommendgrayResponseBodyResult : TeaModel {
            [NameInMap("ExternalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("GrayAppNames")]
            [Validation(Required=false)]
            public List<string> GrayAppNames { get; set; }

            [NameInMap("GrayCodeNames")]
            [Validation(Required=false)]
            public List<string> GrayCodeNames { get; set; }

            [NameInMap("ReleaseIterationUnitList")]
            [Validation(Required=false)]
            public List<string> ReleaseIterationUnitList { get; set; }

            [NameInMap("UnitsNotReady")]
            [Validation(Required=false)]
            public List<string> UnitsNotReady { get; set; }

        }

    }

}
