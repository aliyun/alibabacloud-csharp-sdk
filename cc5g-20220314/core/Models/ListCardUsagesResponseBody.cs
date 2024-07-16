// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListCardUsagesResponseBody : TeaModel {
        [NameInMap("Cards")]
        [Validation(Required=false)]
        public List<ListCardUsagesResponseBodyCards> Cards { get; set; }
        public class ListCardUsagesResponseBodyCards : TeaModel {
            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("Iccid")]
            [Validation(Required=false)]
            public string Iccid { get; set; }

            [NameInMap("UsageDataMonth")]
            [Validation(Required=false)]
            public long? UsageDataMonth { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
