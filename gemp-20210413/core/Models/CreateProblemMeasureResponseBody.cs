// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateProblemMeasureResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateProblemMeasureResponseBodyData Data { get; set; }
        public class CreateProblemMeasureResponseBodyData : TeaModel {
            [NameInMap("measureId")]
            [Validation(Required=false)]
            public long? MeasureId { get; set; }
        };

    }

}
