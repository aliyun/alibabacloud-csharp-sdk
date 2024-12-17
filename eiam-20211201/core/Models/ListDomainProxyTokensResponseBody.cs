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
            /// <para>域名代理Token创建时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>域名ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dm_examplexxxx</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>域名代理Token。</para>
            /// 
            /// <b>Example:</b>
            /// <para>PTxxxxxxxx</para>
            /// </summary>
            [NameInMap("DomainProxyToken")]
            [Validation(Required=false)]
            public string DomainProxyToken { get; set; }

            /// <summary>
            /// <para>域名代理Token ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>pt_examplexxxx</para>
            /// </summary>
            [NameInMap("DomainProxyTokenId")]
            [Validation(Required=false)]
            public string DomainProxyTokenId { get; set; }

            /// <summary>
            /// <para>实例ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>域名代理Token最近使用时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// <para>token状态，枚举类型：(enabled）启用,（disabled）禁用。</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>域名代理Token最近更新时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
