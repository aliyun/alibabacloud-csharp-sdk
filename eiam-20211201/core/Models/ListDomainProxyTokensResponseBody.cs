// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListDomainProxyTokensResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of domain proxy token objects.</para>
        /// </summary>
        [NameInMap("DomainProxyTokens")]
        [Validation(Required=false)]
        public List<ListDomainProxyTokensResponseBodyDomainProxyTokens> DomainProxyTokens { get; set; }
        public class ListDomainProxyTokensResponseBodyDomainProxyTokens : TeaModel {
            /// <summary>
            /// <para>The creation time of the domain proxy token, in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The domain ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dm_examplexxxx</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The domain proxy token.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PTxxxxxxxx</para>
            /// </summary>
            [NameInMap("DomainProxyToken")]
            [Validation(Required=false)]
            public string DomainProxyToken { get; set; }

            /// <summary>
            /// <para>The domain proxy token ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pt_examplexxxx</para>
            /// </summary>
            [NameInMap("DomainProxyTokenId")]
            [Validation(Required=false)]
            public string DomainProxyTokenId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The most recent usage time of the domain proxy token, in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public long? LastUsedTime { get; set; }

            /// <summary>
            /// <para>The token status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: The token is enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: The token is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The most recent update time of the domain proxy token, in Unix timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
