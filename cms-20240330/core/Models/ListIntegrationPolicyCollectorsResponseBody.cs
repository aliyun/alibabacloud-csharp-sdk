// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyCollectorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of collectors.</para>
        /// </summary>
        [NameInMap("collectors")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyCollectorsResponseBodyCollectors> Collectors { get; set; }
        public class ListIntegrationPolicyCollectorsResponseBodyCollectors : TeaModel {
            /// <summary>
            /// <para>The add-on details.</para>
            /// </summary>
            [NameInMap("addonMeta")]
            [Validation(Required=false)]
            public AddonMeta AddonMeta { get; set; }

            /// <summary>
            /// <para>The collector name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>collector-kkxx</para>
            /// </summary>
            [NameInMap("collectorName")]
            [Validation(Required=false)]
            public string CollectorName { get; set; }

            /// <summary>
            /// <para>The collector type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Exporter</para>
            /// </summary>
            [NameInMap("collectorType")]
            [Validation(Required=false)]
            public string CollectorType { get; set; }

            /// <summary>
            /// <para>The phase status.</para>
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyCollectorsResponseBodyCollectorsConditions> Conditions { get; set; }
            public class ListIntegrationPolicyCollectorsResponseBodyCollectorsConditions : TeaModel {
                /// <summary>
                /// <para>The time of the first transition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-27T13:59:23+08:00</para>
                /// </summary>
                [NameInMap("firstTransitionTime")]
                [Validation(Required=false)]
                public string FirstTransitionTime { get; set; }

                /// <summary>
                /// <para>The time of the last transition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-27T13:59:23+08:00</para>
                /// </summary>
                [NameInMap("lastTransitionTime")]
                [Validation(Required=false)]
                public string LastTransitionTime { get; set; }

                /// <summary>
                /// <para>The details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The reason for the failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Probe</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The phase status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The phase type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the component is a managed component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            /// <summary>
            /// <para>The name of the add-on release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-loong-collector-i-f8z1176fg57rlwmc1rfi</para>
            /// </summary>
            [NameInMap("releaseName")]
            [Validation(Required=false)]
            public string ReleaseName { get; set; }

            /// <summary>
            /// <para>The collector status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The component version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.6.2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The list of workloads.</para>
            /// </summary>
            [NameInMap("workloads")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloads> Workloads { get; set; }
            public class ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloads : TeaModel {
                /// <summary>
                /// <para>The host IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.10.10.10</para>
                /// </summary>
                [NameInMap("hostIp")]
                [Validation(Required=false)]
                public string HostIp { get; set; }

                /// <summary>
                /// <para>The IP address of the workload.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11.193.82.198</para>
                /// </summary>
                [NameInMap("ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>Indicates whether the component is a managed component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("managed")]
                [Validation(Required=false)]
                public bool? Managed { get; set; }

                /// <summary>
                /// <para>The policy management information.</para>
                /// </summary>
                [NameInMap("managedInfo")]
                [Validation(Required=false)]
                public ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloadsManagedInfo ManagedInfo { get; set; }
                public class ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloadsManagedInfo : TeaModel {
                    /// <summary>
                    /// <para>The security group ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-xxxxx</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-xxxxxx</para>
                    /// </summary>
                    [NameInMap("vswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

                /// <summary>
                /// <para>The details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The workload name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exporter-xxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The workload namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>prod-db</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The kind of the parent reference.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Deployment</para>
                /// </summary>
                [NameInMap("ownerReferenceKind")]
                [Validation(Required=false)]
                public string OwnerReferenceKind { get; set; }

                /// <summary>
                /// <para>The name of the parent reference.</para>
                /// 
                /// <b>Example:</b>
                /// <para>exporter</para>
                /// </summary>
                [NameInMap("ownerReferenceName")]
                [Validation(Required=false)]
                public string OwnerReferenceName { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-27T13:59:23+08:00</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The workload version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2.4.4</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
