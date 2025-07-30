// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<ListDomainsResponseBodyDomains> Domains { get; set; }
        public class ListDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The time when the domain name was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the domain name is the default domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DefaultDomain")]
            [Validation(Required=false)]
            public bool? DefaultDomain { get; set; }

            /// <summary>
            /// <para>The domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The domain ID.</para>
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
            /// <item><description>system_init: an initial domain name.</description></item>
            /// <item><description>user_custom: a custom domain name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system_init</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>The information about the Internet content provider (ICP) filing of the domain name.</para>
            /// </summary>
            [NameInMap("Filing")]
            [Validation(Required=false)]
            public ListDomainsResponseBodyDomainsFiling Filing { get; set; }
            public class ListDomainsResponseBodyDomainsFiling : TeaModel {
                /// <summary>
                /// <para>The ICP number associated with the domain name. Both the entity ICP number and website ICP number are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhexx-xxxxxx</para>
                /// </summary>
                [NameInMap("IcpNumber")]
                [Validation(Required=false)]
                public string IcpNumber { get; set; }

            }

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
            /// <para>Indicates whether the domain name is locked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>unlock</description></item>
            /// <item><description>lockByLicense</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The time when the domain name was last updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
