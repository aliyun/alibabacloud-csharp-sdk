// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvCustomJobsResponseBody : TeaModel {
        /// <summary>
        /// The response code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned information.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvCustomJobsResponseBodyData> Data { get; set; }
        public class ListEnvCustomJobsResponseBodyData : TeaModel {
            /// <summary>
            /// The attributed component name.
            /// </summary>
            [NameInMap("AddonName")]
            [Validation(Required=false)]
            public string AddonName { get; set; }

            /// <summary>
            /// The attributed component instance name.
            /// </summary>
            [NameInMap("AddonReleaseName")]
            [Validation(Required=false)]
            public string AddonReleaseName { get; set; }

            /// <summary>
            /// The attributed component version.
            /// </summary>
            [NameInMap("AddonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// If the request parameter encryptYaml is true, the base64-encoded yaml string is returned. Otherwise, the plaintext yaml string is returned.
            /// </summary>
            [NameInMap("ConfigYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// Creation time (timestamp).
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public string CreationTimestamp { get; set; }

            /// <summary>
            /// Custom job name.
            /// </summary>
            [NameInMap("CustomJobName")]
            [Validation(Required=false)]
            public string CustomJobName { get; set; }

            /// <summary>
            /// Environment instance ID.
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// scrape configuration.
            /// </summary>
            [NameInMap("ScrapeConfigs")]
            [Validation(Required=false)]
            public List<ListEnvCustomJobsResponseBodyDataScrapeConfigs> ScrapeConfigs { get; set; }
            public class ListEnvCustomJobsResponseBodyDataScrapeConfigs : TeaModel {
                /// <summary>
                /// Job name.
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// scrape the path of the metric.
                /// </summary>
                [NameInMap("MetricsPath")]
                [Validation(Required=false)]
                public string MetricsPath { get; set; }

                /// <summary>
                /// List of service discovery methods.
                /// </summary>
                [NameInMap("ScrapeDiscoverys")]
                [Validation(Required=false)]
                public List<string> ScrapeDiscoverys { get; set; }

                /// <summary>
                /// scrape interval.
                /// </summary>
                [NameInMap("ScrapeInterval")]
                [Validation(Required=false)]
                public string ScrapeInterval { get; set; }

            }

            /// <summary>
            /// state.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
