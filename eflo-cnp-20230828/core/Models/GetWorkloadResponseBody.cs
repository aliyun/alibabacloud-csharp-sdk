// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetWorkloadResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetWorkloadResponseBodyData Data { get; set; }
        public class GetWorkloadResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("DefaultCpuPerWorker")]
            [Validation(Required=false)]
            public int? DefaultCpuPerWorker { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DefaultGpuPerWorker")]
            [Validation(Required=false)]
            public int? DefaultGpuPerWorker { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("DefaultMemoryPerWorker")]
            [Validation(Required=false)]
            public int? DefaultMemoryPerWorker { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("DefaultShareMemory")]
            [Validation(Required=false)]
            public int? DefaultShareMemory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("Family")]
            [Validation(Required=false)]
            public string Family { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PyTorchJob</para>
            /// </summary>
            [NameInMap("JobKind")]
            [Validation(Required=false)]
            public string JobKind { get; set; }

            [NameInMap("ParamSettings")]
            [Validation(Required=false)]
            public List<GetWorkloadResponseBodyDataParamSettings> ParamSettings { get; set; }
            public class GetWorkloadResponseBodyDataParamSettings : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("ParamDesc")]
                [Validation(Required=false)]
                public string ParamDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ITERATION</para>
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[0-9]+</para>
                /// </summary>
                [NameInMap("ParamRegex")]
                [Validation(Required=false)]
                public string ParamRegex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>number</para>
                /// </summary>
                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NLP-LLM</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>common</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("StaticConfig")]
            [Validation(Required=false)]
            public GetWorkloadResponseBodyDataStaticConfig StaticConfig { get; set; }
            public class GetWorkloadResponseBodyDataStaticConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>PyTorch</para>
                /// </summary>
                [NameInMap("FrameWork")]
                [Validation(Required=false)]
                public string FrameWork { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>linux</para>
                /// </summary>
                [NameInMap("Os")]
                [Validation(Required=false)]
                public string Os { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7B</para>
                /// </summary>
                [NameInMap("Parameters")]
                [Validation(Required=false)]
                public string Parameters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>python</para>
                /// </summary>
                [NameInMap("SoftwareStack")]
                [Validation(Required=false)]
                public string SoftwareStack { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public long? VersionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadDescription")]
            [Validation(Required=false)]
            public string WorkloadDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("WorkloadId")]
            [Validation(Required=false)]
            public long? WorkloadId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("WorkloadName")]
            [Validation(Required=false)]
            public string WorkloadName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AI</para>
            /// </summary>
            [NameInMap("WorkloadType")]
            [Validation(Required=false)]
            public string WorkloadType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E67E2E4C-2B47-5C55-AA17-1D771E070AEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
