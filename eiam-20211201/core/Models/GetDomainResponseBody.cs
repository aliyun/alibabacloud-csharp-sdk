// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public GetDomainResponseBodyDomain Domain { get; set; }
        public class GetDomainResponseBodyDomain : TeaModel {
            /// <summary>
            /// <para>The start time when the change order was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830226000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Whether it is the default domain.</para>
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
            /// <para>login.example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Domain ID.</para>
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
            /// <item><description><b>system_init</b>: Initialize domain</description></item>
            /// <item><description><b>user_custom</b>: user custom domain</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system_init</para>
            /// </summary>
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            /// <summary>
            /// <para>Domain registration information.</para>
            /// </summary>
            [NameInMap("Filing")]
            [Validation(Required=false)]
            public GetDomainResponseBodyDomainFiling Filing { get; set; }
            public class GetDomainResponseBodyDomainFiling : TeaModel {
                /// <summary>
                /// <para><notice>The ICP filing number is only applicable for services in the China region.  For non-China regions, no validation or display of this record number will be performed.</notice>
                /// The ICP filing number associated with the domain name, with a maximum length of 64 characters.</para>
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
            /// <para>The lock status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unlock</b>: The instance is normal.</description></item>
            /// <item><description><b>lockByLicense</b>: Not available due to license restrictions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The time when the service was updated.</para>
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
