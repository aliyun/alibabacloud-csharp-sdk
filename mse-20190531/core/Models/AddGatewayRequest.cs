// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 是否开启硬件加速
        /// </summary>
        [NameInMap("EnableHardwareAcceleration")]
        [Validation(Required=false)]
        public bool? EnableHardwareAcceleration { get; set; }

        /// <summary>
        /// 是否开启SLS日志投递
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// 是否开启xtrace
        /// </summary>
        [NameInMap("EnableXtrace")]
        [Validation(Required=false)]
        public bool? EnableXtrace { get; set; }

        /// <summary>
        /// 是否企业安全组类型
        /// </summary>
        [NameInMap("EnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? EnterpriseSecurityGroup { get; set; }

        /// <summary>
        /// 外网SLB规格
        /// </summary>
        [NameInMap("InternetSlbSpec")]
        [Validation(Required=false)]
        public string InternetSlbSpec { get; set; }

        /// <summary>
        /// 网关名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// 节点数量
        /// </summary>
        [NameInMap("Replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        /// <summary>
        /// 内网SLB规格
        /// </summary>
        [NameInMap("SlbSpec")]
        [Validation(Required=false)]
        public string SlbSpec { get; set; }

        /// <summary>
        /// 节点规格
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// 主交换机ID
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// 备交换机ID
        /// </summary>
        [NameInMap("VSwitchId2")]
        [Validation(Required=false)]
        public string VSwitchId2 { get; set; }

        /// <summary>
        /// 专有网络ID
        /// </summary>
        [NameInMap("Vpc")]
        [Validation(Required=false)]
        public string Vpc { get; set; }

        /// <summary>
        /// xtrace采样率，取值[0,100]
        /// </summary>
        [NameInMap("XtraceRatio")]
        [Validation(Required=false)]
        public string XtraceRatio { get; set; }

    }

}
