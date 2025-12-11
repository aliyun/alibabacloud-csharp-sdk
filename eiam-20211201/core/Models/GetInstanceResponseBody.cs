// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the instance.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1550115455000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The default endpoint of the instance.</para>
            /// </summary>
            [NameInMap("DefaultEndpoint")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceDefaultEndpoint DefaultEndpoint { get; set; }
            public class GetInstanceResponseBodyInstanceDefaultEndpoint : TeaModel {
                /// <summary>
                /// <para>The endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-xxx.aliyunidaas.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The status of the endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>resolved</description></item>
                /// <item><description>unresolved</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>resolved</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The description of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The default domain of the instance.</para>
            /// </summary>
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceDomainConfig DomainConfig { get; set; }
            public class GetInstanceResponseBodyInstanceDomainConfig : TeaModel {
                /// <summary>
                /// <para>The default domain of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-xxx.example.com</para>
                /// </summary>
                [NameInMap("DefaultDomain")]
                [Validation(Required=false)]
                public string DefaultDomain { get; set; }

                /// <summary>
                /// <para>The init domain of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-xxx.aliyunidaas.com</para>
                /// </summary>
                [NameInMap("InitDomain")]
                [Validation(Required=false)]
                public string InitDomain { get; set; }

                /// <summary>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("InitDomainAutoRedirectStatus")]
                [Validation(Required=false)]
                public string InitDomainAutoRedirectStatus { get; set; }

            }

            /// <summary>
            /// <para>The outbound public CIDR blocks of the instance. For example, when you synchronize Active Directory (AD) accounts, the IDaaS EIAM instance accesses your AD service by using the outbound public CIDR blocks.</para>
            /// </summary>
            [NameInMap("EgressAddresses")]
            [Validation(Required=false)]
            public List<string> EgressAddresses { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_abt3pfwojojcq323si6g5xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sase</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            /// <summary>
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>creating</description></item>
            /// <item><description>running</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
