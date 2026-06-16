// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name object.</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public GetDomainResponseBodyDomain Domain { get; set; }
        public class GetDomainResponseBodyDomain : TeaModel {
            /// <summary>
            /// <para>The ID of the brand.</para>
            /// 
            /// <b>Example:</b>
            /// <para>brand_xxxxx</para>
            /// </summary>
            [NameInMap("BrandId")]
            [Validation(Required=false)]
            public string BrandId { get; set; }

            /// <summary>
            /// <para>The time when the domain name was created. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether the domain name is the default domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DefaultDomain")]
            [Validation(Required=false)]
            public bool? DefaultDomain { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login.example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The ID of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dm_examplexxxxx</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The type of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>system_init: The initial domain name.</para>
            /// </description></item>
            /// <item><description><para>user_custom: A custom domain name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system_init</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The ICP filing information about the domain name.</para>
            /// </summary>
            [NameInMap("Filing")]
            [Validation(Required=false)]
            public GetDomainResponseBodyDomainFiling Filing { get; set; }
            public class GetDomainResponseBodyDomainFiling : TeaModel {
                /// <summary>
                /// <para>The ICP filing number that is associated with the domain name. The ICP filing number can be for an entity or a website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xICPxxxxxx-xx</para>
                /// </summary>
                [NameInMap("IcpNumber")]
                [Validation(Required=false)]
                public string IcpNumber { get; set; }

            }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The lock status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>unlock: Normal.</para>
            /// </description></item>
            /// <item><description><para>lockByLicense: The domain name is unavailable due to license restrictions.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The time when the domain name was last updated. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
