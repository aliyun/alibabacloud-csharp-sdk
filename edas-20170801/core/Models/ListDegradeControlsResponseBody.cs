// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListDegradeControlsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FlowControlsMap")]
        [Validation(Required=false)]
        public ListDegradeControlsResponseBodyFlowControlsMap FlowControlsMap { get; set; }
        public class ListDegradeControlsResponseBodyFlowControlsMap : TeaModel {
            [NameInMap("InterfaceMethods")]
            [Validation(Required=false)]
            public ListDegradeControlsResponseBodyFlowControlsMapInterfaceMethods InterfaceMethods { get; set; }
            public class ListDegradeControlsResponseBodyFlowControlsMapInterfaceMethods : TeaModel {
                [NameInMap("InterfaceMethod")]
                [Validation(Required=false)]
                public List<ListDegradeControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethod> InterfaceMethod { get; set; }
                public class ListDegradeControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethod : TeaModel {
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Methods")]
                    [Validation(Required=false)]
                    public ListDegradeControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethodMethods Methods { get; set; }
                    public class ListDegradeControlsResponseBodyFlowControlsMapInterfaceMethodsInterfaceMethodMethods : TeaModel {
                        [NameInMap("Method")]
                        [Validation(Required=false)]
                        public List<string> Method { get; set; }
                    };

                }

            }
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public ListDegradeControlsResponseBodyFlowControlsMapRuleList RuleList { get; set; }
            public class ListDegradeControlsResponseBodyFlowControlsMapRuleList : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("TotalSize")]
                [Validation(Required=false)]
                public int? TotalSize { get; set; }

                [NameInMap("RuleResultList")]
                [Validation(Required=false)]
                public ListDegradeControlsResponseBodyFlowControlsMapRuleListRuleResultList RuleResultList { get; set; }
                public class ListDegradeControlsResponseBodyFlowControlsMapRuleListRuleResultList : TeaModel {
                    [NameInMap("Rule")]
                    [Validation(Required=false)]
                    public List<ListDegradeControlsResponseBodyFlowControlsMapRuleListRuleResultListRule> Rule { get; set; }
                    public class ListDegradeControlsResponseBodyFlowControlsMapRuleListRuleResultListRule : TeaModel {
                        public string Resource { get; set; }
                        public string RuleType { get; set; }
                        public long? UpdateTime { get; set; }
                        public int? State { get; set; }
                        public long? CreateTime { get; set; }
                        public string AppId { get; set; }
                        public int? Duration { get; set; }
                        public int? RtThreshold { get; set; }
                        public string RuleId { get; set; }
                    }
                };

                [NameInMap("pageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
