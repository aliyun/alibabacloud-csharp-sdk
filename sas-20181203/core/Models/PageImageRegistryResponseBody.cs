// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PageImageRegistryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<PageImageRegistryResponseBodyList> List { get; set; }
        public class PageImageRegistryResponseBodyList : TeaModel {
            /// <summary>
            /// 阿里用户Id
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// 黑名单
            /// </summary>
            [NameInMap("BlackList")]
            [Validation(Required=false)]
            public string BlackList { get; set; }

            /// <summary>
            /// 域名
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// 创建日期
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// 更改日期
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// 唯一ID
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 包含的镜像数量
            /// </summary>
            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public int? ImageCount { get; set; }

            [NameInMap("JenkinsEnv")]
            [Validation(Required=false)]
            public string JenkinsEnv { get; set; }

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
            /// 资产保存天数
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
            /// 镜像仓库别名
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
            /// token 用户的唯一标识
            /// </summary>
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            /// <summary>
            /// 每小时扫描任务数
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
            /// vpcId
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public PageImageRegistryResponseBodyPageInfo PageInfo { get; set; }
        public class PageImageRegistryResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
