// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsRegionListResponseBody : TeaModel {
        /// <summary>
        /// The result returned
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsRegionListResponseBodyData Data { get; set; }
        public class OnsRegionListResponseBodyData : TeaModel {
            [NameInMap("RegionDo")]
            [Validation(Required=false)]
            public List<OnsRegionListResponseBodyDataRegionDo> RegionDo { get; set; }
            public class OnsRegionListResponseBodyDataRegionDo : TeaModel {
                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("OnsRegionId")]
                [Validation(Required=false)]
                public string OnsRegionId { get; set; }

                /// <summary>
                /// The name of the region.
                /// </summary>
                [NameInMap("RegionName")]
                [Validation(Required=false)]
                public string RegionName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request. This parameter is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
