// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class GetVpnGatewayDiagnoseResultResponseBody : TeaModel {
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public string BeginTime { get; set; }

        [NameInMap("DiagnoseId")]
        [Validation(Required=false)]
        public string DiagnoseId { get; set; }

        [NameInMap("DiagnoseResult")]
        [Validation(Required=false)]
        public List<GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult> DiagnoseResult { get; set; }
        public class GetVpnGatewayDiagnoseResultResponseBodyDiagnoseResult : TeaModel {
            [NameInMap("DiagnoseName")]
            [Validation(Required=false)]
            public string DiagnoseName { get; set; }

            [NameInMap("DiagnoseResultDescription")]
            [Validation(Required=false)]
            public string DiagnoseResultDescription { get; set; }

            [NameInMap("DiagnoseResultLevel")]
            [Validation(Required=false)]
            public string DiagnoseResultLevel { get; set; }

        }

        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        [NameInMap("FinishedCount")]
        [Validation(Required=false)]
        public int? FinishedCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceInstanceId")]
        [Validation(Required=false)]
        public string ResourceInstanceId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VpnGatewayId")]
        [Validation(Required=false)]
        public string VpnGatewayId { get; set; }

    }

}
