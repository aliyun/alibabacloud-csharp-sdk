// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetSummaryReportInfoResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("SummaryResultRsp")]
        [Validation(Required=true)]
        public GetSummaryReportInfoResponseSummaryResultRsp SummaryResultRsp { get; set; }
        public class GetSummaryReportInfoResponseSummaryResultRsp : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("SummaryResultData")]
            [Validation(Required=true)]
            public GetSummaryReportInfoResponseSummaryResultRspSummaryResultData SummaryResultData { get; set; }
            public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultData : TeaModel {
                [NameInMap("LoopName")]
                [Validation(Required=true)]
                public string LoopName { get; set; }

                [NameInMap("MultipleScoreIndexRsp")]
                [Validation(Required=true)]
                public GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataMultipleScoreIndexRsp MultipleScoreIndexRsp { get; set; }
                public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataMultipleScoreIndexRsp : TeaModel {
                    [NameInMap("Average")]
                    [Validation(Required=true)]
                    public string Average { get; set; }
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public string Best { get; set; }
                    [NameInMap("Worst")]
                    [Validation(Required=true)]
                    public string Worst { get; set; }
                };

                [NameInMap("MultipleScoreRsp")]
                [Validation(Required=true)]
                public GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataMultipleScoreRsp MultipleScoreRsp { get; set; }
                public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataMultipleScoreRsp : TeaModel {
                    [NameInMap("Average")]
                    [Validation(Required=true)]
                    public string Average { get; set; }
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public string Best { get; set; }
                    [NameInMap("Worst")]
                    [Validation(Required=true)]
                    public string Worst { get; set; }
                };

                [NameInMap("OperationRate")]
                [Validation(Required=true)]
                public GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataOperationRate OperationRate { get; set; }
                public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataOperationRate : TeaModel {
                    [NameInMap("Average")]
                    [Validation(Required=true)]
                    public string Average { get; set; }
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public string Best { get; set; }
                    [NameInMap("Worst")]
                    [Validation(Required=true)]
                    public string Worst { get; set; }
                };

                [NameInMap("OscillationIndex")]
                [Validation(Required=true)]
                public GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataOscillationIndex OscillationIndex { get; set; }
                public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataOscillationIndex : TeaModel {
                    [NameInMap("Average")]
                    [Validation(Required=true)]
                    public string Average { get; set; }
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public string Best { get; set; }
                    [NameInMap("Worst")]
                    [Validation(Required=true)]
                    public string Worst { get; set; }
                };

                [NameInMap("PerformMetrics")]
                [Validation(Required=true)]
                public GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataPerformMetrics PerformMetrics { get; set; }
                public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataPerformMetrics : TeaModel {
                    [NameInMap("Average")]
                    [Validation(Required=true)]
                    public string Average { get; set; }
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public string Best { get; set; }
                    [NameInMap("Worst")]
                    [Validation(Required=true)]
                    public string Worst { get; set; }
                };

                [NameInMap("ValidOperationRate")]
                [Validation(Required=true)]
                public GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataValidOperationRate ValidOperationRate { get; set; }
                public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataValidOperationRate : TeaModel {
                    [NameInMap("Average")]
                    [Validation(Required=true)]
                    public string Average { get; set; }
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public string Best { get; set; }
                    [NameInMap("Worst")]
                    [Validation(Required=true)]
                    public string Worst { get; set; }
                };

                [NameInMap("ValveStickIndex")]
                [Validation(Required=true)]
                public GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataValveStickIndex ValveStickIndex { get; set; }
                public class GetSummaryReportInfoResponseSummaryResultRspSummaryResultDataValveStickIndex : TeaModel {
                    [NameInMap("Average")]
                    [Validation(Required=true)]
                    public string Average { get; set; }
                    [NameInMap("Best")]
                    [Validation(Required=true)]
                    public string Best { get; set; }
                    [NameInMap("Worst")]
                    [Validation(Required=true)]
                    public string Worst { get; set; }
                };

            }
        };

    }

}
