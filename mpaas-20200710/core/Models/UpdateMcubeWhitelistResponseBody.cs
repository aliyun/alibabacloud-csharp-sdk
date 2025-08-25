// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class UpdateMcubeWhitelistResponseBody : TeaModel {
        [NameInMap("AddWhitelistResult")]
        [Validation(Required=false)]
        public UpdateMcubeWhitelistResponseBodyAddWhitelistResult AddWhitelistResult { get; set; }
        public class UpdateMcubeWhitelistResponseBodyAddWhitelistResult : TeaModel {
            [NameInMap("AddWhitelistInfo")]
            [Validation(Required=false)]
            public UpdateMcubeWhitelistResponseBodyAddWhitelistResultAddWhitelistInfo AddWhitelistInfo { get; set; }
            public class UpdateMcubeWhitelistResponseBodyAddWhitelistResultAddWhitelistInfo : TeaModel {
                [NameInMap("FailNum")]
                [Validation(Required=false)]
                public long? FailNum { get; set; }

                [NameInMap("FailUserIds")]
                [Validation(Required=false)]
                public string FailUserIds { get; set; }

                [NameInMap("SuccessNum")]
                [Validation(Required=false)]
                public long? SuccessNum { get; set; }

            }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
