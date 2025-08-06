// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetOSSFlowStatisResponseBody : TeaModel {
        [NameInMap("OSSFlowStatisList")]
        [Validation(Required=false)]
        public List<GetOSSFlowStatisResponseBodyOSSFlowStatisList> OSSFlowStatisList { get; set; }
        public class GetOSSFlowStatisResponseBodyOSSFlowStatisList : TeaModel {
            [NameInMap("NetworkOut")]
            [Validation(Required=false)]
            public long? NetworkOut { get; set; }

            [NameInMap("StatTime")]
            [Validation(Required=false)]
            public string StatTime { get; set; }

            [NameInMap("StatTimeUTC")]
            [Validation(Required=false)]
            public string StatTimeUTC { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
