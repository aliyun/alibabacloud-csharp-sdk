// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListInspectionHistoryResponseBody : TeaModel {
        /// <summary>
        /// Created on 2023/8/21
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListInspectionHistoryResponseBodyData> Data { get; set; }
        public class ListInspectionHistoryResponseBodyData : TeaModel {
            /// <summary>
            /// 变更消息
            /// </summary>
            [NameInMap("ChangeMessage")]
            [Validation(Required=false)]
            public string ChangeMessage { get; set; }

            /// <summary>
            /// 巡检状态
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// 巡检变更明细
            /// </summary>
            [NameInMap("InspectionItems")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> InspectionItems { get; set; }

            [NameInMap("ReportTime")]
            [Validation(Required=false)]
            public string ReportTime { get; set; }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
