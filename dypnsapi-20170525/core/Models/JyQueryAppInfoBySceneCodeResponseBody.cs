// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class JyQueryAppInfoBySceneCodeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public JyQueryAppInfoBySceneCodeResponseBodyData Data { get; set; }
        public class JyQueryAppInfoBySceneCodeResponseBodyData : TeaModel {
            [NameInMap("CmAppId")]
            [Validation(Required=false)]
            public string CmAppId { get; set; }

            [NameInMap("CmAppKey")]
            [Validation(Required=false)]
            public string CmAppKey { get; set; }

            [NameInMap("CtAppId")]
            [Validation(Required=false)]
            public string CtAppId { get; set; }

            [NameInMap("CtAppKey")]
            [Validation(Required=false)]
            public string CtAppKey { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
