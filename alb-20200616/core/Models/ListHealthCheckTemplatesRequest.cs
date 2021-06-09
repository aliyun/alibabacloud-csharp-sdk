// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListHealthCheckTemplatesRequest : TeaModel {
        /// <summary>
        /// 分页查询标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询数量
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 健康检查模板ID列表
        /// </summary>
        [NameInMap("HealthCheckTemplateIds")]
        [Validation(Required=false)]
        public List<string> HealthCheckTemplateIds { get; set; }

        /// <summary>
        /// 健康检查模板名称列表
        /// </summary>
        [NameInMap("HealthCheckTemplateNames")]
        [Validation(Required=false)]
        public List<string> HealthCheckTemplateNames { get; set; }

    }

}
