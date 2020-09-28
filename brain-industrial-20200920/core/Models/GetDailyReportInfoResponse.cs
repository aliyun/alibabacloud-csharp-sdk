// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetDailyReportInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("DayResultRsp")]
        [Validation(Required=true)]
        public GetDailyReportInfoResponseDayResultRsp DayResultRsp { get; set; }
        public class GetDailyReportInfoResponseDayResultRsp : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("DayResultData")]
            [Validation(Required=true)]
            public GetDailyReportInfoResponseDayResultRspDayResultData DayResultData { get; set; }
            public class GetDailyReportInfoResponseDayResultRspDayResultData : TeaModel {
                [NameInMap("LoopName")]
                [Validation(Required=true)]
                public string LoopName { get; set; }

                [NameInMap("ReportDate")]
                [Validation(Required=true)]
                public string ReportDate { get; set; }

                [NameInMap("MultipleScore")]
                [Validation(Required=true)]
                public string MultipleScore { get; set; }

                [NameInMap("PerformMetrics")]
                [Validation(Required=true)]
                public string PerformMetrics { get; set; }

                [NameInMap("MultipleScoreIndex")]
                [Validation(Required=true)]
                public string MultipleScoreIndex { get; set; }

                [NameInMap("OperationRate")]
                [Validation(Required=true)]
                public string OperationRate { get; set; }

                [NameInMap("ValidOperationRate")]
                [Validation(Required=true)]
                public string ValidOperationRate { get; set; }

                [NameInMap("OscillationIndex")]
                [Validation(Required=true)]
                public string OscillationIndex { get; set; }

                [NameInMap("ValveStickIndex")]
                [Validation(Required=true)]
                public string ValveStickIndex { get; set; }

                [NameInMap("PvMean")]
                [Validation(Required=true)]
                public string PvMean { get; set; }

                [NameInMap("PvStd")]
                [Validation(Required=true)]
                public string PvStd { get; set; }

                [NameInMap("PvMax")]
                [Validation(Required=true)]
                public string PvMax { get; set; }

                [NameInMap("PvMin")]
                [Validation(Required=true)]
                public string PvMin { get; set; }

                [NameInMap("ErrMean")]
                [Validation(Required=true)]
                public string ErrMean { get; set; }

                [NameInMap("ErrStd")]
                [Validation(Required=true)]
                public string ErrStd { get; set; }

                [NameInMap("ErrMax")]
                [Validation(Required=true)]
                public string ErrMax { get; set; }

                [NameInMap("ErrMin")]
                [Validation(Required=true)]
                public string ErrMin { get; set; }

                [NameInMap("OpMean")]
                [Validation(Required=true)]
                public string OpMean { get; set; }

                [NameInMap("OpStd")]
                [Validation(Required=true)]
                public string OpStd { get; set; }

                [NameInMap("OpMax")]
                [Validation(Required=true)]
                public string OpMax { get; set; }

                [NameInMap("OpMin")]
                [Validation(Required=true)]
                public string OpMin { get; set; }

                [NameInMap("LoopTrans")]
                [Validation(Required=true)]
                public string LoopTrans { get; set; }

                [NameInMap("SpCross")]
                [Validation(Required=true)]
                public string SpCross { get; set; }

                [NameInMap("OpTurn")]
                [Validation(Required=true)]
                public string OpTurn { get; set; }

                [NameInMap("OpSum")]
                [Validation(Required=true)]
                public string OpSum { get; set; }

                [NameInMap("GoodRate")]
                [Validation(Required=true)]
                public string GoodRate { get; set; }

                [NameInMap("SatuRate")]
                [Validation(Required=true)]
                public string SatuRate { get; set; }

            }
        };

    }

}
