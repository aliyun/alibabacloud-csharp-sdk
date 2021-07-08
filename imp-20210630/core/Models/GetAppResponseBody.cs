// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class GetAppResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetAppResponseBodyResult Result { get; set; }
        public class GetAppResponseBodyResult : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("AppTemplateId")]
            [Validation(Required=false)]
            public string AppTemplateId { get; set; }
            [NameInMap("AppTemplateName")]
            [Validation(Required=false)]
            public string AppTemplateName { get; set; }
            [NameInMap("AppStatus")]
            [Validation(Required=false)]
            public string AppStatus { get; set; }
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("ComponentList")]
            [Validation(Required=false)]
            public List<string> ComponentList { get; set; }
        };

    }

}
