// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateHealthCheckTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// 幂等参数
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [NameInMap("HealthCheckTemplateName")]
        [Validation(Required=false)]
        public string HealthCheckTemplateName { get; set; }

        /// <summary>
        /// 端口号
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("HealthCheckCodes")]
        [Validation(Required=false)]
        public List<string> HealthCheckCodes { get; set; }

        /// <summary>
        /// 时间间隔
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// uri
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [NameInMap("HealthCheckProtocol")]
        [Validation(Required=false)]
        public string HealthCheckProtocol { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// 健康阈值
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// 不健康阈值
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// dryRun
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 健康检查模板ID
        /// </summary>
        [NameInMap("HealthCheckTemplateId")]
        [Validation(Required=false)]
        public string HealthCheckTemplateId { get; set; }

    }

}
