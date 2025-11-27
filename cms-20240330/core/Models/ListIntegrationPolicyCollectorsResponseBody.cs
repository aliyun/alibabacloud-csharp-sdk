// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyCollectorsResponseBody : TeaModel {
        [NameInMap("collectors")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyCollectorsResponseBodyCollectors> Collectors { get; set; }
        public class ListIntegrationPolicyCollectorsResponseBodyCollectors : TeaModel {
            [NameInMap("addonMeta")]
            [Validation(Required=false)]
            public AddonMeta AddonMeta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>collector-kkxx</para>
            /// </summary>
            [NameInMap("collectorName")]
            [Validation(Required=false)]
            public string CollectorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Exporter</para>
            /// </summary>
            [NameInMap("collectorType")]
            [Validation(Required=false)]
            public string CollectorType { get; set; }

            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyCollectorsResponseBodyCollectorsConditions> Conditions { get; set; }
            public class ListIntegrationPolicyCollectorsResponseBodyCollectorsConditions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-27T13:59:23+08:00</para>
                /// </summary>
                [NameInMap("firstTransitionTime")]
                [Validation(Required=false)]
                public string FirstTransitionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-27T13:59:23+08:00</para>
                /// </summary>
                [NameInMap("lastTransitionTime")]
                [Validation(Required=false)]
                public string LastTransitionTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Probe</para>
                /// </summary>
                [NameInMap("reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Ready</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("managed")]
            [Validation(Required=false)]
            public bool? Managed { get; set; }

            [NameInMap("releaseName")]
            [Validation(Required=false)]
            public string ReleaseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.6.2</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("workloads")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloads> Workloads { get; set; }
            public class ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloads : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10.10.10.10</para>
                /// </summary>
                [NameInMap("hostIp")]
                [Validation(Required=false)]
                public string HostIp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11.193.82.198</para>
                /// </summary>
                [NameInMap("ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("managed")]
                [Validation(Required=false)]
                public bool? Managed { get; set; }

                [NameInMap("managedInfo")]
                [Validation(Required=false)]
                public ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloadsManagedInfo ManagedInfo { get; set; }
                public class ListIntegrationPolicyCollectorsResponseBodyCollectorsWorkloadsManagedInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sg-xxxxx</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vsw-xxxxxx</para>
                    /// </summary>
                    [NameInMap("vswitchId")]
                    [Validation(Required=false)]
                    public string VswitchId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exporter-xxx</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>prod-db</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Deployment</para>
                /// </summary>
                [NameInMap("ownerReferenceKind")]
                [Validation(Required=false)]
                public string OwnerReferenceKind { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>exporter</para>
                /// </summary>
                [NameInMap("ownerReferenceName")]
                [Validation(Required=false)]
                public string OwnerReferenceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-27T13:59:23+08:00</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v2.4.4</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-A01D6CC3F4B8</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
