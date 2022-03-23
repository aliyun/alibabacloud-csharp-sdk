// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetPageConfigResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetPageConfigResponseBodyResult Result { get; set; }
        public class GetPageConfigResponseBodyResult : TeaModel {
            [NameInMap("AdList")]
            [Validation(Required=false)]
            public List<GetPageConfigResponseBodyResultAdList> AdList { get; set; }
            public class GetPageConfigResponseBodyResultAdList : TeaModel {
                public bool? CanNotBeenBought { get; set; }
                public string Detail { get; set; }
                public string Icon { get; set; }
                public string JumpBuyLink { get; set; }
                public string SubTitle { get; set; }
                public string Title { get; set; }
            }
        };

    }

}
