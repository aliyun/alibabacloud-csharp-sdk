// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetPidLoopResponse : TeaModel {
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

        [NameInMap("LoopConfiguration")]
        [Validation(Required=true)]
        public GetPidLoopResponseLoopConfiguration LoopConfiguration { get; set; }
        public class GetPidLoopResponseLoopConfiguration : TeaModel {
            [NameInMap("BaseParam")]
            [Validation(Required=true)]
            public GetPidLoopResponseLoopConfigurationBaseParam BaseParam { get; set; }
            public class GetPidLoopResponseLoopConfigurationBaseParam : TeaModel {
                [NameInMap("OpenLoopTime")]
                [Validation(Required=true)]
                public int? OpenLoopTime { get; set; }

                [NameInMap("SampleTime")]
                [Validation(Required=true)]
                public int? SampleTime { get; set; }

                [NameInMap("SuitCtrlTime")]
                [Validation(Required=true)]
                public int? SuitCtrlTime { get; set; }

                [NameInMap("Pv")]
                [Validation(Required=true)]
                public string Pv { get; set; }

                [NameInMap("Sp")]
                [Validation(Required=true)]
                public string Sp { get; set; }

                [NameInMap("SplitRangeControl")]
                [Validation(Required=true)]
                public bool? SplitRangeControl { get; set; }

                [NameInMap("Op")]
                [Validation(Required=true)]
                public string Op { get; set; }

                [NameInMap("Op1")]
                [Validation(Required=true)]
                public string Op1 { get; set; }

                [NameInMap("Op2")]
                [Validation(Required=true)]
                public string Op2 { get; set; }

                [NameInMap("ControlSwitch")]
                [Validation(Required=true)]
                public string ControlSwitch { get; set; }

                [NameInMap("Mv")]
                [Validation(Required=true)]
                public string Mv { get; set; }

                [NameInMap("ForwardController")]
                [Validation(Required=true)]
                public bool? ForwardController { get; set; }

                [NameInMap("ForwardVariable")]
                [Validation(Required=true)]
                public string ForwardVariable { get; set; }

                [NameInMap("Integral")]
                [Validation(Required=true)]
                public bool? Integral { get; set; }

                [NameInMap("PvRange")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamPvRange PvRange { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamPvRange : TeaModel {
                    [NameInMap("Min")]
                    [Validation(Required=true)]
                    public float? Min { get; set; }
                    [NameInMap("Max")]
                    [Validation(Required=true)]
                    public float? Max { get; set; }
                };

                [NameInMap("SpOperate")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamSpOperate SpOperate { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamSpOperate : TeaModel {
                    [NameInMap("Min")]
                    [Validation(Required=true)]
                    public float? Min { get; set; }
                    [NameInMap("Max")]
                    [Validation(Required=true)]
                    public float? Max { get; set; }
                };

                [NameInMap("OpParam")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamOpParam OpParam { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamOpParam : TeaModel {
                    [NameInMap("Trend")]
                    [Validation(Required=true)]
                    public int? Trend { get; set; }
                    [NameInMap("OpScope")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOpParamOpScope OpScope { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOpParamOpScope : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Range")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOpParamRange Range { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOpParamRange : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Operate")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOpParamOperate Operate { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOpParamOperate : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Increment")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOpParamIncrement Increment { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOpParamIncrement : TeaModel {
                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                };

                [NameInMap("Op1Param")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamOp1Param Op1Param { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamOp1Param : TeaModel {
                    [NameInMap("Trend")]
                    [Validation(Required=true)]
                    public int? Trend { get; set; }
                    [NameInMap("OpScope")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp1ParamOpScope OpScope { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp1ParamOpScope : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Range")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp1ParamRange Range { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp1ParamRange : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Operate")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp1ParamOperate Operate { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp1ParamOperate : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Increment")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp1ParamIncrement Increment { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp1ParamIncrement : TeaModel {
                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                };

                [NameInMap("Op2Param")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamOp2Param Op2Param { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamOp2Param : TeaModel {
                    [NameInMap("Trend")]
                    [Validation(Required=true)]
                    public int? Trend { get; set; }
                    [NameInMap("OpScope")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp2ParamOpScope OpScope { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp2ParamOpScope : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Range")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp2ParamRange Range { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp2ParamRange : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Operate")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp2ParamOperate Operate { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp2ParamOperate : TeaModel {
                        [NameInMap("Min")]
                        [Validation(Required=true)]
                        public float? Min { get; set; }

                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                    [NameInMap("Increment")]
                    [Validation(Required=true)]
                    public GetPidLoopResponseLoopConfigurationBaseParamOp2ParamIncrement Increment { get; set; }
                    public class GetPidLoopResponseLoopConfigurationBaseParamOp2ParamIncrement : TeaModel {
                        [NameInMap("Max")]
                        [Validation(Required=true)]
                        public float? Max { get; set; }

                    }
                };

                [NameInMap("Kp")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamKp Kp { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamKp : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=true)]
                    public string TagKey { get; set; }
                    [NameInMap("TagValue")]
                    [Validation(Required=true)]
                    public string TagValue { get; set; }
                };

                [NameInMap("Td")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamTd Td { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamTd : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=true)]
                    public string TagKey { get; set; }
                    [NameInMap("TagValue")]
                    [Validation(Required=true)]
                    public string TagValue { get; set; }
                };

                [NameInMap("Ti")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamTi Ti { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamTi : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=true)]
                    public string TagKey { get; set; }
                    [NameInMap("TagValue")]
                    [Validation(Required=true)]
                    public string TagValue { get; set; }
                };

                [NameInMap("Kd")]
                [Validation(Required=true)]
                public GetPidLoopResponseLoopConfigurationBaseParamKd Kd { get; set; }
                public class GetPidLoopResponseLoopConfigurationBaseParamKd : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=true)]
                    public string TagKey { get; set; }
                    [NameInMap("TagValue")]
                    [Validation(Required=true)]
                    public string TagValue { get; set; }
                };

            }
            [NameInMap("IdentParam")]
            [Validation(Required=true)]
            public GetPidLoopResponseLoopConfigurationIdentParam IdentParam { get; set; }
            public class GetPidLoopResponseLoopConfigurationIdentParam : TeaModel {
                [NameInMap("ModelType")]
                [Validation(Required=true)]
                public int? ModelType { get; set; }

                [NameInMap("Delay")]
                [Validation(Required=true)]
                public int? Delay { get; set; }

            }
            [NameInMap("ResetParam")]
            [Validation(Required=true)]
            public GetPidLoopResponseLoopConfigurationResetParam ResetParam { get; set; }
            public class GetPidLoopResponseLoopConfigurationResetParam : TeaModel {
                [NameInMap("CtrlMode")]
                [Validation(Required=true)]
                public int? CtrlMode { get; set; }

                [NameInMap("CtrlStuc")]
                [Validation(Required=true)]
                public int? CtrlStuc { get; set; }

            }
        };

    }

}
