// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class GetInferenceJobResponseBody : TeaModel {
        /// <summary>
        /// 返回数据
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInferenceJobResponseBodyData Data { get; set; }
        public class GetInferenceJobResponseBodyData : TeaModel {
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }
            [NameInMap("History")]
            [Validation(Required=false)]
            public string History { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("TrainingJobId")]
            [Validation(Required=false)]
            public string TrainingJobId { get; set; }
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }
            [NameInMap("UserConfig")]
            [Validation(Required=false)]
            public string UserConfig { get; set; }
        };

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
