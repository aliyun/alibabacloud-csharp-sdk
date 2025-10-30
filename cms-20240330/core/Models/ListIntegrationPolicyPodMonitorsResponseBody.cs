// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyPodMonitorsResponseBody : TeaModel {
        /// <summary>
        /// <para>Cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>et15prod-et15storage</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>PodMonitor list</para>
        /// </summary>
        [NameInMap("podMonitors")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyPodMonitorsResponseBodyPodMonitors> PodMonitors { get; set; }
        public class ListIntegrationPolicyPodMonitorsResponseBodyPodMonitors : TeaModel {
            /// <summary>
            /// <para>Addon name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud-ecs</para>
            /// </summary>
            [NameInMap("addonName")]
            [Validation(Required=false)]
            public string AddonName { get; set; }

            /// <summary>
            /// <para>Addon Release name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>release-2345678</para>
            /// </summary>
            [NameInMap("addonReleaseName")]
            [Validation(Required=false)]
            public string AddonReleaseName { get; set; }

            /// <summary>
            /// <para>Addon version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("addonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// <para>Configuration yaml.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: xxxxx</para>
            /// </summary>
            [NameInMap("configYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// <para>Enable status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run</para>
            /// </summary>
            [NameInMap("enableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            /// <summary>
            /// <para>Encrypt yaml.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YXBpVmVyc2lvbjogeHh4eHgK</para>
            /// </summary>
            [NameInMap("encryptYaml")]
            [Validation(Required=false)]
            public bool? EncryptYaml { get; set; }

            /// <summary>
            /// <para>Instance endpoints.</para>
            /// </summary>
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyPodMonitorsResponseBodyPodMonitorsEndpoints> Endpoints { get; set; }
            public class ListIntegrationPolicyPodMonitorsResponseBodyPodMonitorsEndpoints : TeaModel {
                /// <summary>
                /// <para>Collection interval</para>
                /// 
                /// <b>Example:</b>
                /// <para>30s</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// <para>Number of matched targets</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("matchedTargetCount")]
                [Validation(Required=false)]
                public long? MatchedTargetCount { get; set; }

                /// <summary>
                /// <para>Metric collection path</para>
                /// 
                /// <b>Example:</b>
                /// <para>/metrics</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Port number</para>
                /// 
                /// <b>Example:</b>
                /// <para>9100</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>Target port</para>
                /// 
                /// <b>Example:</b>
                /// <para>https</para>
                /// </summary>
                [NameInMap("targetPort")]
                [Validation(Required=false)]
                public string TargetPort { get; set; }

            }

            /// <summary>
            /// <para>Number of matched pods</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("matchedPodCount")]
            [Validation(Required=false)]
            public long? MatchedPodCount { get; set; }

            /// <summary>
            /// <para>Collection name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>znzmo_entity_test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Namespace</para>
            /// 
            /// <b>Example:</b>
            /// <para>sla-ns-d5aeb2b4f91b47</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

        }

        /// <summary>
        /// <para>Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-c9efed2b99c348d49e589c5f780fc074</para>
        /// </summary>
        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
