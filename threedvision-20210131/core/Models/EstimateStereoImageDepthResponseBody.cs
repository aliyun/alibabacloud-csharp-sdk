// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateStereoImageDepthResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EstimateStereoImageDepthResponseBodyData Data { get; set; }
        public class EstimateStereoImageDepthResponseBodyData : TeaModel {
            [NameInMap("DisparityMapURL")]
            [Validation(Required=false)]
            public string DisparityMapURL { get; set; }
            [NameInMap("DisparityVisURL")]
            [Validation(Required=false)]
            public string DisparityVisURL { get; set; }
        };

    }

}
