// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class Service : TeaModel {
        /// <summary>
        /// 服务的请求Token
        /// </summary>
        [NameInMap("AccessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 服务创建账号的UID
        /// </summary>
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// 每个实例申请的cpu
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// 服务的创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 当前运行的模型版本
        /// </summary>
        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public int? CurrentVersion { get; set; }

        /// <summary>
        /// 每个实例申请的gpu
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// 服务的数据镜像
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// 服务的公网endpoint
        /// </summary>
        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        /// <summary>
        /// 服务内网endpoint
        /// </summary>
        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        /// <summary>
        /// 服务最新版本号
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public int? LatestVersion { get; set; }

        /// <summary>
        /// 每个worker需要的内存大小，单位为M
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// 服务的摘要信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 服务所在的命名空间
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// 服务创建账号的主账号UID
        /// </summary>
        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        /// <summary>
        /// 被挂起的服务的实例个数
        /// </summary>
        [NameInMap("PendingInstance")]
        [Validation(Required=false)]
        public int? PendingInstance { get; set; }

        /// <summary>
        /// 服务的状态信息
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// 服务所在的区域
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务所在的资源组
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        /// <summary>
        /// 正在运行的服务的实例个数
        /// </summary>
        [NameInMap("RunningInstance")]
        [Validation(Required=false)]
        public int? RunningInstance { get; set; }

        /// <summary>
        /// 服务的配置信息
        /// </summary>
        [NameInMap("ServiceConfig")]
        [Validation(Required=false)]
        public string ServiceConfig { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 服务的名字
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务的状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 服务的所有实例总个数
        /// </summary>
        [NameInMap("TotalInstance")]
        [Validation(Required=false)]
        public int? TotalInstance { get; set; }

        /// <summary>
        /// 服务的更新时间
        /// </summary>
        [NameInMap("Updatetime")]
        [Validation(Required=false)]
        public string Updatetime { get; set; }

        /// <summary>
        /// 服务灰度发布的权重值
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public int? Weight { get; set; }

    }

}
