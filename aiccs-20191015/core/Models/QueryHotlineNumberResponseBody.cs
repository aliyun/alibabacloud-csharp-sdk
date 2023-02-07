// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryHotlineNumberResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryHotlineNumberResponseBodyData Data { get; set; }
        public class QueryHotlineNumberResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }

            [NameInMap("HotlineNumList")]
            [Validation(Required=false)]
            public List<QueryHotlineNumberResponseBodyDataHotlineNumList> HotlineNumList { get; set; }
            public class QueryHotlineNumberResponseBodyDataHotlineNumList : TeaModel {
                [NameInMap("CalloutAllDepartment")]
                [Validation(Required=false)]
                public bool? CalloutAllDepartment { get; set; }

                [NameInMap("CalloutRangeList")]
                [Validation(Required=false)]
                public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList> CalloutRangeList { get; set; }
                public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList : TeaModel {
                    [NameInMap("DepartmentId")]
                    [Validation(Required=false)]
                    public long? DepartmentId { get; set; }

                    [NameInMap("DepartmentName")]
                    [Validation(Required=false)]
                    public string DepartmentName { get; set; }

                    [NameInMap("GroupDOList")]
                    [Validation(Required=false)]
                    public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList> GroupDOList { get; set; }
                    public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList : TeaModel {
                        [NameInMap("GroupId")]
                        [Validation(Required=false)]
                        public long? GroupId { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                    }

                }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EvaluationStatus")]
                [Validation(Required=false)]
                public int? EvaluationStatus { get; set; }

                [NameInMap("FlowId")]
                [Validation(Required=false)]
                public long? FlowId { get; set; }

                [NameInMap("FlowName")]
                [Validation(Required=false)]
                public string FlowName { get; set; }

                [NameInMap("HotlineNumber")]
                [Validation(Required=false)]
                public string HotlineNumber { get; set; }

                [NameInMap("InBoundEnabled")]
                [Validation(Required=false)]
                public bool? InBoundEnabled { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("OutboundEnabled")]
                [Validation(Required=false)]
                public bool? OutboundEnabled { get; set; }

                [NameInMap("Sp")]
                [Validation(Required=false)]
                public string Sp { get; set; }

            }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
