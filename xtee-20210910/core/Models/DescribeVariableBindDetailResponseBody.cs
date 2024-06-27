// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableBindDetailResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeVariableBindDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVariableBindDetailResponseBodyResultObject : TeaModel {
            [NameInMap("allowModify")]
            [Validation(Required=false)]
            public bool? AllowModify { get; set; }

            [NameInMap("defineId")]
            [Validation(Required=false)]
            public long? DefineId { get; set; }

            [NameInMap("defineTitle")]
            [Validation(Required=false)]
            public string DefineTitle { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("eventCode")]
            [Validation(Required=false)]
            public string EventCode { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("params")]
            [Validation(Required=false)]
            public List<DescribeVariableBindDetailResponseBodyResultObjectParams> Params { get; set; }
            public class DescribeVariableBindDetailResponseBodyResultObjectParams : TeaModel {
                [NameInMap("eventFieldName")]
                [Validation(Required=false)]
                public string EventFieldName { get; set; }

                [NameInMap("required")]
                [Validation(Required=false)]
                public bool? Required { get; set; }

                [NameInMap("variableName")]
                [Validation(Required=false)]
                public string VariableName { get; set; }

            }

            [NameInMap("relationRules")]
            [Validation(Required=false)]
            public List<DescribeVariableBindDetailResponseBodyResultObjectRelationRules> RelationRules { get; set; }
            public class DescribeVariableBindDetailResponseBodyResultObjectRelationRules : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

    }

}
