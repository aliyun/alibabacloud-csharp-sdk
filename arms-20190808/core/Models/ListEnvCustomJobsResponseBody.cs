// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvCustomJobsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvCustomJobsResponseBodyData> Data { get; set; }
        public class ListEnvCustomJobsResponseBodyData : TeaModel {
            /// <summary>
            /// The name of the component to which the custom job belongs.
            /// </summary>
            [NameInMap("AddonName")]
            [Validation(Required=false)]
            public string AddonName { get; set; }

            /// <summary>
            /// The instance name of the component.
            /// </summary>
            [NameInMap("AddonReleaseName")]
            [Validation(Required=false)]
            public string AddonReleaseName { get; set; }

            /// <summary>
            /// The version of the component.
            /// </summary>
            [NameInMap("AddonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// If the request parameter EncryptYaml is set to true, a Base64-encoded YAML string is returned. Otherwise, a plaintext YAML string is returned.
            /// </summary>
            [NameInMap("ConfigYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// The time when the custom job was created. The value of this parameter is a timestamp.
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public string CreationTimestamp { get; set; }

            /// <summary>
            /// The name of the custom job.
            /// </summary>
            [NameInMap("CustomJobName")]
            [Validation(Required=false)]
            public string CustomJobName { get; set; }

            /// <summary>
            /// The ID of the environment instance.
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
            /// The capture configurations.
            /// </summary>
            [NameInMap("ScrapeConfigs")]
            [Validation(Required=false)]
            public List<ListEnvCustomJobsResponseBodyDataScrapeConfigs> ScrapeConfigs { get; set; }
            public class ListEnvCustomJobsResponseBodyDataScrapeConfigs : TeaModel {
                /// <summary>
                /// The name of the job.
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// The path of the metric.
                /// </summary>
                [NameInMap("MetricsPath")]
                [Validation(Required=false)]
                public string MetricsPath { get; set; }

                /// <summary>
                /// The service discovery methods.
                /// </summary>
                [NameInMap("ScrapeDiscoverys")]
                [Validation(Required=false)]
                public List<string> ScrapeDiscoverys { get; set; }

                /// <summary>
                /// The capture interval.
                /// </summary>
                [NameInMap("ScrapeInterval")]
                [Validation(Required=false)]
                public string ScrapeInterval { get; set; }

            }

            /// <summary>
            /// The status of the custom job.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
