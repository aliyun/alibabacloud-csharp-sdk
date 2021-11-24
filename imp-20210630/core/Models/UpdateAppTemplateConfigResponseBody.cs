// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class UpdateAppTemplateConfigResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateAppTemplateConfigResponseBodyResult Result { get; set; }
        public class UpdateAppTemplateConfigResponseBodyResult : TeaModel {
            [NameInMap("ConfigLogs")]
            [Validation(Required=false)]
            public List<UpdateAppTemplateConfigResponseBodyResultConfigLogs> ConfigLogs { get; set; }
            public class UpdateAppTemplateConfigResponseBodyResultConfigLogs : TeaModel {
                public string Code { get; set; }
                public string Message { get; set; }
            }
        };

    }

}
