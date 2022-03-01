// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class CreateGroupResponseBody : TeaModel {
        /// <summary>
        /// 返回数据
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateGroupResponseBodyData Data { get; set; }
        public class CreateGroupResponseBodyData : TeaModel {
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }
            [NameInMap("Column")]
            [Validation(Required=false)]
            public string Column { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("InferenceJobId")]
            [Validation(Required=false)]
            public string InferenceJobId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("Source")]
            [Validation(Required=false)]
            public int? Source { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("Table")]
            [Validation(Required=false)]
            public string Table { get; set; }
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }
        };

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
