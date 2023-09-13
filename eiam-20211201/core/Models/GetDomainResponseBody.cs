// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetDomainResponseBody : TeaModel {
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public GetDomainResponseBodyDomain Domain { get; set; }
        public class GetDomainResponseBodyDomain : TeaModel {
            /// <summary>
            /// 域名创建时间，Unix时间戳格式，单位为毫秒。
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 是否默认域名。true表示实例默认域名，false表示非默认域名
            /// </summary>
            [NameInMap("DefaultDomain")]
            [Validation(Required=false)]
            public bool? DefaultDomain { get; set; }

            /// <summary>
            /// 域名。
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// 域名ID。
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// 域名类型。枚举取值:system_init(系统初始化)、user_custom(用户自定义)。
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// 域名备案信息。
            /// </summary>
            [NameInMap("Filing")]
            [Validation(Required=false)]
            public GetDomainResponseBodyDomainFiling Filing { get; set; }
            public class GetDomainResponseBodyDomainFiling : TeaModel {
                /// <summary>
                /// 域名关联的备案号, 长度最大限制64。
                /// </summary>
                [NameInMap("IcpNumber")]
                [Validation(Required=false)]
                public string IcpNumber { get; set; }

            }

            /// <summary>
            /// 实例ID。
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 域名锁定状态。枚举取值:unlock(正常)、lockByLicense(因License限制不可用)。
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// 域名最近更新时间，Unix时间戳格式，单位为毫秒。
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
