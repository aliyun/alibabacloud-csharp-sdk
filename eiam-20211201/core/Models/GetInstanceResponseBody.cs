// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance information.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public GetInstanceResponseBodyInstance Instance { get; set; }
        public class GetInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>The time when the instance was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1550115455000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("CrossRegionReplication")]
            [Validation(Required=false)]
            public string CrossRegionReplication { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>primary</para>
            /// </summary>
            [NameInMap("CrossRegionReplicationRole")]
            [Validation(Required=false)]
            public string CrossRegionReplicationRole { get; set; }

            /// <summary>
            /// <para>The default domain name of the instance. This field is no longer maintained. Use the DomainConfig fields or refer to the query domain name list operation instead.</para>
            /// </summary>
            [NameInMap("DefaultEndpoint")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceDefaultEndpoint DefaultEndpoint { get; set; }
            public class GetInstanceResponseBodyInstanceDefaultEndpoint : TeaModel {
                /// <summary>
                /// <para>The domain name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-xxx.aliyunidaas.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The status of the instance domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>resolved: Resolved.</description></item>
                /// <item><description>unresolved: Not resolved.</description></item>
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
            /// <para>instance_for_test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The domain name configuration of the instance.</para>
            /// </summary>
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceDomainConfig DomainConfig { get; set; }
            public class GetInstanceResponseBodyInstanceDomainConfig : TeaModel {
                /// <summary>
                /// <para>The default domain name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>login.example.com</para>
                /// </summary>
                [NameInMap("DefaultDomain")]
                [Validation(Required=false)]
                public string DefaultDomain { get; set; }

                /// <summary>
                /// <para>The initialization domain name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rx72nxxx.example.com</para>
                /// </summary>
                [NameInMap("InitDomain")]
                [Validation(Required=false)]
                public string InitDomain { get; set; }

                /// <summary>
                /// <para>The automatic redirect status of the initialization domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>enabled: Enabled.</para>
                /// </description></item>
                /// <item><description><para>disabled: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>disabled</para>
                /// </summary>
                [NameInMap("InitDomainAutoRedirectStatus")]
                [Validation(Required=false)]
                public string InitDomainAutoRedirectStatus { get; set; }

            }

            /// <summary>
            /// <para>The public egress CIDR blocks of the instance. For example, during Active Directory (AD) account synchronization, the EIAM instance accesses your AD server through these public CIDR blocks.</para>
            /// </summary>
            [NameInMap("EgressAddresses")]
            [Validation(Required=false)]
            public List<string> EgressAddresses { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>inactive</para>
            /// </summary>
            [NameInMap("InstanceFailoverStatus")]
            [Validation(Required=false)]
            public string InstanceFailoverStatus { get; set; }

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
            /// <para>The ServiceCode of the Alibaba Cloud service that manages the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sase</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            [NameInMap("ReplicationConfiguration")]
            [Validation(Required=false)]
            public GetInstanceResponseBodyInstanceReplicationConfiguration ReplicationConfiguration { get; set; }
            public class GetInstanceResponseBodyInstanceReplicationConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>idaas_xxxx</para>
                /// </summary>
                [NameInMap("BackupInstanceId")]
                [Validation(Required=false)]
                public string BackupInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("BackupInstanceRegionId")]
                [Validation(Required=false)]
                public string BackupInstanceRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>idaas_xxxx</para>
                /// </summary>
                [NameInMap("PrimaryInstanceId")]
                [Validation(Required=false)]
                public string PrimaryInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("PrimaryInstanceRegionId")]
                [Validation(Required=false)]
                public string PrimaryInstanceRegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1778499337000</para>
                /// </summary>
                [NameInMap("ReplicationCreateTime")]
                [Validation(Required=false)]
                public long? ReplicationCreateTime { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the instance is managed by an Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>false</c>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>The instance status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>creating: Being created.</description></item>
            /// <item><description>running: Running.</description></item>
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
