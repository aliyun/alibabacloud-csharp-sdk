// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEnvPodMonitorsResponseBody : TeaModel {
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
        /// <para>The result of the operation.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEnvPodMonitorsResponseBodyData> Data { get; set; }
        public class ListEnvPodMonitorsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the add-on to which the PodMonitor belongs.</para>
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
            /// <para>1.0.5</para>
            /// </summary>
            [NameInMap("AddonVersion")]
            [Validation(Required=false)]
            public string AddonVersion { get; set; }

            /// <summary>
            /// <para>The YAML configuration string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Refer to supplementary instructions.</para>
            /// </summary>
            [NameInMap("ConfigYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// <para>The time when the PodMonitor was created. The value of this parameter is a timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2011-01-02T11:34:22Z</para>
            /// </summary>
            [NameInMap("CreationTimestamp")]
            [Validation(Required=false)]
            public string CreationTimestamp { get; set; }

            /// <summary>
            /// <para>The endpoints of the PodMonitor.</para>
            /// </summary>
            [NameInMap("Endpoints")]
            [Validation(Required=false)]
            public List<ListEnvPodMonitorsResponseBodyDataEndpoints> Endpoints { get; set; }
            public class ListEnvPodMonitorsResponseBodyDataEndpoints : TeaModel {
                /// <summary>
                /// <para>The collection interval.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30s</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// <para>The number of pods that match the PodMonitor endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MatchedTargetCount")]
                [Validation(Required=false)]
                public int? MatchedTargetCount { get; set; }

                /// <summary>
                /// <para>The collection path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/metrics</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The external port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9182</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The destination port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("TargetPort")]
                [Validation(Required=false)]
                public int? TargetPort { get; set; }

            }

            /// <summary>
            /// <para>The environment ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env-xxxxx</para>
            /// </summary>
            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public string EnvironmentId { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prom</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The name of the PodMonitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pm1</para>
            /// </summary>
            [NameInMap("PodMonitorName")]
            [Validation(Required=false)]
            public string PodMonitorName { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The status of the PodMonitor.</para>
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
        /// <para>4C518054-852F-4023-ABC1-4AF95FF7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
