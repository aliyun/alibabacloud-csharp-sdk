// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvCustomJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvCustomJobsResponseBodyData> Data { get; set; }
        public class ListEnvCustomJobsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the add-on to which the custom job belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql</para>
            /// </summary>
            [NameInMap("AddonName")]
            [Validation(Required=false)]
            public string AddonName { get; set; }

            /// <summary>
            /// <para>The instance name of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql1</para>
            /// </summary>
            [NameInMap("AddonReleaseName")]
            [Validation(Required=false)]
            public string AddonReleaseName { get; set; }

            /// <summary>
            /// <para>The version of the add-on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.0</para>
            /// </summary>
            [NameInMap("AddonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// <para>If the request parameter EncryptYaml is set to true, a Base64-encoded YAML string is returned. Otherwise, a plaintext YAML string is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Refer to supplementary instructions.</para>
            /// </summary>
            [NameInMap("ConfigYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// <para>The time when the custom job was created. The value of this parameter is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T10:11:34Z</para>
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public string CreationTimestamp { get; set; }

            /// <summary>
            /// <para>The name of the custom job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job1</para>
            /// </summary>
            [NameInMap("CustomJobName")]
            [Validation(Required=false)]
            public string CustomJobName { get; set; }

            /// <summary>
            /// <para>The ID of the environment instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-xxxx</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The capture configurations.</para>
            /// </summary>
            [NameInMap("ScrapeConfigs")]
            [Validation(Required=false)]
            public List<ListEnvCustomJobsResponseBodyDataScrapeConfigs> ScrapeConfigs { get; set; }
            public class ListEnvCustomJobsResponseBodyDataScrapeConfigs : TeaModel {
                /// <summary>
                /// <para>The name of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom-sd-demo</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The path of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/metrics</para>
                /// </summary>
                [NameInMap("MetricsPath")]
                [Validation(Required=false)]
                public string MetricsPath { get; set; }

                /// <summary>
                /// <para>The service discovery methods.</para>
                /// </summary>
                [NameInMap("ScrapeDiscoverys")]
                [Validation(Required=false)]
                public List<string> ScrapeDiscoverys { get; set; }

                /// <summary>
                /// <para>The capture interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30s</para>
                /// </summary>
                [NameInMap("ScrapeInterval")]
                [Validation(Required=false)]
                public string ScrapeInterval { get; set; }

            }

            /// <summary>
            /// <para>The status of the custom job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A0CEDF1-06FE-44AC-8E21-21A5BE65****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
