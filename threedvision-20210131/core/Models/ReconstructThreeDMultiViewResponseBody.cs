// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Threedvision20210131.Models
{
    public class ReconstructThreeDMultiViewResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReconstructThreeDMultiViewResponseBodyData Data { get; set; }
        public class ReconstructThreeDMultiViewResponseBodyData : TeaModel {
            [NameInMap("PointCloudURL")]
            [Validation(Required=false)]
            public string PointCloudURL { get; set; }
        };

    }

}
