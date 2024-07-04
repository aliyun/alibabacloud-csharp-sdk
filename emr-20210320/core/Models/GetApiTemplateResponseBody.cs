// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetApiTemplateResponseBody : TeaModel {
        /// <summary>
        /// The content of the API operation template.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        [Obsolete]
        public ApiTemplate Data { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
