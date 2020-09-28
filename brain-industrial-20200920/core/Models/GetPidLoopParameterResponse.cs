// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetPidLoopParameterResponse : TeaModel {
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

        [NameInMap("PidLoopParameter")]
        [Validation(Required=true)]
        public GetPidLoopParameterResponsePidLoopParameter PidLoopParameter { get; set; }
        public class GetPidLoopParameterResponsePidLoopParameter : TeaModel {
            [NameInMap("PidLoopParameterId")]
            [Validation(Required=true)]
            public string PidLoopParameterId { get; set; }
            [NameInMap("PidProjectId")]
            [Validation(Required=true)]
            public string PidProjectId { get; set; }
            [NameInMap("PidLoopId")]
            [Validation(Required=true)]
            public string PidLoopId { get; set; }
            [NameInMap("PidIdentTaskDate")]
            [Validation(Required=true)]
            public string PidIdentTaskDate { get; set; }
            [NameInMap("PidResetTaskDate")]
            [Validation(Required=true)]
            public string PidResetTaskDate { get; set; }
            [NameInMap("PidIdentParam")]
            [Validation(Required=true)]
            public GetPidLoopParameterResponsePidLoopParameterPidIdentParam PidIdentParam { get; set; }
            public class GetPidLoopParameterResponsePidLoopParameterPidIdentParam : TeaModel {
                [NameInMap("ModelType")]
                [Validation(Required=true)]
                public int? ModelType { get; set; }

                [NameInMap("Integral")]
                [Validation(Required=true)]
                public bool? Integral { get; set; }

                [NameInMap("TrendControl")]
                [Validation(Required=true)]
                public bool? TrendControl { get; set; }

                [NameInMap("Delay")]
                [Validation(Required=true)]
                public int? Delay { get; set; }

                [NameInMap("Smooth")]
                [Validation(Required=true)]
                public int? Smooth { get; set; }

                [NameInMap("Robust")]
                [Validation(Required=true)]
                public int? Robust { get; set; }

                [NameInMap("LimitSw")]
                [Validation(Required=true)]
                public bool? LimitSw { get; set; }

                [NameInMap("ManualTrend")]
                [Validation(Required=true)]
                public bool? ManualTrend { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=true)]
                public string StartTime { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=true)]
                public string EndTime { get; set; }

                [NameInMap("PidDataProcessId")]
                [Validation(Required=true)]
                public long PidDataProcessId { get; set; }

                [NameInMap("LimitMax")]
                [Validation(Required=true)]
                public GetPidLoopParameterResponsePidLoopParameterPidIdentParamLimitMax LimitMax { get; set; }
                public class GetPidLoopParameterResponsePidLoopParameterPidIdentParamLimitMax : TeaModel {
                    [NameInMap("K")]
                    [Validation(Required=true)]
                    public float? K { get; set; }
                    [NameInMap("Tau")]
                    [Validation(Required=true)]
                    public float? Tau { get; set; }
                    [NameInMap("T1")]
                    [Validation(Required=true)]
                    public float? T1 { get; set; }
                    [NameInMap("T2")]
                    [Validation(Required=true)]
                    public float? T2 { get; set; }
                };

                [NameInMap("LimitMin")]
                [Validation(Required=true)]
                public GetPidLoopParameterResponsePidLoopParameterPidIdentParamLimitMin LimitMin { get; set; }
                public class GetPidLoopParameterResponsePidLoopParameterPidIdentParamLimitMin : TeaModel {
                    [NameInMap("K")]
                    [Validation(Required=true)]
                    public float? K { get; set; }
                    [NameInMap("Tau")]
                    [Validation(Required=true)]
                    public float? Tau { get; set; }
                    [NameInMap("T1")]
                    [Validation(Required=true)]
                    public float? T1 { get; set; }
                    [NameInMap("T2")]
                    [Validation(Required=true)]
                    public float? T2 { get; set; }
                };

                [NameInMap("ManualModel")]
                [Validation(Required=true)]
                public GetPidLoopParameterResponsePidLoopParameterPidIdentParamManualModel ManualModel { get; set; }
                public class GetPidLoopParameterResponsePidLoopParameterPidIdentParamManualModel : TeaModel {
                    [NameInMap("K")]
                    [Validation(Required=true)]
                    public float? K { get; set; }
                    [NameInMap("Tau")]
                    [Validation(Required=true)]
                    public float? Tau { get; set; }
                    [NameInMap("T1")]
                    [Validation(Required=true)]
                    public float? T1 { get; set; }
                    [NameInMap("T2")]
                    [Validation(Required=true)]
                    public float? T2 { get; set; }
                };

            }
            [NameInMap("PIdResetParam")]
            [Validation(Required=true)]
            public GetPidLoopParameterResponsePidLoopParameterPIdResetParam PIdResetParam { get; set; }
            public class GetPidLoopParameterResponsePidLoopParameterPIdResetParam : TeaModel {
                [NameInMap("DcsType")]
                [Validation(Required=true)]
                public string DcsType { get; set; }

                [NameInMap("Model")]
                [Validation(Required=true)]
                public string Model { get; set; }

                [NameInMap("ModelType")]
                [Validation(Required=true)]
                public int? ModelType { get; set; }

                [NameInMap("Integral")]
                [Validation(Required=true)]
                public bool? Integral { get; set; }

                [NameInMap("CtrlMode")]
                [Validation(Required=true)]
                public int? CtrlMode { get; set; }

                [NameInMap("CtrlStuc")]
                [Validation(Required=true)]
                public int? CtrlStuc { get; set; }

                [NameInMap("Robust")]
                [Validation(Required=true)]
                public int? Robust { get; set; }

                [NameInMap("Dynamic")]
                [Validation(Required=true)]
                public float? Dynamic { get; set; }

                [NameInMap("ManualTrend")]
                [Validation(Required=true)]
                public bool? ManualTrend { get; set; }

                [NameInMap("MeasuredValueRange")]
                [Validation(Required=true)]
                public GetPidLoopParameterResponsePidLoopParameterPIdResetParamMeasuredValueRange MeasuredValueRange { get; set; }
                public class GetPidLoopParameterResponsePidLoopParameterPIdResetParamMeasuredValueRange : TeaModel {
                    [NameInMap("Min")]
                    [Validation(Required=true)]
                    public float? Min { get; set; }
                    [NameInMap("Max")]
                    [Validation(Required=true)]
                    public float? Max { get; set; }
                };

                [NameInMap("ValvePositionRange")]
                [Validation(Required=true)]
                public GetPidLoopParameterResponsePidLoopParameterPIdResetParamValvePositionRange ValvePositionRange { get; set; }
                public class GetPidLoopParameterResponsePidLoopParameterPIdResetParamValvePositionRange : TeaModel {
                    [NameInMap("Min")]
                    [Validation(Required=true)]
                    public float? Min { get; set; }
                    [NameInMap("Max")]
                    [Validation(Required=true)]
                    public float? Max { get; set; }
                };

                [NameInMap("ManualCtrl")]
                [Validation(Required=true)]
                public GetPidLoopParameterResponsePidLoopParameterPIdResetParamManualCtrl ManualCtrl { get; set; }
                public class GetPidLoopParameterResponsePidLoopParameterPIdResetParamManualCtrl : TeaModel {
                    [NameInMap("Kp")]
                    [Validation(Required=true)]
                    public float? Kp { get; set; }
                    [NameInMap("Ti")]
                    [Validation(Required=true)]
                    public float? Ti { get; set; }
                    [NameInMap("Td")]
                    [Validation(Required=true)]
                    public float? Td { get; set; }
                };

            }
        };

    }

}
