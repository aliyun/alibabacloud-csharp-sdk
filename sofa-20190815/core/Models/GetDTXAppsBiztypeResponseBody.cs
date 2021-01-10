// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetDTXAppsBiztypeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("StatemachineJson")]
        [Validation(Required=false)]
        public string StatemachineJson { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDTXAppsBiztypeResponseBodyData> Data { get; set; }
        public class GetDTXAppsBiztypeResponseBodyData : TeaModel {
            [NameInMap("ActionMode")]
            [Validation(Required=false)]
            public string ActionMode { get; set; }

            [NameInMap("ActionName")]
            [Validation(Required=false)]
            public string ActionName { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            [NameInMap("Rollback")]
            [Validation(Required=false)]
            public string Rollback { get; set; }

            [NameInMap("WsTr")]
            [Validation(Required=false)]
            public string WsTr { get; set; }

        }

    }

}
