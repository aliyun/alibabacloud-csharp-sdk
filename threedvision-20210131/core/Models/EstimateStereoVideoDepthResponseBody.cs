// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateStereoVideoDepthResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EstimateStereoVideoDepthResponseBodyData Data { get; set; }
        public class EstimateStereoVideoDepthResponseBodyData : TeaModel {
            [NameInMap("DepthUrl")]
            [Validation(Required=false)]
            public string DepthUrl { get; set; }
            [NameInMap("DepthVisUrl")]
            [Validation(Required=false)]
            public string DepthVisUrl { get; set; }
        };

    }

}
