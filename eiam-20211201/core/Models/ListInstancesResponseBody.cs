// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance information.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyInstances> Instances { get; set; }
        public class ListInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The creation time of the instance, in Unix timestamp format, in milliseconds.</para>
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
            /// <para>The default endpoint of the instance.</para>
            /// </summary>
            [NameInMap("DefaultEndpoint")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesDefaultEndpoint DefaultEndpoint { get; set; }
            public class ListInstancesResponseBodyInstancesDefaultEndpoint : TeaModel {
                /// <summary>
                /// <para>The endpoint address of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example-xxx.aliyunidaas.com</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>The status of the instance endpoint. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>resolved: Resolved.</description></item>
                /// <item><description>unresolved: Unresolved.</description></item>
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
            /// <b>Example:</b>
            /// <para>inactive</para>
            /// </summary>
            [NameInMap("InstanceFailoverStatus")]
            [Validation(Required=false)]
            public string InstanceFailoverStatus { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_eypq6ljgyeuwmlw672sulxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The service code of the cloud service that manages the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sase</para>
            /// </summary>
            [NameInMap("ManagedServiceCode")]
            [Validation(Required=false)]
            public string ManagedServiceCode { get; set; }

            [NameInMap("ReplicationConfiguration")]
            [Validation(Required=false)]
            public ListInstancesResponseBodyInstancesReplicationConfiguration ReplicationConfiguration { get; set; }
            public class ListInstancesResponseBodyInstancesReplicationConfiguration : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>idaas_xxxxxx</para>
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
                /// <para>idaas_xxxxxx</para>
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
            /// <para>Indicates whether the instance is managed by a cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ServiceManaged")]
            [Validation(Required=false)]
            public bool? ServiceManaged { get; set; }

            /// <summary>
            /// <para>Instance status. Valid values:</para>
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
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
