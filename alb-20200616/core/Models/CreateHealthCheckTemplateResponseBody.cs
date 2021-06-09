// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateHealthCheckTemplateResponseBody : TeaModel {
        /// <summary>
        /// 健康检查模板ID
        /// </summary>
        [NameInMap("HealthCheckTemplateId")]
        [Validation(Required=false)]
        public string HealthCheckTemplateId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
