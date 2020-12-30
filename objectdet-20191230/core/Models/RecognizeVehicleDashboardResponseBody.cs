// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class RecognizeVehicleDashboardResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeVehicleDashboardResponseBodyData Data { get; set; }
        public class RecognizeVehicleDashboardResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<RecognizeVehicleDashboardResponseBodyDataElements> Elements { get; set; }
            public class RecognizeVehicleDashboardResponseBodyDataElements : TeaModel {
                public List<string> Boxes { get; set; }
                public float? Score { get; set; }
                public string Label { get; set; }
                public string ClassName { get; set; }
            }
        };

    }

}
