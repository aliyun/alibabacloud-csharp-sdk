// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListDomainProxyTokensResponseBody : TeaModel {
        [NameInMap("DomainProxyTokens")]
        [Validation(Required=false)]
        public List<ListDomainProxyTokensResponseBodyDomainProxyTokens> DomainProxyTokens { get; set; }
        public class ListDomainProxyTokensResponseBodyDomainProxyTokens : TeaModel {
            /// <summary>
            /// 域名代理Token创建时间，Unix时间戳格式，单位为毫秒。
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 域名ID。
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// 域名代理Token。
            /// </summary>
            [NameInMap("DomainProxyToken")]
            [Validation(Required=false)]
            public string DomainProxyToken { get; set; }

            /// <summary>
            /// 域名代理Token ID。
            /// </summary>
            [NameInMap("DomainProxyTokenId")]
            [Validation(Required=false)]
            public string DomainProxyTokenId { get; set; }

            /// <summary>
            /// 实例ID。
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 域名代理Token最近使用时间，Unix时间戳格式，单位为毫秒。
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// token状态，枚举类型：(enabled）启用,（disabled）禁用。
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 域名代理Token最近更新时间，Unix时间戳格式，单位为毫秒。
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
