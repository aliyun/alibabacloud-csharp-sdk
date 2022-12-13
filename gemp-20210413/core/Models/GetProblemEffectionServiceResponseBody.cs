// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemEffectionServiceResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProblemEffectionServiceResponseBodyData Data { get; set; }
        public class GetProblemEffectionServiceResponseBodyData : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("effectionServiceId")]
            [Validation(Required=false)]
            public long? EffectionServiceId { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            [NameInMap("picUrl")]
            [Validation(Required=false)]
            public List<string> PicUrl { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
