// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class QueryHotlineNumberResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 返回结果数据
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryHotlineNumberResponseBodyData Data { get; set; }
        public class QueryHotlineNumberResponseBodyData : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("HotlineNumList")]
            [Validation(Required=false)]
            public List<QueryHotlineNumberResponseBodyDataHotlineNumList> HotlineNumList { get; set; }
            public class QueryHotlineNumberResponseBodyDataHotlineNumList : TeaModel {
                public string HotlineNumber { get; set; }
                public string Description { get; set; }
                public string Location { get; set; }
                public string Sp { get; set; }
                public bool? InBoundEnabled { get; set; }
                public long? FlowId { get; set; }
                public string FlowName { get; set; }
                public bool? OutboundEnabled { get; set; }
                public bool? CalloutAllDepartment { get; set; }
                public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList> CalloutRangeList { get; set; }
                public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeList : TeaModel {
                    public long? DepartmentId { get; set; }
                    public string DepartmentName { get; set; }
                    public List<QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList> GroupDOList { get; set; }
                    public class QueryHotlineNumberResponseBodyDataHotlineNumListCalloutRangeListGroupDOList : TeaModel {
                        public long? GroupId { get; set; }
                        public string GroupName { get; set; }
                    }
                }
                public int? EvaluationStatus { get; set; }
            }
        };

    }

}
