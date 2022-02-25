// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SubmitImageAnalysisOutputRequest : TeaModel {
        /// <summary>
        /// 等同 msgBody
        /// </summary>
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// 是否gzip压缩
        /// </summary>
        [NameInMap("IsCompress")]
        [Validation(Required=false)]
        public bool? IsCompress { get; set; }

        /// <summary>
        /// 是否加密
        /// </summary>
        [NameInMap("IsEncrypt")]
        [Validation(Required=false)]
        public bool? IsEncrypt { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 任务 id
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// 等同 handler code
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
