// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetModuleConfigStatusResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetModuleConfigStatusResponseBodyData Data { get; set; }
        public class GetModuleConfigStatusResponseBodyData : TeaModel {
            [NameInMap("ModuleConfigResults")]
            [Validation(Required=false)]
            public List<GetModuleConfigStatusResponseBodyDataModuleConfigResults> ModuleConfigResults { get; set; }
            public class GetModuleConfigStatusResponseBodyDataModuleConfigResults : TeaModel {
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("Pass")]
                [Validation(Required=false)]
                public bool? Pass { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
