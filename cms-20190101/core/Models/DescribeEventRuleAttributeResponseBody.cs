// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeEventRuleAttributeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeEventRuleAttributeResponseBodyResult Result { get; set; }
        public class DescribeEventRuleAttributeResponseBodyResult : TeaModel {
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("EventPattern")]
            [Validation(Required=false)]
            public DescribeEventRuleAttributeResponseBodyResultEventPattern EventPattern { get; set; }
            public class DescribeEventRuleAttributeResponseBodyResultEventPattern : TeaModel {
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                [NameInMap("LevelList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternLevelList LevelList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternLevelList : TeaModel {
                    [NameInMap("LevelList")]
                    [Validation(Required=false)]
                    public List<string> LevelList { get; set; }
                };

                [NameInMap("StatusList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternStatusList StatusList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternStatusList : TeaModel {
                    [NameInMap("StatusList")]
                    [Validation(Required=false)]
                    public List<string> StatusList { get; set; }
                };

                [NameInMap("NameList")]
                [Validation(Required=false)]
                public DescribeEventRuleAttributeResponseBodyResultEventPatternNameList NameList { get; set; }
                public class DescribeEventRuleAttributeResponseBodyResultEventPatternNameList : TeaModel {
                    [NameInMap("NameList")]
                    [Validation(Required=false)]
                    public List<string> NameList { get; set; }
                };

            }
        };

    }

}
