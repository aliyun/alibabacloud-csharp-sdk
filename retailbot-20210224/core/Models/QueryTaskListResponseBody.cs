// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RetailBot20210224.Models
{
    public class QueryTaskListResponseBody : TeaModel {
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

        [NameInMap("PageData")]
        [Validation(Required=false)]
        public QueryTaskListResponseBodyPageData PageData { get; set; }
        public class QueryTaskListResponseBodyPageData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<QueryTaskListResponseBodyPageDataData> Data { get; set; }
            public class QueryTaskListResponseBodyPageDataData : TeaModel {
                public string OperateDate { get; set; }
                public string ParamConfig { get; set; }
                public string RobotCode { get; set; }
                public long? Status { get; set; }
                public long? TaskId { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

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

    }

}
