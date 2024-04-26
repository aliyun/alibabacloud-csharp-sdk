// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDesignProjectFlowResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ProjectFlow")]
        [Validation(Required=false)]
        public GetTableDesignProjectFlowResponseBodyProjectFlow ProjectFlow { get; set; }
        public class GetTableDesignProjectFlowResponseBodyProjectFlow : TeaModel {
            [NameInMap("CurrentPosition")]
            [Validation(Required=false)]
            public int? CurrentPosition { get; set; }

            [NameInMap("FlowNodeArray")]
            [Validation(Required=false)]
            public List<GetTableDesignProjectFlowResponseBodyProjectFlowFlowNodeArray> FlowNodeArray { get; set; }
            public class GetTableDesignProjectFlowResponseBodyProjectFlowFlowNodeArray : TeaModel {
                [NameInMap("BackToDesign")]
                [Validation(Required=false)]
                public bool? BackToDesign { get; set; }

                [NameInMap("CanSkip")]
                [Validation(Required=false)]
                public bool? CanSkip { get; set; }

                [NameInMap("NodeRole")]
                [Validation(Required=false)]
                public string NodeRole { get; set; }

                [NameInMap("NodeTitle")]
                [Validation(Required=false)]
                public string NodeTitle { get; set; }

                [NameInMap("Position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

                [NameInMap("PublishAnchor")]
                [Validation(Required=false)]
                public bool? PublishAnchor { get; set; }

                [NameInMap("PublishStrategies")]
                [Validation(Required=false)]
                public List<string> PublishStrategies { get; set; }

            }

            [NameInMap("RuleComment")]
            [Validation(Required=false)]
            public string RuleComment { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
