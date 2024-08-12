// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class GetDeviceUpgradeStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDeviceUpgradeStatusResponseBodyData Data { get; set; }
        public class GetDeviceUpgradeStatusResponseBodyData : TeaModel {
            [NameInMap("AppOtaStatusDTOList")]
            [Validation(Required=false)]
            public List<GetDeviceUpgradeStatusResponseBodyDataAppOtaStatusDTOList> AppOtaStatusDTOList { get; set; }
            public class GetDeviceUpgradeStatusResponseBodyDataAppOtaStatusDTOList : TeaModel {
                [NameInMap("BaseVersion")]
                [Validation(Required=false)]
                public string BaseVersion { get; set; }

                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public int? ClientType { get; set; }

                [NameInMap("ClientUid")]
                [Validation(Required=false)]
                public string ClientUid { get; set; }

                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("TargetVersion")]
                [Validation(Required=false)]
                public string TargetVersion { get; set; }

                [NameInMap("TaskUid")]
                [Validation(Required=false)]
                public string TaskUid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
