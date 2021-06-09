// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateServerGroupResponseBody : TeaModel {
        /// <summary>
        /// 异步任务Id
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务器组id
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

    }

}
