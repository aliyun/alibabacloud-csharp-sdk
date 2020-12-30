// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagManagementPortResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Gateway")]
        [Validation(Required=false)]
        public string Gateway { get; set; }

        [NameInMap("IP")]
        [Validation(Required=false)]
        public string IP { get; set; }

        [NameInMap("Mask")]
        [Validation(Required=false)]
        public string Mask { get; set; }

        [NameInMap("TaskStates")]
        [Validation(Required=false)]
        public List<DescribeSagManagementPortResponseBodyTaskStates> TaskStates { get; set; }
        public class DescribeSagManagementPortResponseBodyTaskStates : TeaModel {
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

        }

    }

}
