// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageRegistryRequest : TeaModel {
        /// <summary>
        /// 主机域名
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// 镜像仓库附加参数
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 网络类型 1：公网 2：vpc
        /// </summary>
        [NameInMap("NetType")]
        [Validation(Required=false)]
        public int? NetType { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// 资产有效天数
        /// </summary>
        [NameInMap("PersistenceDay")]
        [Validation(Required=false)]
        public int? PersistenceDay { get; set; }

        /// <summary>
        /// 协议类型 1：http 2:https
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public int? ProtocolType { get; set; }

        /// <summary>
        /// 镜像仓库所在的regionId
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 主机Ip地址
        /// </summary>
        [NameInMap("RegistryHostIp")]
        [Validation(Required=false)]
        public string RegistryHostIp { get; set; }

        /// <summary>
        /// 镜像仓别名
        /// </summary>
        [NameInMap("RegistryName")]
        [Validation(Required=false)]
        public string RegistryName { get; set; }

        /// <summary>
        /// 容器镜像服务类型 harbor，quory
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// 私有库版本
        /// </summary>
        [NameInMap("RegistryVersion")]
        [Validation(Required=false)]
        public string RegistryVersion { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// 每小时扫描的镜像数
        /// </summary>
        [NameInMap("TransPerHour")]
        [Validation(Required=false)]
        public int? TransPerHour { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// vpcId 类型
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// 白名单
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public string WhiteList { get; set; }

    }

}
