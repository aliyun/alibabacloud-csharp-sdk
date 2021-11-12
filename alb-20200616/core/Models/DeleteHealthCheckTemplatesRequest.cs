// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DeleteHealthCheckTemplatesRequest : TeaModel {
        /// <summary>
        /// 幂等token
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// dryRun
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 健康检查模板Id列表
        /// </summary>
        [NameInMap("HealthCheckTemplateIds")]
        [Validation(Required=false)]
        public List<string> HealthCheckTemplateIds { get; set; }

    }

}
