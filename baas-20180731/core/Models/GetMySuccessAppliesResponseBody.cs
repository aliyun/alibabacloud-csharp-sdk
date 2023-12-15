// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class GetMySuccessAppliesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetMySuccessAppliesResponseBodyResult> Result { get; set; }
        public class GetMySuccessAppliesResponseBodyResult : TeaModel {
            [NameInMap("AbnormalNodes")]
            [Validation(Required=false)]
            public int? AbnormalNodes { get; set; }

            [NameInMap("Bizid")]
            [Validation(Required=false)]
            public string Bizid { get; set; }

            [NameInMap("BlockHeight")]
            [Validation(Required=false)]
            public int? BlockHeight { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("IsRole")]
            [Validation(Required=false)]
            public bool? IsRole { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodeInfoList")]
            [Validation(Required=false)]
            public List<GetMySuccessAppliesResponseBodyResultNodeInfoList> NodeInfoList { get; set; }
            public class GetMySuccessAppliesResponseBodyResultNodeInfoList : TeaModel {
                [NameInMap("BlockHeight")]
                [Validation(Required=false)]
                public long? BlockHeight { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public bool? Status { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            [NameInMap("NodeNumber")]
            [Validation(Required=false)]
            public int? NodeNumber { get; set; }

            [NameInMap("Normal")]
            [Validation(Required=false)]
            public bool? Normal { get; set; }

            [NameInMap("TransactionSum")]
            [Validation(Required=false)]
            public int? TransactionSum { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
