// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AllCasDatabaseEngineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<AllCasDatabaseEngineResponseBodyData> Data { get; set; }
        public class AllCasDatabaseEngineResponseBodyData : TeaModel {
            [NameInMap("IaasType")]
            [Validation(Required=false)]
            public string IaasType { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineVersions")]
            [Validation(Required=false)]
            public List<string> EngineVersions { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
