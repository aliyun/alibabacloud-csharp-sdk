// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeVariableDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVariableDetailResponseBodyResultObject : TeaModel {
            [NameInMap("baseInfo")]
            [Validation(Required=false)]
            public DescribeVariableDetailResponseBodyResultObjectBaseInfo BaseInfo { get; set; }
            public class DescribeVariableDetailResponseBodyResultObjectBaseInfo : TeaModel {
                [NameInMap("allowBind")]
                [Validation(Required=false)]
                public string AllowBind { get; set; }

                [NameInMap("chargingMode")]
                [Validation(Required=false)]
                public string ChargingMode { get; set; }

                [NameInMap("chargingModeDesc")]
                [Validation(Required=false)]
                public string ChargingModeDesc { get; set; }

                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                [NameInMap("dataThreshold")]
                [Validation(Required=false)]
                public string DataThreshold { get; set; }

                [NameInMap("deductionFactor")]
                [Validation(Required=false)]
                public int? DeductionFactor { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("frontAllowBind")]
                [Validation(Required=false)]
                public string FrontAllowBind { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                [NameInMap("inputsDesc")]
                [Validation(Required=false)]
                public string InputsDesc { get; set; }

                [NameInMap("invokeKey")]
                [Validation(Required=false)]
                public string InvokeKey { get; set; }

                [NameInMap("invokeRt")]
                [Validation(Required=false)]
                public int? InvokeRt { get; set; }

                [NameInMap("invokeSuccessRate")]
                [Validation(Required=false)]
                public string InvokeSuccessRate { get; set; }

                [NameInMap("invokeTimes")]
                [Validation(Required=false)]
                public long? InvokeTimes { get; set; }

                [NameInMap("lastModifiedOperator")]
                [Validation(Required=false)]
                public string LastModifiedOperator { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("outputs")]
                [Validation(Required=false)]
                public string Outputs { get; set; }

                [NameInMap("outputsDesc")]
                [Validation(Required=false)]
                public string OutputsDesc { get; set; }

                [NameInMap("scene")]
                [Validation(Required=false)]
                public List<string> Scene { get; set; }

                [NameInMap("sceneDesc")]
                [Validation(Required=false)]
                public List<string> SceneDesc { get; set; }

                [NameInMap("showOrder")]
                [Validation(Required=false)]
                public string ShowOrder { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("sourceDesc")]
                [Validation(Required=false)]
                public string SourceDesc { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("supportRegions")]
                [Validation(Required=false)]
                public List<string> SupportRegions { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("typeDesc")]
                [Validation(Required=false)]
                public string TypeDesc { get; set; }

                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

        }

    }

}
