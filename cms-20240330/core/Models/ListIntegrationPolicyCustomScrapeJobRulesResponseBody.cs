// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ListIntegrationPolicyCustomScrapeJobRulesResponseBody : TeaModel {
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
        /// <para>Custom scraping job rules</para>
        /// </summary>
        [NameInMap("customScrapeJobRules")]
        [Validation(Required=false)]
        public List<ListIntegrationPolicyCustomScrapeJobRulesResponseBodyCustomScrapeJobRules> CustomScrapeJobRules { get; set; }
        public class ListIntegrationPolicyCustomScrapeJobRulesResponseBodyCustomScrapeJobRules : TeaModel {
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
            /// <para>Addon Release name</para>
            /// 
            /// <b>Example:</b>
            /// <para>release-12345678</para>
            /// </summary>
            [NameInMap("addonReleaseName")]
            [Validation(Required=false)]
            public string AddonReleaseName { get; set; }

            /// <summary>
            /// <para>Addon version</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("addonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// <para>Configuration yaml</para>
            /// 
            /// <b>Example:</b>
            /// <para>scrape_cofnigs:</para>
            /// <list type="bullet">
            /// <item><description>jobxxxxxx</description></item>
            /// </list>
            /// </summary>
            [NameInMap("configYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// <para>Enable status</para>
            /// 
            /// <b>Example:</b>
            /// <para>mini</para>
            /// </summary>
            [NameInMap("enableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            /// <summary>
            /// <para>Encrypt yaml</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("encryptYaml")]
            [Validation(Required=false)]
            public bool? EncryptYaml { get; set; }

            /// <summary>
            /// <para>Matched pod count</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("matchedPodCount")]
            [Validation(Required=false)]
            public long? MatchedPodCount { get; set; }

            /// <summary>
            /// <para>Detailed information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlab1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Namespace</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-data</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>Custom configurations</para>
            /// </summary>
            [NameInMap("scrapeConfigs")]
            [Validation(Required=false)]
            public List<ListIntegrationPolicyCustomScrapeJobRulesResponseBodyCustomScrapeJobRulesScrapeConfigs> ScrapeConfigs { get; set; }
            public class ListIntegrationPolicyCustomScrapeJobRulesResponseBodyCustomScrapeJobRulesScrapeConfigs : TeaModel {
                /// <summary>
                /// <para>Scraping job name</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql-exporter</para>
                /// </summary>
                [NameInMap("jobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>Detailed information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Metrics path</para>
                /// 
                /// <b>Example:</b>
                /// <para>/metrics</para>
                /// </summary>
                [NameInMap("metricsPath")]
                [Validation(Required=false)]
                public string MetricsPath { get; set; }

                /// <summary>
                /// <para>Call method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("scheme")]
                [Validation(Required=false)]
                public string Scheme { get; set; }

                /// <summary>
                /// <para>Scrape interval</para>
                /// 
                /// <b>Example:</b>
                /// <para>30s</para>
                /// </summary>
                [NameInMap("scrapeInterval")]
                [Validation(Required=false)]
                public string ScrapeInterval { get; set; }

                /// <summary>
                /// <para>Scrape timeout</para>
                /// 
                /// <b>Example:</b>
                /// <para>60s</para>
                /// </summary>
                [NameInMap("scrapeTimeout")]
                [Validation(Required=false)]
                public string ScrapeTimeout { get; set; }

                /// <summary>
                /// <para>Service discovery configuration</para>
                /// </summary>
                [NameInMap("serviceDiscoveryConfigs")]
                [Validation(Required=false)]
                public List<string> ServiceDiscoveryConfigs { get; set; }

            }

        }

        /// <summary>
        /// <para>Policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>policy-15abcc24c06f4797832b5954198e1ed1</para>
        /// </summary>
        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CEC5375-C554-562B-A65F-9A629907C1F0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
