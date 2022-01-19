// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateNacosClusterRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 健康检查端口
        /// </summary>
        [NameInMap("CheckPort")]
        [Validation(Required=false)]
        public int? CheckPort { get; set; }

        /// <summary>
        /// Nacos集群名
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// 分组名
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// 健康检查类型
        /// </summary>
        [NameInMap("HealthChecker")]
        [Validation(Required=false)]
        public string HealthChecker { get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 命名空间id
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 是否使用实例端口进行健康检查
        /// </summary>
        [NameInMap("UseInstancePortForCheck")]
        [Validation(Required=false)]
        public bool? UseInstancePortForCheck { get; set; }

    }

}
