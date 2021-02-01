// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class EstimateMonocularImageDepthResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EstimateMonocularImageDepthResponseBodyData Data { get; set; }
        public class EstimateMonocularImageDepthResponseBodyData : TeaModel {
            [NameInMap("DepthMapUrl")]
            [Validation(Required=false)]
            public string DepthMapUrl { get; set; }
            [NameInMap("DepthToColorUrl")]
            [Validation(Required=false)]
            public string DepthToColorUrl { get; set; }
        };

    }

}
