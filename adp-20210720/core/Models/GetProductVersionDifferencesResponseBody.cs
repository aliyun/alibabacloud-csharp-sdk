// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetProductVersionDifferencesResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetProductVersionDifferencesResponseBodyData> Data { get; set; }
        public class GetProductVersionDifferencesResponseBodyData : TeaModel {
            [NameInMap("componentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            [NameInMap("difference")]
            [Validation(Required=false)]
            public string Difference { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("preVersion")]
            [Validation(Required=false)]
            public string PreVersion { get; set; }

            [NameInMap("releaseName")]
            [Validation(Required=false)]
            public string ReleaseName { get; set; }

            [NameInMap("upgradeFlag")]
            [Validation(Required=false)]
            public bool? UpgradeFlag { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
