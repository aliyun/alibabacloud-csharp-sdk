// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class SubmitInfoRequest : TeaModel {
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public long? CallerUid { get; set; }

        [NameInMap("EcsDescList")]
        [Validation(Required=false)]
        public List<SubmitInfoRequestEcsDescList> EcsDescList { get; set; }
        public class SubmitInfoRequestEcsDescList : TeaModel {
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            [NameInMap("BussinessDesc")]
            [Validation(Required=false)]
            public string BussinessDesc { get; set; }

            [NameInMap("BussinessType")]
            [Validation(Required=false)]
            public string BussinessType { get; set; }

            [NameInMap("EnvType")]
            [Validation(Required=false)]
            public string EnvType { get; set; }

            [NameInMap("MiddleWareDesc")]
            [Validation(Required=false)]
            public string MiddleWareDesc { get; set; }

            [NameInMap("OtherMiddleWareDesc")]
            [Validation(Required=false)]
            public string OtherMiddleWareDesc { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("MainUserId")]
        [Validation(Required=false)]
        public long? MainUserId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
