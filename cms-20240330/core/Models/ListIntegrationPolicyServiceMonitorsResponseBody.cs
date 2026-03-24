// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyServiceMonitorsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ea119prod-ea119blinkcptssd1</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-ac38a7cb02d14ff48bc9f97d0a75063e</para>
        /// </summary>
        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD8BA7D6-995D-578D-9941-78B0FECD14B5</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of ServiceMonitors.</para>
        /// </summary>
        [NameInMap("serviceMonitors")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyServiceMonitorsResponseBodyServiceMonitors> ServiceMonitors { get; set; }
        public class ListIntegrationPolicyServiceMonitorsResponseBodyServiceMonitors : TeaModel {
            /// <summary>
            /// <para>The add-on name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud-acs-ecs</para>
            /// </summary>
            [NameInMap("addonName")]
            [Validation(Required=false)]
            public string AddonName { get; set; }

            /// <summary>
            /// <para>The name of the add-on release.</para>
            /// 
            /// <b>Example:</b>
            /// <para>release-1234567</para>
            /// </summary>
            [NameInMap("addonReleaseName")]
            [Validation(Required=false)]
            public string AddonReleaseName { get; set; }

            /// <summary>
            /// <para>The add-on version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("addonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// <para>The configuration YAML file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: xxxxx</para>
            /// </summary>
            [NameInMap("configYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// <para>The status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run</para>
            /// </summary>
            [NameInMap("enableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            /// <summary>
            /// <para>Indicates whether the YAML file is encrypted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YXBpVmVyc2lvbjogeHh4eHgK</para>
            /// </summary>
            [NameInMap("encryptYaml")]
            [Validation(Required=false)]
            public bool? EncryptYaml { get; set; }

            /// <summary>
            /// <para>The list of Endpoints.</para>
            /// </summary>
            [NameInMap("endpoints")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyServiceMonitorsResponseBodyServiceMonitorsEndpoints> Endpoints { get; set; }
            public class ListIntegrationPolicyServiceMonitorsResponseBodyServiceMonitorsEndpoints : TeaModel {
                /// <summary>
                /// <para>The collection interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30s</para>
                /// </summary>
                [NameInMap("interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// <para>The number of matched targets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65</para>
                /// </summary>
                [NameInMap("matchedTargetCount")]
                [Validation(Required=false)]
                public long? MatchedTargetCount { get; set; }

                /// <summary>
                /// <para>The collection path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/metrics</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The collection port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9100</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The target port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("targetPort")]
                [Validation(Required=false)]
                public string TargetPort { get; set; }

            }

            /// <summary>
            /// <para>The number of matched services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("matchedServiceCount")]
            [Validation(Required=false)]
            public long? MatchedServiceCount { get; set; }

            /// <summary>
            /// <para>The name of the ServiceMonitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>62a526c5-f6ca-4cfb-b5a4-b76974cffe51</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prom</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

        }

    }

}
