// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class GetInstancePublishTaskStateResponseBody : TeaModel {
        /// <summary>
        /// 业务类型列表
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        /// <summary>
        /// 任务创建的 UTC 时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// job失败信息
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// 各子发布模块的错误信息，key是子发布模块，value是错误信息
        /// </summary>
        [NameInMap("Errors")]
        [Validation(Required=false)]
        public Dictionary<string, object> Errors { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// 任务修改的 UTC 时间
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 任务Id
        /// </summary>
        [NameInMap("Response")]
        [Validation(Required=false)]
        public string Response { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 各子发布模块的警告信息，key是子发布模块，value是警告信息
        /// </summary>
        [NameInMap("Warnings")]
        [Validation(Required=false)]
        public Dictionary<string, object> Warnings { get; set; }

    }

}
